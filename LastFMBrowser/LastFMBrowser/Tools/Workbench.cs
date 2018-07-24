using AppEmaMonitor.Tools;
using LastFMBrowser.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LastFMBrowser.Tools
{
    public partial class Workbench : Form
    {
        public Workbench()
        {
            InitializeComponent();
        }

        private void Workbench_Load(object sender, EventArgs e)
        {
            //panel1.Controls.Add(new uctrlTop5ArtistChart());
        }

        public int? GetActiveUser()
        {
            return 89; //User 89 very active in tagging artists, verified active in all user queries with the foloowing
                       /*SELECT TOP 1 UserID, COUNT(UserID) AS countUserID FROM lnkUserArtist 
                           WHERE UserID IN (SELECT UserID FROM lnkUserTagArtist) 
                           AND UserID IN (SELECT UserID FROM lnkUserTagArtist) 
                           GROUP BY UserID ORDER BY COUNT(UserID) DESC ;*/
        }
    }
}
