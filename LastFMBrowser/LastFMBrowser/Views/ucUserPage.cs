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
    public partial class ucUserPage : UserControl, ISwapPanelSubForm
    {
        public ucUserPage()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Called by frmMain when user control is opened or needs to be refreshed
        /// </summary>
        public void RefreshUserControl()
        {
            throw new NotImplementedException();
        }
    }
}
