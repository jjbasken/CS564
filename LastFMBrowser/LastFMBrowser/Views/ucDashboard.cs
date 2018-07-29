using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LastFMBrowser.Interfaces;
using LastFMBrowser.Models;

namespace LastFMBrowser.Views
{
    public partial class ucDashboard : UserControl, ISwapPanelSubForm
    {

        /********************************
         * SQl Queries Utilized on this form
        ********************************/

        //NOTE - I normally would not use SQL queries as constants, I would put them in the associated function.  But
        //given the assignement is based around the queries I thought I would put mine in convineint and grouped locations


        public const string QRY_01_TOP_FIVE_ARTISTS = "SELECT TOP 5 A.ArtistName, [Count],  UserID " +
                                                       "FROM lnkUserArtist AS L " +
                                                       "INNER JOIN tblArtist AS A " +
                                                       "ON A.ArtistID = L.ArtistID " +
                                                       "WHERE UserID = {0} " +
                                                       "ORDER BY [Count] DESC;";

        //TODO:
        //I want to pull in count as well, but since I did this query as the exists qry I cant in here.
        //Consider making this a join and qry 1 an exists.  Or just don't worry about exists
        //Also, there are artists that are tagged by a user but that have not been played by them, so need to account for that
        //public const string QRY_02_ALL_USER_ARTISTS = "SELECT ArtistName FROM tblArtist AS A WHERE EXISTS " +
                                                      //"(SELECT UserID, ArtistID FROM lnkUserArtist AS L " +
                                                      //"WHERE UserID = {0} AND A.ArtistID = L.ArtistID) " +
                                                      //"AND ArtistName Like '%{1}%' " +
                                                      //"ORDER BY ArtistName;";

        public const string QRY_02_ALL_USER_ARTISTS_CORE =    "(SELECT(ArtistName + ' (' + trim(str(L.ArtistID)) + ')') AS ArtistName, L.ArtistID " +
                                                         "FROM tblArtist AS A1 INNER JOIN lnkUserArtist AS L ON A1.ArtistID = L.ArtistID " +
                                                         "WHERE L.UserID = {0}  AND ArtistName Like '%{1}%' UNION " +
                                                         "SELECT ArtistName, A2.ArtistID FROM tblArtist AS A2 " +
                                                         "INNER JOIN lnkUserTagArtist AS L ON A2.ArtistID = L.ArtistID " +
                                                         "WHERE L.UserID = {0}  AND ArtistName Like '%{1}%')";

        public const string QRY_02_ALL_USER_ARTISTS = QRY_02_ALL_USER_ARTISTS_CORE + " ORDER BY {2}";

        //+
        //                                             "AND ArtistName Like '%{1}%');";

        //public const string QRY_03_ALL_USERS_ARTISTS_COUNT = "SELECT Count(ArtistName) AS CountOfArtistName " +
        //                                                     "FROM tblArtist AS A WHERE EXISTS " +
        //                                                     "(SELECT UserID, ArtistID FROM lnkUserArtist AS L " +
        //                                                     "WHERE UserID = {0} AND A.ArtistID = L.ArtistID);";


        public const string QRY_03_ALL_USERS_ARTISTS_COUNT = "SELECT Count(ArtistName) AS CountOfArtistName FROM" +
                                                            "({0}) AS Qry";

        /* This was working directly in SSMS
         * SELECT Count(ArtistName) AS CountOfArtistName 
FROM (
		SELECT(ArtistName + ' (' + trim(str(L.ArtistID)) + ')') AS ArtistName, L.ArtistID FROM tblArtist AS A1 
		INNER JOIN lnkUserArtist AS L ON A1.ArtistID = L.ArtistID 
		WHERE L.UserID = 89  AND ArtistName Like '%%' 
		UNION SELECT ArtistName, A2.ArtistID FROM tblArtist AS A2 
		INNER JOIN lnkUserTagArtist AS L ON A2.ArtistID = L.ArtistID 
		WHERE L.UserID = 89  AND ArtistName Like '%%'
		) AS Qry */

        public const string QRY_04_ARTIST_TAGS = "SELECT TagValue FROM tblTags AS T WHERE " +
                                                 "EXISTS (SELECT UserID, ArtistID, TagID " +
                                                 "FROM lnkUserTagArtist AS L WHERE UserID = {0} AND L.TagID = T.TagID AND  " +
                                                 "EXISTS (SELECT ArtistName FROM tblArtist AS A WHERE ArtistName = '{1}' " +
                                                 " AND L.ArtistID = A.ArtistID));";

            
            
            //"SELECT TagValue FROM tblTags AS T WHERE " +
            //                                     "EXISTS (SELECT UserID, ArtistID, TagID FROM lnkUserTagArtist AS L " +
            //                                     "WHERE UserID = {0} AND ArtistID = {1} AND L.TagID = T.TagID);";
        /********************************
         * Form Objects
        ********************************/

        private static uctrlTop5ArtistChart TopFivePie { get; set; }
        private static LastFMDataEntities context { get;  set; }
        //Parent form
        private  frmMain mParent { get; set; }
        /********************************
         * Constructor
        ********************************/

        public ucDashboard()
        {
            InitializeComponent();
            
        }

        /********************************
         * Form Initialization
        *******************************/

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            InitUC();
        }

        private void InitUC()
        {
            mParent = (this.ParentForm as frmMain);
            


            //Set title with query
            //GetActiveUser
            context = new LastFMDataEntities();
            mParent.SetPageTitle(context.FIND_USER_NAME(mParent.GetActiveUser()).FirstOrDefault() + "");
            Console.WriteLine("About to load top five");
            LoadTopFivePie();
            Console.WriteLine("About to load Artist List");
            LoadArtistList();

            
        }


        /********************************
         * Top Five Artists
        ********************************/

        private void LoadTopFivePie()
        {
            TopFivePie = new uctrlTop5ArtistChart(getTopFiveSQL());
            TopFivePie.Dock = DockStyle.Fill;
            panelMyTopFivePie.Controls.Add(TopFivePie);
        }


        private List<Tuple<string, int?>> getTopFiveSQL()
        {
            string mSQL;
            Console.WriteLine("Active User is = " + mParent.GetActiveUser());
            Console.WriteLine("mQry is " + String.Format(QRY_01_TOP_FIVE_ARTISTS, mParent.GetActiveUser()));

            mSQL = String.Format(QRY_01_TOP_FIVE_ARTISTS, mParent.GetActiveUser());

            return GetQryList(mSQL);
        }

        public List<Tuple<string, int?>> GetQryList(string QrySQL)
        {

            List<Tuple<string, int?>> mReturn = new List<Tuple<string, int?>>();

            //LastFMDataEntities context = new LastFMDataEntities();

            var results = context.Database.SqlQuery<QryResultNode>(QrySQL);

            //mReturn = results.ToList<Tuple<string, int?>>();
            
            foreach (var result in results)
            {
                Console.WriteLine("Adding [" + result.ArtistName + "," + result.Count + "]");
                mReturn.Add(new Tuple<string, int?>(result.ArtistName , result.Count));
            }

            return mReturn;
        }

        /********************************
         * Searchable list of all artists
        ********************************/

        private void LoadArtistList()
        {
            lstMyArtists.Items.Clear();
            //LastFMDataEntities context = new LastFMDataEntities();
            Console.WriteLine("Expected SQL = " + String.Format(QRY_02_ALL_USER_ARTISTS, mParent.GetActiveUser(), txtSearchArtists.Text, "ArtistName"));
            var results = context.Database.SqlQuery<QryResultNode>(String.Format(QRY_02_ALL_USER_ARTISTS, mParent.GetActiveUser(), txtSearchArtists.Text, "ArtistName"));


            foreach (var result in results)
            {
                this.lstMyArtists.Items.Add(result.ArtistName);
            }


            if (lstMyArtists.Items.Count > 0) lstMyArtists.SelectedIndex = 0;

            //Set count so we can see how many artists a user listens too
            
            RefreshArtistAttributes();
        }

        private void RefreshArtistAttributes()
        {
            setArtistCount();
            RefTagList();
        }

        private void RefTagList()
        {
            Console.WriteLine("Refreshing tag list with artist id = " + lstMyArtists.SelectedItem);
            Console.WriteLine("SQL = " + String.Format(QRY_04_ARTIST_TAGS, mParent.GetActiveUser(), lstMyArtists.SelectedItem));
            var results = context.Database.SqlQuery<QryTagValue>(String.Format(QRY_04_ARTIST_TAGS, mParent.GetActiveUser(), lstMyArtists.SelectedItem));

            lstMyTags.Items.Clear();
            foreach (var result in results)
            {
                this.lstMyTags.Items.Add(result.TagValue);
            }
        }

        /// <summary>
        ///     Set lblCount that shows the total number of artists being displayed
        /// </summary>
        private void setArtistCount()
        {
            //var results = context.Database.SqlQuery<QryArtistCount>
            //    (String.Format(QRY_03_ALL_USERS_ARTISTS_COUNT, mParent.GetActiveUser())).FirstOrDefault();

            Console.WriteLine(String.Format(QRY_03_ALL_USERS_ARTISTS_COUNT,
                    String.Format(QRY_02_ALL_USER_ARTISTS_CORE, mParent.GetActiveUser(), txtSearchArtists.Text, "ArtistName")));
            var results = context.Database.SqlQuery < QryArtistCount >
                (String.Format(QRY_03_ALL_USERS_ARTISTS_COUNT,
                    String.Format(QRY_02_ALL_USER_ARTISTS_CORE, mParent.GetActiveUser(), txtSearchArtists.Text, "ArtistName"))).FirstOrDefault();
            

            lblArtistListHeader.Text = "Artists I Play (" +  results.CountOfArtistName + " listed)";
        }
        /********************************
         * Private Helper Functions
        ********************************/
        /// <summary>
        ///     Called by frmMain when user control is opened or needs to be refreshed
        /// </summary>
        public void RefreshUserControl()
        {
            throw new NotImplementedException();
        }

 

        private void txtSearchArtists_TextChanged(object sender, EventArgs e)
        {
            LoadArtistList();
            RefreshArtistAttributes();
        }

        private void lstMyArtists_DoubleClick(object sender, EventArgs e)
        {

        }

        private void lstMyArtists_Click(object sender, EventArgs e)
        {
            RefreshArtistAttributes();
        }




        /********************************
         * Form based events
        ********************************/


    }






    /********************************
    * Helper Classes
    ********************************/

    class QryResultNode
    { 
        public string ArtistName { get; set; }
        public int? Count { get; set; }
    }

    class QryArtistCount
    {
        public int? CountOfArtistName { get; set; }
    }

    class QryTagValue
    {
        public String TagValue { get; set; }
    }

}
