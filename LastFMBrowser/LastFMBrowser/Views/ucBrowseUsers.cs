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
    public partial class ucBrowseUsers : UserControl, ISwapPanelSubForm
    {

        private static uctrlTop5ArtistChart TopFivePie { get; set; }
        private static uctrlTop5ArtistChart FriendsTop5 { get; set; }
        private static LastFMDataEntities context { get; set; }

        private frmMain mParent { get; set; }
        private long ActiveUserID = -1;

        public ucBrowseUsers()
        {
            InitializeComponent();
            AddUCEventHandlers();
        }

        public ucBrowseUsers(long userID) : this()
        {
            ActiveUserID = userID;
        }

        private void AddUCEventHandlers()
        {
            this.lstMyArtists.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lstMyArtists_DrawItem);
        }

        public void RefreshUserControl()
        {
        }

        private void ucBrowseUsers_Load(object sender, EventArgs e)
        {
            InitUC();
        }

        private void InitUC()
        {
            mParent = (this.ParentForm as frmMain);

            context = new LastFMDataEntities();


 
            //Load data
            LoadUserList();
            if(ActiveUserID > 0)  lstUsers.SelectedValue = ActiveUserID;
            SetActiveUser((long) lstUsers.SelectedValue);
            LoadTopFivePie();
            LoadArtistList();
        }

        private long GetSelectedUser()
        {
            return ActiveUserID;
        }

        /********************************
        * Top Five Artists
       ********************************/

        private void LoadTopFivePie()
        {
            TopFivePie = new uctrlTop5ArtistChart(getTopFiveSQL());
            TopFivePie.Dock = DockStyle.Fill;
            if (panelMyTopFivePie.Controls.Count > 0) panelMyTopFivePie.Controls.Clear();
            panelMyTopFivePie.Controls.Add(TopFivePie);
        }


        private List<Tuple<string, int?>> getTopFiveSQL()
        {
            string mSQL;

            mSQL = String.Format(ucDashboard.QRY_01_TOP_FIVE_ARTISTS, GetSelectedUser());

            return GetQryList(mSQL);
        }

        public List<Tuple<string, int?>> GetQryList(string QrySQL)
        {
            List<Tuple<string, int?>> mReturn = new List<Tuple<string, int?>>();

            var results = context.Database.SqlQuery<QryResultNode>(QrySQL);

            
            foreach (var result in results)
            {
                mReturn.Add(new Tuple<string, int?>(result.ArtistName, result.Count));
            }
            

            return mReturn;
        }

        /********************************
         * Searchable list of all artists
        ********************************/

        private void LoadArtistList()
        {
            var results = context.Database.SqlQuery<QryResultNode>(String.Format(ucDashboard.QRY_02_ALL_USER_ARTISTS, GetSelectedUser(), txtSearchArtists.Text, "ArtistName"));


            Dictionary<long, string> listSource = new Dictionary<long, string>();

            try { var tempID = listSource.Count; }catch (Exception Exc) { return; }

            foreach (var result in results)
            {
                listSource.Add(result.ArtistID, result.ArtistName);
            }

            if (listSource.Count == 0) {listSource.Add(-1, "<no associated artists>");}

            lstMyArtists.DataSource = new BindingSource(listSource, null);
            lstMyArtists.DisplayMember = "Value";
            lstMyArtists.ValueMember = "Key";

            if (lstMyArtists.Items.Count > 0) lstMyArtists.SelectedIndex = 0;

            RefreshArtistAttributes();
        }

        private void lstMyArtists_DrawItem(object sender, DrawItemEventArgs e)
        {

            if (e.Index < 0) return;
            //if (lstMyArtists.Items.Count <= 0) return;
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

            }
            catch (Exception exc) { }


            // If the ListBox has focus, draw a focus rectangle around the selected item.
            e.DrawFocusRectangle();
        }

        private void RefreshArtistAttributes()
        {
            LoadTopFivePie();
            setArtistCount();
            RefTagList();
        }



        /// <summary>
        ///     Set lblCount that shows the total number of artists being displayed
        /// </summary>
        private void setArtistCount()
        {

            var results = context.Database.SqlQuery<QryArtistCount>
                (String.Format(ucDashboard.QRY_03_ALL_USERS_ARTISTS_COUNT,
                    String.Format(ucDashboard.QRY_02_ALL_USER_ARTISTS_CORE, GetSelectedUser(), txtSearchArtists.Text, "ArtistName"))).FirstOrDefault();


            lblArtistListHeader.Text = "Artists I Play (" + results.CountOfArtistName + " listed)";
        }

        private void txtSearchArtists_TextChanged(object sender, EventArgs e)
        {
            LoadArtistList();
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
                Console.WriteLine("Exception occured " + E.StackTrace);
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
            var results = context.Database.SqlQuery<QryTagValue>(String.Format(ucDashboard.QRY_04_ARTIST_TAGS, GetSelectedUser(), lstMyArtists.SelectedValue));

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


        /********************************
         * Searchable list of users
        *******************************/

        private void LoadUserList()
        {
            var results = context.Database.SqlQuery<QryUserList>(String.Format(ucDashboard.QRY_09_USER_FRIENDS, txtSearchFriends.Text));


            Dictionary<long, string> listSource = new Dictionary<long, string>();

            foreach (var result in results)
            {
                listSource.Add(result.UserID, result.FullName);
            }

            if (listSource.Count == 0)
            {
                listSource.Add(-1, "<no associated users>");
            }

            lstUsers.DataSource = new BindingSource(listSource, null);
            lstUsers.DisplayMember = "Value";
            lstUsers.ValueMember = "Key";

            if (lstUsers.Items.Count >= 1) lstUsers.SelectedIndex = 0;
            LoadArtistList();
        }

        private void lstUsers_Click(object sender, EventArgs e)
        {
            SetActiveUser((long)lstUsers.SelectedValue);
            LoadArtistList();
        }

        private void txtSearchFriends_TextChanged(object sender, EventArgs e)
        {
            LoadUserList();
            SetActiveUser((long)lstUsers.SelectedValue);
            LoadArtistList();
        }

        private void SetActiveUser(long newID)
        {
            ActiveUserID = newID;
            mParent.SetPageTitle("Browse Users - " + ((KeyValuePair<long, string>)lstUsers.SelectedItem).Value, false);
        }

        private void btnAddFriend_Click(object sender, EventArgs e)
        {
            AddNewFriend((long) mParent.GetActiveUser(), (long) lstUsers.SelectedValue);
        }

        private void AddNewFriend(long UserID, long FriendID)
        {
            try { context.spADD_FRIEND(UserID, FriendID); }
            catch (Exception exc) { Console.WriteLine(exc); throw exc; }
        }

    }
}
