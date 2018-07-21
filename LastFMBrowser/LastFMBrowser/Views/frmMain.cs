﻿
using LastFMBrowser.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LastFMBrowser.Views
{
    public partial class frmMain : Form
    {
        /********************************
         * Class Fields & Properties
        ********************************/
       
        //Properties
        String CurrentSubForm { get; set; }

        /********************************
         * Form initialization
        ********************************/

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ClearPageFooter();
            LoadSubForm();
            
        }

        /********************************
         * Public interface
        ********************************/

        public void SetPageTitle(String newSubTitle, Boolean optIncMainTitle = true)
        {
            String newTitle = "  ";
            if (optIncMainTitle) newTitle = CurrentSubForm;
            if (newSubTitle != null && newSubTitle != "" && optIncMainTitle) newTitle += " - ";
            newTitle += newSubTitle;
            lblTitle.Text = newTitle;
        }

        public void SetPageFooter(String newFooter)
        {
            lblFooter.Text = newFooter;
        }

        public void ClearPageFooter()
        {
            SetPageFooter(". . .");
        }

        /********************************
         * Private helper Functions
        ********************************/

        /// <summary>
        ///     Load default form
        /// </summary>
        private void LoadSubForm()
        {
            LoadDashboard();
        }

        /// <summary>
        ///     Load Dashboard subform showing user interests
        /// </summary>
        public void LoadDashboard()
        {
            ISwapPanelSubForm ctrl = new ucDashboard();
            SetSubForm(ctrl, btnDashboard);
        }

        /// <summary>
        ///     Load artist specific information
        /// </summary>
        public void LoadArtistPage()
        {
            ISwapPanelSubForm ctrl = new ucArtistPage();
            SetSubForm(ctrl, btnArtist);
        }


        public void LoadProfilePage()
        {
            ISwapPanelSubForm ctrl = new ucEditProfile();
            SetSubForm(ctrl, btnEditProfile);
        }
        


        /// <summary>
        ///     Actually handles the subform swap
        /// </summary>
        /// <param name="mSubForm"> The sub form you want to load into the SwapPanel </param>
        private void SetSubForm(ISwapPanelSubForm mSubForm, Button optSender = null)
        {
            Console.WriteLine("Setting the sub form");
            if (SwapPanel.Controls.Count > 0)
            {
                //Selection already set
                if (SwapPanel.Controls[0] == mSubForm)
                {
                    Console.WriteLine("Selection already set");
                    return;
                }

                //Clear existing control
                SwapPanel.Controls.Clear();
            }

            //track current button text because it serves as the main title
            if (optSender != null)
            {
                CurrentSubForm = optSender.Text;
                SetBtnSelection(optSender);
            }
            SetPageTitle("");

            //Set anchor so sub form can shrink and grow
            ((UserControl)mSubForm).Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            SwapPanel.Controls.Add((Control)mSubForm);
        }

        /// <summary>
        ///     Adds border to button that is selected
        /// </summary>
        /// <param name="Sender"></param>
        private void SetBtnSelection(Button Sender)
        {
            foreach (Control ctrl in NavPanel.Controls)
            {
                if (ctrl.GetType() == typeof(Button))
                    SetButtonSelectedState((Button) ctrl, ctrl == Sender);
            }
        }

        private void SetButtonSelectedState(Button ctrl, Boolean State)
        {
            if (State) ctrl.FlatAppearance.BorderSize = 3;
            else ctrl.FlatAppearance.BorderSize = 0;

        }

        private void SetButtonUnselected()
        {

        }
        /********************************
         * Form Driven Events
        ********************************/

        /*-----------------
         * Menu Options 
         *---------------*/
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashboard();
        }

        private void btnArtist_Click(object sender, EventArgs e)
        {
            LoadArtistPage();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            LoadProfilePage();
        }
    }
}
