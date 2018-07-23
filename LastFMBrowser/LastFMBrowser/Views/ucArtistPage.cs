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
            }
        }

        /// <summary>
        ///     Called by frmMain when user control is opened or needs to be refreshed
        /// </summary>
        public void RefreshUserControl()
        {
            throw new NotImplementedException();
        }
        private void dataGridView1_Load(long ArtistID)
        {
            if (ArtistID != 0)
            {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();

                var tracks = from track in db.tblTracks
                             where track.ArtistID == ArtistID
                             orderby track.PlayCount descending
                             select track;

                dataGridView1.DataSource = tracks.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String URL = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            System.Diagnostics.Process.Start(URL);
        }
        private void dataGridView2_Load(long ArtistID)
        {
            if (ArtistID != 0)
            {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();

                var tags = (from tag in db.lnkUserTagArtists
                            join tagInfo in db.tblTags on tag.TagID equals tagInfo.tagID
                            where tag.ArtistID == ArtistID
                            //group tagInfo.tagValue by tag.tagID  into tagGroup

                            select tagInfo).Distinct();


                dataGridView2.DataSource = tags.ToList();
            }
        }
        private void dataGridView3_Load(long ArtistID)
        {
            if (ArtistID != 0)
            {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
                dataGridView3.DataSource = db.GET_SIMILAR_ARTISTS(ArtistID);
            }
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
    }
}
