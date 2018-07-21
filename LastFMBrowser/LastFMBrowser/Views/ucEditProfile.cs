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
    public partial class ucEditProfile : UserControl, ISwapPanelSubForm
    {
        public ucEditProfile()
        {
            InitializeComponent();
        }

        public void RefreshUserControl()
        {
            throw new NotImplementedException();
        }
    }
}
