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
                dataGridView1_Load(frmMain.ArtistID);
                dataGridView2_Load(frmMain.ArtistID);
                dataGridView3_Load(frmMain.ArtistID);
                dataGridView4_Load(frmMain.ArtistID);
                OtherUserGrid_Load(frmMain.ArtistID, frmMain.User_ID);
                ArtistHeader.Text = frmMain.ArtistName;
            }

        }

        private void OtherUserGrid_Load(long artistID, long user_ID)
        {
            LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
            OtherUserGrid.DataSource = db.FIND_ARTIST_LISTENERS(user_ID, artistID);
        }

        /// <summary>
        ///     Called by frmMain when user control is opened or needs to be refreshed
        /// </summary>
        public void RefreshUserControl()
        {
            dataGridView4_Load(frmMain.ArtistID);
        }
        private void dataGridView1_Load(long ArtistID)
        {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();

                var tracks = from track in db.tblTracks
                             where track.ArtistID == ArtistID
                             orderby track.PlayCount descending
                             select track;

                dataGridView1.DataSource = tracks.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String URL = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            System.Diagnostics.Process.Start(URL);
        }
        private void dataGridView2_Load(long ArtistID)
        {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();

                var tags = (from tag in db.lnkUserTagArtists
                            join tagInfo in db.tblTags on tag.TagID equals tagInfo.tagID
                            where tag.ArtistID == ArtistID
                            //group tagInfo.tagValue by tag.tagID  into tagGroup

                            select tagInfo).Distinct().Take(20);


                dataGridView2.DataSource = tags.ToList();
        }
        private void dataGridView3_Load(long ArtistID)
        {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
                dataGridView3.DataSource = db.GET_SIMILAR_ARTISTS(ArtistID);
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMain.ArtistID = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells[0].Value.ToString());
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
        private void dataGridView4_Load(long ArtistID)
        {
            LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();

            var tags = (from tag in db.lnkUserTagArtists
                        join tagInfos in db.tblTags on tag.TagID equals tagInfos.tagID
                        where tag.UserID == frmMain.User_ID && tag.ArtistID==frmMain.ArtistID
                        group tagInfos by tagInfos.tagValue  into tagGroup
                        select new
                        {
                            tagValue=tagGroup.Key,
                            count = tagGroup.Count()
                        }
                        
                        ).Distinct().OrderByDescending(x => x.count).Take(20);


            dataGridView4.DataSource = tags.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter tag", "Add a tag", "", -1, -1);
            LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
            db.TAG_ARTIST(frmMain.User_ID, frmMain.ArtistID, input);
            this.RefreshUserControl();
        }

        private void userTagKeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete)
            {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
                db.REMOVE_TAG(frmMain.User_ID, frmMain.ArtistID, dataGridView4.SelectedCells[0].Value.ToString());
                this.RefreshUserControl();
            }
        }

        private void ArtistHeader_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(frmMain.BandURL);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain.ArtistID = 0;
            Panel parentForm = (this.Parent as Panel);
            LastFMBrowser.Views.ucArtistSearch artistSearch = new ucArtistSearch();
            artistSearch.Dock = DockStyle.Fill;
            artistSearch.Show();
            parentForm.Controls.Add(artistSearch);
            artistSearch.BringToFront();
        }
    }
}
