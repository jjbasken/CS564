using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        bool KeepSticky { get; set; } //If true do not collapse the menu

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
            KeepSticky = false;
        }



        /*******************************
        * Internal communication (Events\Delgates) - Receiving communication 
        *******************************/
        public void InitHandlers()
        {
            mMenu.MenuItemSelected +=
                      new ctrlDynamicMenuExpandable.dynMenuExpItemSelectionEventHandler(OnItemSelected);
            
        }

        public void OnItemSelected(object sender, EventArgs e)
        {
            Console.WriteLine("OnItemSelected");
            SetSizeMax(false);
            OnMenuStateResized(new EventArgs()); //Call OnMenuStateResized
            OnUpdateItemSelected(new EventArgs());
        }

        /*******************************
        * External communication (Events\Delgates) - sending out to fxns using this class indicating the menu was resized
        *******************************/

        public event dynMenuExpMenuSelectionEventHandler MenuStateResized;


        //Menu has been resized
        public virtual void OnMenuStateResized(EventArgs e)
        {

            if (KeepSticky) return;
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
            b = (KeepSticky || b);//if attempting to set small but keepsticky is true then no change
            splitMenu.Panel2Collapsed = !b;
            if (splitMenu.Panel2Collapsed)
            {
                btnUCMax.Text = "V";
                lblUCStatus.Text = mMenu.getSelectedText();

                lblUCStatus.BorderStyle = BorderStyle.Fixed3D;
                //lblUCStatus.BackColor = Color.PaleGoldenrod;
                //lblUCStatus.BackColor = Color.FromArgb(255, 186, 169, 82);
                lblUCStatus.BackColor = Color.FromArgb(255, 135, 138, 160);
                
                //lblUCStatus.BackColor = Color.Lavender;
                lblUCStatus.ForeColor = Color.LightGoldenrodYellow;
            }
            else
            {
                btnUCMax.Text = "^";
                lblUCStatus.Text = mMenu.getSelectedText();
                //lblUCStatus.ForeColor = Color.LightYellow;
            }
            if (KeepSticky)
            {
                btnUCMax.BackColor = Color.DarkRed;
            } else
            {
                btnUCMax.BackColor = Color.Transparent;
            }
        }

        public string getUCName()
        {
            return mMenu.getSelectedSubFormName();
        }

        //public EnumEmaTableTypes getUCSubQry()
        //{
        //    return mMenu.getSelectedSubQryParams();
        //}

        public String GetHeaderText()
        {
            return mMenu.GetSelectedHeaderText();
        }

        public string GetSelectedButtonText()
        {
            return mMenu.GetSelectedBtnText();
        }
        public Point CurrentSize()
        {

           // Console.WriteLine("***** Returning size (" + Panel_1_Size + ", or " + Panel_2_Size + ")");
            return (splitMenu.Panel2Collapsed)
                ? Panel_1_Size
                : (new Point(Panel_1_Size.X + Panel_2_Size.X,
                             Panel_1_Size.Y + Panel_2_Size.Y));
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
            //It seems like the OnMenuStateResized may be forcing reloads, but I am not totally sure why
            //
            Console.WriteLine("btnUCMax_Click");
            SetSizeMax(splitMenu.Panel2Collapsed);
            OnMenuStateResized(new EventArgs());
        }

        private void lblUCStatus_DoubleClick(object sender, EventArgs e)
        {
            KeepSticky = !KeepSticky;

            SetSizeMax(KeepSticky); //? or some other forced refresh
            OnMenuStateResized(new EventArgs());
        }
    }
}
