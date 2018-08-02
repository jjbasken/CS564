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


namespace LastFMBrowser.Views
{
    public partial class ucArtistPage : UserControl, ISwapPanelSubForm
    {
        //Parent form
        private frmMain mParent { get; set; }
        private long userID;
        public ucArtistPage()
        {

            InitializeComponent();
        }

        private void OtherUserGrid_Load(long artistID, long user_ID)
        {
            LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
            dgOtherUsers.DataSource = db.FIND_ARTIST_LISTENERS(user_ID, artistID);
        }

        /// <summary>
        ///     Called by frmMain when user control is opened or needs to be refreshed
        /// </summary>
        public void RefreshUserControl()
        {
            dgUserTags_Load(frmMain.ArtistID);
            dgTopTags_Load(frmMain.ArtistID);
        }
        private void dgTopTracks_Load(long ArtistID)
        {
            try
            {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
                dgTopTracks.DataSource = db.FIND_TOP_TRACKS(ArtistID);
            } catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void dgTopTracks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String URL = dgTopTracks.Rows[e.RowIndex].Cells[2].Value.ToString();
            System.Diagnostics.Process.Start(URL);
        }
        private void dgTopTags_Load(long ArtistID)
        {
            try
            {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
                dgTopTags.DataSource = db.FIND_TOP_TAGS(ArtistID);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void dgSimilarArtists_Load(long ArtistID)
        {
            try
            {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
                dgSimilarArtists.DataSource = db.GET_SIMILAR_ARTISTS(ArtistID);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void dgSimilarArtists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                frmMain.ArtistID = Convert.ToInt32(dgSimilarArtists.Rows[e.RowIndex].Cells[0].Value.ToString());
                frmMain.ArtistName = dgSimilarArtists.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmMain.BandURL = dgSimilarArtists.Rows[e.RowIndex].Cells[2].Value.ToString();
                ucArtistPage artistPage = new ucArtistPage();
                mParent.ChangeSubForm(artistPage);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void OnLoad(object sender, EventArgs e)
        {
            mParent = (this.ParentForm as frmMain);
            if (frmMain.ArtistID == 0)
            {
                this.Hide();
                ucArtistSearch artistSearch = new ucArtistSearch();
                mParent.ChangeSubForm(artistSearch);
            }
            else
            {
                userID = mParent.GetActiveUser();
                mParent.SetPageTitle("Artist Pages: " +  frmMain.ArtistName + "", false);
                dgTopTracks_Load(frmMain.ArtistID);
                dgTopTags_Load(frmMain.ArtistID);
                dgSimilarArtists_Load(frmMain.ArtistID);
                dgUserTags_Load(frmMain.ArtistID);
                OtherUserGrid_Load(frmMain.ArtistID, userID);
                lnkArtistHeader.Text = frmMain.ArtistName;
            }

        }
        private void dgUserTags_Load(long ArtistID)
        {
             try
            {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
               
                var tags = (from tag in db.lnkUserTagArtists
                             join tagInfos in db.tblTags on tag.TagID equals tagInfos.tagID
                             where tag.UserID ==  userID && tag.ArtistID == frmMain.ArtistID
                             group tagInfos by tagInfos.tagValue into tagGroup
                             select new
                             {
                                 tagValue = tagGroup.Key,
                                 count = tagGroup.Count()
                             }

                             ).Distinct().OrderByDescending(x => x.count).Take(20);
                 dgUserTags.DataSource = tags.ToList();
             }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnAddTag_Click(object sender, EventArgs e)
        {
            try
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Enter tag", "Add a tag", "", -1, -1);
            LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
            db.TAG_ARTIST(userID, frmMain.ArtistID, input);
            } catch (Exception exc)
            {
                if (exc.InnerException != null)
                    MessageBox.Show(exc.InnerException.Message);
                else
                    MessageBox.Show(exc.Message);
            }
            this.RefreshUserControl();
        }

        private void userTagKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                try
                {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
                db.REMOVE_TAG(userID, frmMain.ArtistID, dgUserTags.SelectedCells[0].Value.ToString());
                this.RefreshUserControl();
                }
                catch (Exception e_userTagKeyDown)
                {
                    MessageBox.Show(e_userTagKeyDown.Message);
                }
            }
        }

        private void ArtistHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(frmMain.BandURL);
        }

        private void btnArtistSearch_Click(object sender, EventArgs e)
        {
            frmMain.ArtistID = 0;
            LastFMBrowser.Views.ucArtistSearch artistSearch = new ucArtistSearch();
            mParent.ChangeSubForm(artistSearch);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LastFMBrowser.Views.ucTagSearch tagSearch = new ucTagSearch();
            mParent.ChangeSubForm(tagSearch);
        }

        private void dgTopTags_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                runTagSearch(dgTopTags.SelectedCells[0].Value.ToString());
            }
            catch (Exception e_dgTopTags_CellContentClick)
            {
                MessageBox.Show(e_dgTopTags_CellContentClick.Message);
            }
        }
        private void runTagSearch(String tag)
        {
            LastFMBrowser.Views.ucTagSearch tagSearch = new ucTagSearch(tag);
            mParent.ChangeSubForm(tagSearch);
        }

        private void dgUserTags_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                runTagSearch(dgUserTags.SelectedCells[0].Value.ToString());
            } catch (Exception e_dgUserTagsClick)
            {
                MessageBox.Show(e_dgUserTagsClick.Message);
            }
        }

        private void dgOtherUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                long otherUserId = Convert.ToInt32(dgOtherUsers.SelectedCells[0].Value.ToString());
                ucBrowseUsers otherUser = new ucBrowseUsers(otherUserId);
                mParent.ChangeSubForm(otherUser);
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
