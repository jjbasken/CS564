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
    public partial class ucTagSearch : UserControl, ISwapPanelSubForm
    {
        public ucTagSearch()
        {
            InitializeComponent();
        }
        public ucTagSearch(String tag)
        {
            InitializeComponent();
            tagSearch(tag);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tagSearch();
        }

        private void tagSearch()
        {
            try
            {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
                dgArtists.DataSource = db.FIND_ARTISTS_WITH_TAG(txtSearchField.Text);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void tagSearch(String tag)
        {
            try
            {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
                dgArtists.DataSource = db.FIND_ARTISTS_WITH_TAG(tag);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                frmMain.ArtistID = Convert.ToInt32(dgArtists.Rows[e.RowIndex].Cells[0].Value.ToString());
                frmMain.ArtistName = dgArtists.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmMain.BandURL = dgArtists.Rows[e.RowIndex].Cells[2].Value.ToString();
                this.Hide();
                Panel parentForm = (this.Parent as Panel);
                LastFMBrowser.Views.ucArtistPage artistPage = new ucArtistPage();
                artistPage.Dock = DockStyle.Fill;
                artistPage.Show();
                parentForm.Controls.Add(artistPage);
                artistPage.BringToFront();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
                tagSearch();
        }

        public void RefreshUserControl()
        {
            throw new NotImplementedException();
        }


    }
}
