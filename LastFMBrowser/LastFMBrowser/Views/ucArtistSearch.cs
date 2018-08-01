﻿using System;
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
    public partial class ucArtistSearch : UserControl, ISwapPanelSubForm
    {
        //Parent form
        private frmMain mParent { get; set; }
        public ucArtistSearch()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            artistSearch();
        }

        private void artistSearch()
        {
            try
            {
                LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();
                dataGridView1.DataSource = db.ARTIST_SEARCH(textBox1.Text);
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
                frmMain.ArtistID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                frmMain.ArtistName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frmMain.BandURL = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            }catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            mParent = (this.ParentForm as frmMain);
            LastFMBrowser.Views.ucArtistPage artistPage = new ucArtistPage();
            mParent.ChangeSubForm(artistPage);
         }

        private void tb_KeyUp(object sender, KeyEventArgs e)
        {
                 artistSearch();
        }

        public void RefreshUserControl()
        {
            throw new NotImplementedException();
        }

    }
}
