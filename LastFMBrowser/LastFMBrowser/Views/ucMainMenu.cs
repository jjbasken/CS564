using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LastFMBrowser.Tools;

namespace AppEmaMonitor.Tools
{

    public delegate void dynMenuExpMenuSelectionEventHandler(object sender, EventArgs e); //Resize for if selection and not sticky


    public partial class ucMainMenu : UserControl
    {

        /*******************************
        * Globals 
        *******************************/
        static ctrlDynamicMenuExpandable mMenu;

        Point Panel_1_Size { get; set; }
        Point Panel_2_Size { get; set; }

        /*******************************
        * Constructors 
        *******************************/

        public ucMainMenu(bool b)
        {
            InitializeComponent();
            mMenu = new ctrlDynamicMenuExpandable(this, this.splitMenu);
            InitHandlers();
            SetPanelSizes();
            SetSizeMax(b);
        }


        /*******************************
        * Internal communication (Events\Delgates) - Receiving communication  from ctrlDynamicMenuExpandable
        *******************************/

        public void InitHandlers()
        {
            mMenu.MenuItemSelected +=
                      new ctrlDynamicMenuExpandable.dynMenuExpItemSelectionEventHandler(OnItemSelected);
            
        }

        /// <summary>
        ///     Event response for item selected from sub menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnItemSelected(object sender, EventArgs e)
        {
            Console.WriteLine("OnItemSelected");
            OnUpdateItemSelected(new EventArgs());
        }

        /*******************************
        * External communication (Events\Delgates) - sending out to fxns using this class indicating the menu was resized
        *******************************/

        public event dynMenuExpMenuSelectionEventHandler MenuStateResized;


        //Menu has been resized
        public virtual void OnMenuStateResized(EventArgs e)
        {

            Console.WriteLine("MenuStateResized run");
            if (MenuStateResized != null)
            {
                MenuStateResized(this, e);
            }

        }

        //Item has been selected
        public event dynMenuExpMenuSelectionEventHandler UpdateItemSelected; 
        public virtual void OnUpdateItemSelected(EventArgs e)
        {
            Console.WriteLine("Item Selected run");
            if (UpdateItemSelected != null)
            {
                UpdateItemSelected(this, e);
            }

        }


        /*******************************
        * Helper functions 
        *******************************/
        public void SetSizeMax(bool b)
        {
            splitMenu.Panel2Collapsed = !b;
            splitMenu.Panel1Collapsed = b;
        }

        public string getUCName(){ return mMenu.getSelectedSubFormName();}
        public string GetSelectedButtonText() { return mMenu.GetSelectedBtnText();}

        public void ClearMenuSelection()
        {
            mMenu.ClearSelected();
        }
        /// <summary>
        ///     Sets initial pannel size at class instantiation to help figure out current size in action
        /// </summary>
        public void SetPanelSizes()
        {
            splitMenu.Panel1Collapsed = false;
            splitMenu.Panel2Collapsed = false;
            this.Panel_1_Size = new Point(splitMenu.Panel1.Width, splitMenu.Panel1.Height);
            this.Panel_2_Size = new Point(splitMenu.Panel2.Width, splitMenu.Panel2.Height);
        }

        /*******************************
        * Form events 
        *******************************/

        private void btnUCMax_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnUCMax_Click");
            SetSizeMax(true);
            OnMenuStateResized(new EventArgs());
        }

        private void btnUCMin_Click(object sender, EventArgs e)
        {
            Console.WriteLine("btnUCMax_Click");
            SetSizeMax(false);
            OnMenuStateResized(new EventArgs());
        }
    }
}
