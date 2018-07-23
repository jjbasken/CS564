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
         * Constructor
        ********************************/

        private uctrlTop5ArtistChart TopFivePie { get; set; }
        public ucDashboard()
        {
            InitializeComponent();
            InitUC();
        }

        /********************************
         * Form Initialization
        ********************************/
        private void InitUC()
        {
            LoadTopFivePie();
        }

        private void LoadTopFivePie()
        {
            TopFivePie = new uctrlTop5ArtistChart(getTopFiveSQL());
            panelMyTopFivePie.Controls.Add(TopFivePie);
        }

        private List<Tuple<string, int?>> getTopFiveSQL()
        {
            string mSQL;
            mSQL = "SELECT TOP 5 A.ArtistName, [Count],  UserID " +
                   "FROM lnkUserArtist AS L " +
                   "INNER JOIN tblArtist AS A " +
                   "ON A.ArtistID = L.ArtistID " +
                   "WHERE UserID = 81 " +
                   "ORDER BY [Count] DESC";

            return GetQryList(mSQL);
        }


        class QryResultNode{

            public string ArtistName { get; set; }
            public int? Count { get; set; }
    }


        public List<Tuple<string, int?>> GetQryList(string QrySQL)
        {

            List<Tuple<string, int?>> mReturn = new List<Tuple<string, int?>>();

            LastFMDataEntities context = new LastFMDataEntities();

            var results = context.Database.SqlQuery<QryResultNode>(QrySQL);

            //mReturn = results.ToList<Tuple<string, int?>>();

            

            foreach (var result in results)
            {
                Console.WriteLine("Adding [" + result.ArtistName + "," + result.Count + "]");
                mReturn.Add(new Tuple<string, int?>(result.ArtistName , result.Count));
            }
            return mReturn;
        }


        /// <summary>
        ///     Called by frmMain when user control is opened or needs to be refreshed
        /// </summary>
        public void RefreshUserControl()
        {
            throw new NotImplementedException();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
