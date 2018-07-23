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
            LastFMBrowser.Models.LastFMDataEntities db = new LastFMBrowser.Models.LastFMDataEntities();

            var artists = (from artist in db.tblArtists
                          where artist.ArtistName.Contains(textBox1.Text)
                          select artist).Take(20);

            dataGridView1.DataSource = artists.ToList();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frmMain.ArtistID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            frmMain.ArtistName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            this.Hide();
            Panel parentForm = (this.Parent as Panel);
            LastFMBrowser.Views.ucArtistPage artistPage = new ucArtistPage();
            artistPage.Dock = DockStyle.Fill;
            artistPage.Show();
            parentForm.Controls.Add(artistPage);
            artistPage.BringToFront();
        }

        private void tb_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter) Check on performance
                artistSearch();
        }

        public void RefreshUserControl()
        {
            throw new NotImplementedException();
        }


    }
}
