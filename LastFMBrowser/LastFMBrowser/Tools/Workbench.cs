﻿using AppEmaMonitor.Tools;
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
            panel1.Controls.Add(new ucMainMenu(false));
        }
    }
}
