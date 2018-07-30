
using AppEmaMonitor.Tools;
using LastFMBrowser.Interfaces;
using LastFMBrowser.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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

        //Controles we are adding to the control pannel
        public static ucMainMenu mMenu;
        
        //Properties
        public static long ArtistID = 0;
        public static String ArtistName = "";
        public static String BandURL = "";
        public static String BandPictureURL = "";
        public static long User_ID = 1;

        /********************************
         * Form initialization
        ********************************/

        public frmMain()
        {
            InitializeComponent();
            mMenu = new ucMainMenu(true);
            Set_DynMenu_Handler();
            NavPanel.Controls.Add(mMenu);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ClearPageFooter();
            LoadActiveSubForm();
            SetFooterDate();
        }

        private void SetFooterDate()
        {
            lblFooterDate.Text = "Launched " +  DateTime.Now.ToString("MMM-dd @ h:mm:ss tt", new CultureInfo("en-US")) + "  ";
        }

        /********************************
         * Listen to events
        ********************************/

        /*-----------------------------------
         *  Sign up for events from the form
         *-----------------------------------*/
        private void Set_DynMenu_Handler()
            { mMenu.UpdateItemSelected += new dynMenuExpMenuSelectionEventHandler(OnMenuSubSelected);}


        /*-----------------------------------
         *  Handel Events
         *-----------------------------------*/

        protected virtual void OnMenuSubSelected(object sender, EventArgs e)
        {
            LoadActiveSubForm();
        }

        private void LoadActiveSubForm()
        {
            string subFormName = mMenu.getUCName(); // Full namespace name
            UserControl mNewSub = (UserControl)Activator.CreateInstance(Type.GetType("LastFMBrowser.Views." + subFormName));
            SetSubForm((ISwapPanelSubForm)mNewSub);
        }

        /********************************
         * Public interface
        ********************************/

        public void ChangeSubForm(ISwapPanelSubForm newSubForm)
        {
            mMenu.ClearMenuSelection(); //Clear the active menu selection
            SetSubForm(newSubForm);
        }
        public void SetPageTitle(String newSubTitle, Boolean optIncMainTitle = true)
        {
            String newTitle = "  ";
            if (optIncMainTitle) newTitle = mMenu.GetSelectedButtonText();
            if (newSubTitle != null && newSubTitle != "" && optIncMainTitle) newTitle += " - ";
            newTitle += newSubTitle;
            lblTitle.Text = newTitle;
        }

        public int? GetActiveUser()
        {
            return 89; //User 89 very active in tagging artists, verified active in all user queries with the folowing
                       /*SELECT TOP 1 UserID, COUNT(UserID) AS countUserID FROM lnkUserArtist 
                           WHERE UserID IN (SELECT UserID FROM lnkUserTagArtist) 
                           AND UserID IN (SELECT UserID FROM lnkUserTagArtist) 
                           GROUP BY UserID ORDER BY COUNT(UserID) DESC ;*/
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
            //LoadDashboard();
        }


        /// <summary>
        ///     Actually handles the subform swap
        /// </summary>
        /// <param name="mSubForm"> The sub form you want to load into the SwapPanel </param>
        private void SetSubForm(ISwapPanelSubForm mSubForm)
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

            SetPageTitle("");

            //Set anchor so sub form can shrink and grow
            ((UserControl)mSubForm).Anchor = (AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top);
            SwapPanel.Controls.Add((Control)mSubForm);
        }




        /********************************
         * Form Driven Events
        ********************************/

        private void btnUCMin_Click(object sender, EventArgs e)
        {
            Boolean state = !splitMain.Panel1Collapsed;
            splitMain.Panel1Collapsed = state;
            if (state)
                btnUCMin.Text = ">";
            else
                btnUCMin.Text = "<";

        }
    }
}
