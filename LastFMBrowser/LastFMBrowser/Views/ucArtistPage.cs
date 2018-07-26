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
        public ucArtistPage()
        {
            InitializeComponent();
            if (frmMain.ArtistID != 0)
            {
                dgTopTracks_Load(frmMain.ArtistID);
                dgTopTags_Load(frmMain.ArtistID);
                dgSimilarArtists_Load(frmMain.ArtistID);
                dgUserTags_Load(frmMain.ArtistID);
                OtherUserGrid_Load(frmMain.ArtistID, frmMain.User_ID);
                lnkArtistHeader.Text = frmMain.ArtistName;
            }

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
            LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
            dgTopTracks.DataSource = db.FIND_TOP_TRACKS(ArtistID);
        }

        private void dgTopTracks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String URL = dgTopTracks.Rows[e.RowIndex].Cells[2].Value.ToString();
            System.Diagnostics.Process.Start(URL);
        }
        private void dgTopTags_Load(long ArtistID)
        {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
                dgTopTags.DataSource = db.FIND_TOP_TAGS(ArtistID);
        }
        private void dgSimilarArtists_Load(long ArtistID)
        {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
                dgSimilarArtists.DataSource = db.GET_SIMILAR_ARTISTS(ArtistID);
        }

        private void dgSimilarArtists_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMain.ArtistID = Convert.ToInt32(dgSimilarArtists.Rows[e.RowIndex].Cells[0].Value.ToString());
            frmMain.ArtistName = dgSimilarArtists.Rows[e.RowIndex].Cells[1].Value.ToString();
            frmMain.BandURL = dgSimilarArtists.Rows[e.RowIndex].Cells[2].Value.ToString();
            this.Hide();
            frmMain parentForm = (this.ParentForm as frmMain);
            UserControl mNewSub = (UserControl)Activator.CreateInstance(Type.GetType("LastFMBrowser.Views.ucArtistPage"));
            parentForm.SetSubForm((ISwapPanelSubForm)mNewSub);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            if (frmMain.ArtistID == 0)
            {
                this.Hide();
                frmMain parentForm = (this.ParentForm as frmMain);
                UserControl mNewSub = (UserControl)Activator.CreateInstance(Type.GetType("LastFMBrowser.Views.ucArtistSearch"));
                parentForm.SetSubForm((ISwapPanelSubForm)mNewSub);
            }
        }
        private void dgUserTags_Load(long ArtistID)
        {
            try
            {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();

                var tags = (from tag in db.lnkUserTagArtists
                            join tagInfos in db.tblTags on tag.TagID equals tagInfos.tagID
                            where tag.UserID == frmMain.User_ID && tag.ArtistID == frmMain.ArtistID
                            group tagInfos by tagInfos.tagValue into tagGroup
                            select new
                            {
                                tagValue = tagGroup.Key,
                                count = tagGroup.Count()
                            }

                            ).Distinct().OrderByDescending(x => x.count).Take(20);
                dgUserTags.DataSource = tags.ToList();
            }catch(Exception e)
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
            db.TAG_ARTIST(frmMain.User_ID, frmMain.ArtistID, input);
            } catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            this.RefreshUserControl();
        }

        private void userTagKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
                db.REMOVE_TAG(frmMain.User_ID, frmMain.ArtistID, dgUserTags.SelectedCells[0].Value.ToString());
                this.RefreshUserControl();
            }
        }

        private void ArtistHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(frmMain.BandURL);
        }

        private void btnArtistSearch_Click(object sender, EventArgs e)
        {
            frmMain.ArtistID = 0;
            Panel parentForm = (this.Parent as Panel);
            LastFMBrowser.Views.ucArtistSearch artistSearch = new ucArtistSearch();
            artistSearch.Dock = DockStyle.Fill;
            artistSearch.Show();
            parentForm.Controls.Add(artistSearch);
            artistSearch.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel parentForm = (this.Parent as Panel);
            LastFMBrowser.Views.ucTagSearch tagSearch = new ucTagSearch();
            tagSearch.Dock = DockStyle.Fill;
            tagSearch.Show();
            parentForm.Controls.Add(tagSearch);
            tagSearch.BringToFront();
        }

        private void dgTopTags_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            runTagSearch(dgTopTags.SelectedCells[0].Value.ToString());
        }
        private void runTagSearch(String tag)
        {
            Panel parentForm = (this.Parent as Panel);
            LastFMBrowser.Views.ucTagSearch tagSearch = new ucTagSearch(tag);
            tagSearch.Dock = DockStyle.Fill;
            tagSearch.Show();
            parentForm.Controls.Add(tagSearch);
            tagSearch.BringToFront();
        }

        private void dgUserTags_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            runTagSearch(dgUserTags.SelectedCells[0].Value.ToString());
        }
    }
}
