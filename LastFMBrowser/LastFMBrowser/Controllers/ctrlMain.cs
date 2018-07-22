using LastFMBrowser.Views;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LastFMBrowser.Controllers
{
    class ctrlMain
    {
        [STAThread]
        public static void Main(String[] args)
        {
            Application.Run(new frmMain());
            //Application.Run(new Tools.Workbench());
        }
    }
}
