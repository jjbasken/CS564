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
using System.Data.SqlClient;

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


        public const string QRY_02_ALL_USER_ARTISTS_CORE = "(SELECT(ArtistName + ' (' + trim(str(L.ArtistID)) + ')') AS ArtistName, L.ArtistID " +
                                                         "FROM tblArtist AS A1 INNER JOIN lnkUserArtist AS L ON A1.ArtistID = L.ArtistID " +
                                                         "WHERE L.UserID = {0}  AND ArtistName Like '%{1}%' UNION " +
                                                         "SELECT ArtistName, A2.ArtistID FROM tblArtist AS A2 " +
                                                         "INNER JOIN lnkUserTagArtist AS L ON A2.ArtistID = L.ArtistID " +
                                                         "WHERE L.UserID = {0}  AND ArtistName Like '%{1}%' " +
                                                         "AND L.ArtistID NOT IN (SELECT ArtistID FROM lnkUserArtist WHERE UserID = L.UserID))";

        public const string QRY_02_ALL_USER_ARTISTS = QRY_02_ALL_USER_ARTISTS_CORE + " ORDER BY {2}";

        public const string QRY_03_ALL_USERS_ARTISTS_COUNT = "SELECT Count(ArtistName) AS CountOfArtistName FROM" +
                                                            "({0}) AS Qry";


        public const string QRY_04_ARTIST_TAGS = "SELECT TagID, TagValue FROM tblTags AS T WHERE " +
                                                 "EXISTS (SELECT UserID, ArtistID, TagID " +
                                                 "FROM lnkUserTagArtist AS L WHERE UserID = {0} AND L.TagID = T.TagID AND  " +
                                                 "L.ArtistID = {1});";



        //In ctrlDynamicMenuExpandable
        public const string QRY_05_TOP_FIVE_ARTISTS = "SELECT * FROM sysMenuList ORDER BY rank;";


        public const string QRY_06_USER_FRIENDS = "SELECT UserID AS FriendID, FullName AS FriendName FROM tblUsers AS T " +
                                                  "WHERE EXISTS (SELECT L.FriendID FROM dbo.lnkUserFriends AS L " + 
                                                                 "WHERE UserID = {0} AND T.userID = L.friendID) " +
                                                   "AND FullName Like '%{1}%' ORDER BY FriendName;";

        public const string QRY_07_ALL_TAGS = "SELECT TagID, TagValue FROM tblTags " +
                                              "WHERE TagValue Like '%{0}%' ORDER BY TagValue;";

        //public const string QRY_08_ALL_USERS = "SELECT UserID, FullName FROM tblUsers;";

        public const string QRY_08_ALL_USERS = "SELECT UserID, FullName FROM tblUsers WHERE UserID IN " + 
                                               "(SELECT TOP 100 UserID FROM lnkUserArtist AS L " + 
                                               "GROUP BY UserID ORDER BY COUNT(UserID) DESC);";

        public const string QRY_09_USER_FRIENDS = "SELECT UserID, FullName FROM tblUsers " +
                                                 "WHERE FullName Like '%{0}%' ORDER BY FullName;";


        /********************************
         * Additional Queries and Stored Procedures can be found
        ********************************/




        //public const StoredProcedure_01 = FIND_USER_NAME(UserID)
        //public const StoredProcedure_02 = spFIND_ARTIST_DETAIL(ArtistID)

        //"SELECT TagValue FROM tblTags AS T WHERE " +
        //                                     "EXISTS (SELECT UserID, ArtistID, TagID FROM lnkUserTagArtist AS L " +
        //                                     "WHERE UserID = {0} AND ArtistID = {1} AND L.TagID = T.TagID);";


        /********************************
         * Form Objects
        ********************************/

        private static uctrlTop5ArtistChart TopFivePie { get; set; }
        private static uctrlTop5ArtistChart FriendsTop5 { get; set; }
        private static LastFMDataEntities context { get;  set; }
        private static frmSelectTag sTag { get; set; }
        //Parent form
        private  frmMain mParent { get; set; }
        /********************************
         * Constructor
        ********************************/
        
        public ucDashboard()
        {
            InitializeComponent();
            sTag = new frmSelectTag();
            AddUCEventHandlers();
            
        }

        

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            InitUC();
        }

        private void InitUC()
        {
            mParent = (this.ParentForm as frmMain);
            context = new LastFMDataEntities();
            
            //Set title with query
            mParent.SetPageTitle(context.spFIND_USER_NAME(mParent.GetActiveUser()).FirstOrDefault() + "");

            //Load data
            LoadTopFivePie();
            LoadArtistList();
            LoadFriendList();
            LoadFriendsTopFivePie();
            
        }


        /*******************************
        * Subscribe and Handel to broadcasts
        *******************************/

        /// <summary>
        ///     Adds handlers based on delegates in associated classes
        /// </summary>
        private void AddUCEventHandlers()
        {
            this.lstMyArtists.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstMyArtists_DrawItem);
        }
        
        /// <summary>
        ///     frmSelecteTag has triggered a TagSelectedEvent as the result of the user selecting a tag from the ist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTagSelected(object sender, EventArgs e)
        {
            long mUserID  = (long) mParent.GetActiveUser();
            AddNewTag((long) mUserID, (long) lstMyArtists.SelectedValue, (int) frmSelectTag.SelectedTagID);
            RefTagList();
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
            mSQL = String.Format(QRY_01_TOP_FIVE_ARTISTS, mParent.GetActiveUser());
            return GetQryList(mSQL);
        }

        public List<Tuple<string, int?>> GetQryList(string QrySQL)
        {

            List<Tuple<string, int?>> mReturn = new List<Tuple<string, int?>>();

            //LastFMDataEntities context = new LastFMDataEntities();

            var results = context.Database.SqlQuery<QryResultNode>(QrySQL);

            //mReturn = results.ToList<Tuple<string, int?>>();
            try { var mInt = results.Count() <= 0; 
                    foreach (var result in results)
                    {
                        mReturn.Add(new Tuple<string, int?>(result.ArtistName , result.Count));
                    }
            }
            catch (SqlException sExc) { return null;}

            return mReturn;
        }

        /********************************
         * Searchable list of all artists
        ********************************/

        private void LoadArtistList()
        {
            var results = context.Database.SqlQuery<QryResultNode>(String.Format(QRY_02_ALL_USER_ARTISTS, mParent.GetActiveUser(), txtSearchArtists.Text, "ArtistName"));


            Dictionary<long, string> listSource = new Dictionary<long, string>();

            foreach (var result in results)
            {
                listSource.Add(result.ArtistID, result.ArtistName);
            }


            if (listSource.Count == 0)
            {
                listSource.Add(-1, "<no associated artists>");
            }


            lstMyArtists.DataSource = new BindingSource(listSource, null);
            lstMyArtists.DisplayMember = "Value";
            lstMyArtists.ValueMember = "Key";

            if (lstMyArtists.Items.Count > 0) lstMyArtists.SelectedIndex = 0;

            

            RefreshArtistAttributes();
        }

        private void lstMyArtists_DrawItem(object sender, DrawItemEventArgs e)
        {
            
            if (e.Index < 0) return;
            if (lstMyArtists.Items.Count <= 0) return;
            Brush myBrush = Brushes.Black;
            e.DrawBackground();
            //if the item state is selected them change the back color 
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
            {
                myBrush = Brushes.DarkRed;

                e = new DrawItemEventArgs(e.Graphics,
                                          e.Font,
                                          e.Bounds,
                                          e.Index,
                                          e.State ^ DrawItemState.Selected,
                                          Color.White,
                                          Color.DarkGoldenrod);//Choose the color
                e.Graphics.FillRectangle(Brushes.White, e.Bounds);
            }
            else
            {
                myBrush = Brushes.Black;
                e.Graphics.FillRectangle(Brushes.Black, e.Bounds);
            }

            // Draw the background of the ListBox control for each item.
            e.DrawBackground();
            // Draw the current item text
            try
            {
                string mStr = ((KeyValuePair<long, string>)lstMyArtists.Items[e.Index]).Value;
                e.Graphics.DrawString(mStr, e.Font, myBrush, e.Bounds, StringFormat.GenericDefault);

            } catch (Exception exc){}
            
            
            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void RefreshArtistAttributes()
        {
            setArtistCount();
            RefTagList();
        }

        

        /// <summary>
        ///     Set lblCount that shows the total number of artists being displayed
        /// </summary>
        private void setArtistCount()
        {
            var results = context.Database.SqlQuery < QryArtistCount >
                (String.Format(QRY_03_ALL_USERS_ARTISTS_COUNT,
                    String.Format(QRY_02_ALL_USER_ARTISTS_CORE, mParent.GetActiveUser(), txtSearchArtists.Text, "ArtistName"))).FirstOrDefault();
            

            lblArtistListHeader.Text = "Artists I Play (" +  results.CountOfArtistName + " listed)";
        }

        private void txtSearchArtists_TextChanged(object sender, EventArgs e)
        {
            LoadArtistList();
            RefreshArtistAttributes();
        }

        /// <summary>
        ///     Open up the artist form with the selected artist
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstMyArtists_DoubleClick(object sender, EventArgs e)
        {
            //I need a way to look up the artist
            //Could either do a simple query based on name, or I could 
            //

            long mArtistID;


            try
            {
                mArtistID = (long)lstMyArtists.SelectedValue;

            }
            catch (Exception E)
            {
                mArtistID = -1;
            }

            var artistDetails = context.spFIND_ARTIST_DETAIL(mArtistID).FirstOrDefault();


            try
            {
                frmMain.ArtistID = artistDetails.ArtistID;
                frmMain.ArtistName = artistDetails.ArtistName;
                frmMain.BandURL = artistDetails.BandURL;


            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

            mParent.ChangeSubForm(new ucArtistPage());

            

        }

        private void lstMyArtists_Click(object sender, EventArgs e)
        {
            RefreshArtistAttributes();
        }

        private void lstMyArtists_MouseEnter(object sender, EventArgs e)
        {
            mParent.SetPageFooter("Double click to open up artist");
        }

        private void lstMyArtists_MouseLeave(object sender, EventArgs e)
        {
            mParent.ClearPageFooter();
        }



        /********************************
         * Artist Tag Lists
        *******************************/
        private void RefTagList()
        {
            var results = context.Database.SqlQuery<QryTagValue>(String.Format(QRY_04_ARTIST_TAGS, mParent.GetActiveUser(), lstMyArtists.SelectedValue));

            Dictionary<int, string> listSource = new Dictionary<int, string>();


            try { var mInt = results.Count() <= 0; } catch (SqlException sExc) { return; }
            foreach (var result in results)
            {
                listSource.Add(result.TagID, result.TagValue);
            }

            if (listSource.Count == 0)
            {
                listSource.Add(-1, "<no associated tags>");
            }

            lstMyTags.DataSource = new BindingSource(listSource, null);
            lstMyTags.DisplayMember = "Value";
            lstMyTags.ValueMember = "Key";
        }

        private void AddNewTag(long UserID, long ArtistID, int TagID)
        {
            try {context.spSET_USER_ARTIST_TAGS(UserID, ArtistID, TagID);}
            catch (Exception exc) {Console.WriteLine(exc); throw exc; }
        }

        /// <summary>
        /// Removes the userid-artistid-tagid link
        /// </summary>
        /// <param name="UserID"></param>
        /// <param name="ArtistID"></param>
        /// <param name="TagID"></param>
        private void RemoveTag(long UserID, long ArtistID, int TagID)
        {
            try
            {
                context.spREMOVE_USER_ARTIST_TAGS(UserID, ArtistID, TagID);
                RefTagList();
            }
            catch (Exception e_userTagKeyDown){MessageBox.Show(e_userTagKeyDown.Message);}
        }

        private void btnRemoveTag_Click(object sender, EventArgs e)
        {
            long mUserID = (long)mParent.GetActiveUser();
            try
            {


                RemoveTag(mUserID, (long)lstMyArtists.SelectedValue, (int)lstMyTags.SelectedValue);

            } catch (NullReferenceException exc)
            {
                Console.WriteLine("Exception thrown removing tag - " + exc.StackTrace);
                MessageBox.Show("You must first select the tag you want to remove");
            }

        }

        private void btnAddTag_MouseEnter(object sender, EventArgs e)
        {
            mParent.SetPageFooter("Click to add a new tag");
        }

        private void btnAddTag_MouseLeave(object sender, EventArgs e)
        {
            mParent.ClearPageFooter();
        }

        private void btnRemoveTag_MouseEnter(object sender, EventArgs e)
        {
            mParent.SetPageFooter("Click to remove the selected tag");
        }

        private void btnRemoveTag_MouseLeave(object sender, EventArgs e)
        {
            mParent.ClearPageFooter();
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            sTag = new frmSelectTag();
            sTag.TagSelected += new frmSelectTag.TagSelectedEventHandler(OnTagSelected);
            sTag.Show();
        }

        /********************************
         * Additional Public Helper Functions
        *******************************/
        /// <summary>
        ///     Called by frmMain when user control is opened or needs to be refreshed
        /// </summary>
        public void RefreshUserControl()
        {

        }

        /********************************
         * Searchable Friends List
        *******************************/


        // QRY_06_USER_FRIENDS

        /********************************
         * Form Control Events
        ********************************/

        private void LoadFriendList()
        {
            var results = context.Database.SqlQuery<QryFriendList>(String.Format(QRY_06_USER_FRIENDS, mParent.GetActiveUser(), txtSearchFriends.Text));


            Dictionary<long, string> listSource = new Dictionary<long, string>();

            try { var mInt = results.Count() <= 0; } catch (SqlException sExc) { return; }

            foreach (var result in results)
            {
                listSource.Add(result.FriendID, result.FriendName);
            }

            if(listSource.Count == 0)
            {
                listSource.Add(-1, "<no associated Friends>");
            }

            lstFriends.DataSource = new BindingSource(listSource, null);
            lstFriends.DisplayMember = "Value";
            lstFriends.ValueMember = "Key";
            

            if (lstFriends.Items.Count > 0) lstFriends.SelectedIndex = 0;
        }


        /********************************
         * Friends Top 5
        ********************************/

        private void LoadFriendsTopFivePie()
        {
            if (panelFriendsTop5.Controls.Count > 0) panelFriendsTop5.Controls.Clear();
            FriendsTop5 = new uctrlTop5ArtistChart(getFriendsTop5SQL());
            FriendsTop5.Dock = DockStyle.Fill;
            panelFriendsTop5.Controls.Add(FriendsTop5);
        }


        private List<Tuple<string, int?>> getFriendsTop5SQL()
        {
            string mSQL;
            if (lstFriends.Items.Count > 0)
            {
                mSQL = String.Format(QRY_01_TOP_FIVE_ARTISTS, lstFriends.SelectedValue);
            } else
            {
                mSQL = "SELECT '' AS ArtistName, 0 as [Count], -1 AS UserID;";
            }

            return GetQryList(mSQL);
        }

        private void lstFriends_Click(object sender, EventArgs e)
        {
            LoadFriendsTopFivePie();
        }

        private void txtSearchFriends_TextChanged(object sender, EventArgs e)
        {
            LoadFriendList();
            LoadFriendsTopFivePie();
        }

        private void lstFriends_DoubleClick(object sender, EventArgs e)
        {
            ucBrowseUsers mBrowseUsers = new ucBrowseUsers((long)lstFriends.SelectedValue);
            mParent.ChangeSubForm(mBrowseUsers); 
        }
    }

    /********************************
    * Helper Classes
    ********************************/

    class QryResultNode
    { 
        public string ArtistName { get; set; }
        public long ArtistID { get; set; }
        public int? Count { get; set; }
    }

    class QryArtistCount
    {
        public int? CountOfArtistName { get; set; }
    }

    class QryTagValue
    {
        public int TagID { get; set; }
        public String TagValue { get; set; }
    }

    class QryFriendList
    {
        public string FriendName { get; set; }
        public long FriendID { get; set; }

    }

}
