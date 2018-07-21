using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AppEmaMonitor.Tools
{
    public class ctrlDynamicMenuExpandable
    {

        public delegate void dynMenuExpItemSelectionEventHandler(object sender, EventArgs e);


        /*******************************
        * Constances
        *******************************/

        protected const int DEF_SPLITTER_DISTANCE = 30; //Where the panel splitter occurs
        protected const int DEF_BOX_SIZE_WIDTH = 161; // Desired width of the panel
        protected const int DEF_BOX_SIZE_HEIGHT = 65; //Desired start height of the panel
        protected const int DEF_CTRL_BUFFER = 4; //Buffer in between button controls

        //        public delegate void ucSelectGrantOnChangeEventHandler(object sender, EventArgs e);

        /*******************************
        * Member fields
        *******************************/
        int Width { get; set; }
        List<HeaderButton> MenuHeaders { get; set; }
        SplitContainer Container { get; set; }
        Panel MenuPanel { get; set; }
        MenuButton Selected { get; set; }
        HeaderButton SelectedHeader { get; set; }
        UserControl mParentCtrl { get; set; }

        int LastY { get; set; } //Tracks current height of form, updated as controls are added


        /*******************************
        * Constructor
        *******************************/
        public ctrlDynamicMenuExpandable(UserControl mParentCtrl, SplitContainer container)
        {
            InitClass(mParentCtrl, container);
            LoadMenuList();
            AddOnItemClickHandlers();
            RepaintMenu();
        }


        /*******************************
        * Adding delegates for other classes to listen to us
        *******************************/
        public event dynMenuExpItemSelectionEventHandler MenuItemSelected;

        public virtual void OnMenuItemSelected(EventArgs e)
        {
            //Console.WriteLine("MenuItemSelected run");
            if (MenuItemSelected != null)
            {
                MenuItemSelected(this, e);
            }

        }

        /*******************************
        * Adding handlers for delegates in other classes that we listen too
        *******************************/

        /// <summary>
        ///     Adds handlers based on delegates in associated classes
        /// </summary>
        private void AddOnItemClickHandlers()
        {
            foreach (HeaderButton hdr in MenuHeaders)
            {
                hdr.HeaderItemSelected +=
                        new FormButton.dynMenuExpMenuClickEventHandler(OnHeaderItemClicked);

                foreach (MenuButton item in hdr.GetButtons())
                {
                    item.FooterItemSelected +=
                        new FormButton.dynMenuExpMenuClickEventHandler(OnFooterItemClicked);
                }
            }
        }

        /// <summary>
        ///     Event handler in response to HeaderItemClicked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnHeaderItemClicked(object sender, EventArgs e)
        {
            Console.WriteLine("OnHeaderClicked Run - " + ((Button)sender).Name);
            SelectedHeader = (HeaderButton)sender;
            ResetHeaderMenus();
            RepaintMenu();
            //Should this be broadcasting an event of its own so the main menu knows to resize? Or is that linked
            //seperatly?
        }

        /// <summary>
        ///     Event handler in response to FootItemClicked event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFooterItemClicked(object sender, EventArgs e)
        {
            Console.WriteLine("OnFooterClicked Run - " + ((Button)sender).Name);
            Selected = (MenuButton)sender;
            ResetSubMenus();
            RepaintMenu();
            OnMenuItemSelected(new EventArgs());
            //I need a way for this to communicate to the containing form that an item has been selected

        }

        /*******************************
        * Helper Methods
        *******************************/

        /// <summary>
        ///     Initializes the class
        /// </summary>
        /// <param name="mParentCtrl"></param>
        /// <param name="container"></param>
        private void InitClass(UserControl mParentCtrl, SplitContainer container)
        {
            MenuHeaders = new List<HeaderButton>();
            this.mParentCtrl = mParentCtrl;
            this.Container = container;
            MenuPanel = Container.Panel2;
            this.Width = Container.Width;
            LastY = 0 + DEF_CTRL_BUFFER;
            MenuPanel.Margin = new Padding(0, 500, 0, 500);
        }

        /// <summary>
        ///     Initial load of the menu.  This was designed to be overhauled so that the list can be 
        ///     pulled in from a DB
        /// </summary>
        private void LoadMenuList()
        {

            ////Load items for menu 1
            //List<MenuButton> mItems1 = new List<MenuButton>();
            //mItems1.Add(new MenuButton("Dashboard", "frmEmaMonitor_Other"));
            //mItems1.Add(new MenuButton("Activity", "frmEmaMonitor_Other"));
            //Selected = new MenuButton("Call Logs", "frmEmaMonitor_Overview");
            //mItems1.Add(Selected);
            //mItems1.Add(new MenuButton("Verify Cxns", "frmEmaMonitor_Other"));
            //mItems1.Add(new MenuButton("User QC", "frmEmaMonitor_Other"));
            ////Create header for menu 1 with items
            //HeaderButton mMain1 = new HeaderButton("IVR QC", mItems1);
            //SelectedHeader = mMain1;
            //mMain1.setExpanded(true);
            //mMain1.setAsSelected(true);

            ////Load items for menu 2
            //List<MenuButton> mItems2 = new List<MenuButton>();
            //mItems2.Add(new MenuButton("QC Email", "frmEmaMonitor_Qrys"));
            ////Create header for menu 2 with items
            //HeaderButton mMain2 = new HeaderButton("Email QC", mItems2);
            //mMain2.setExpanded(false);

            ////Load items for menu 3
            //List<MenuButton> mItems3 = new List<MenuButton>();
            //mItems3.Add(new MenuButton("QC Manager", "frmEmaMonitor_Qrys"));
            ////Create header for menu 3 with items
            //HeaderButton mMain3 = new HeaderButton("Contact Mgr", mItems3);
            //mMain3.setExpanded(false);

            ////Load items for menu 3
            //List<MenuButton> mItems4 = new List<MenuButton>();
            //mItems4.Add(new MenuButton("Schedule", "frmEmaMonitor_Qrys", EnumEmaTableTypes.CALL_SCHEDULE ));
            //mItems4.Add(new MenuButton("Responses", "frmEmaMonitor_Qrys", EnumEmaTableTypes.CALL_RESPONSES));
            //mItems4.Add(new MenuButton("Logs", "frmEmaMonitor_Qrys", EnumEmaTableTypes.CALL_LOG));
            ////Create header for menu 3 with items
            //HeaderButton mMain4 = new HeaderButton("Tables", mItems4);
            //mMain4.setExpanded(false);

            


            //MenuHeaders.Add(mMain1);
            //MenuHeaders.Add(mMain2);
            //MenuHeaders.Add(mMain3);
            //MenuHeaders.Add(mMain4);
        }

        /// <summary>
        ///     Clears the menu, IDs all headers, adds them back in
        ///     NOTE: The headers contain the menu items, and as the headers are added back in, so are the menu items
        ///     //TODO: Consider changing the other items to visible = false instead of reloading controls every time
        /// </summary>
        public void RepaintMenu()
        {
            ClearMenu();
            ResetFormDim();
            LastY = 0;
            Console.WriteLine("REPAINT MENU");
            foreach (HeaderButton menuList in MenuHeaders)
            {
                AddHeader(menuList);
            }

            ResetSubMenus();
        }

        public String getSelectedSubFormName()
        {
            return Selected.ucSubMenuName;
        }

        //public EnumEmaTableTypes getSelectedSubQryParams()
        //{
        //    Console.WriteLine("Selecting subqry param " + Selected.ucSubQry + " from " + Selected.ItemName);
        //    return Selected.ucSubQry;
        //}

        public String GetSelectedBtnText()
        {
            return Selected.ItemName;
        }

        public String GetSelectedHeaderText()
        {
            return SelectedHeader.HeaderName;
        }

        /// <summary>
        ///     Removes all controls from the menu
        /// </summary>
        private void ClearMenu()
        {
            MenuPanel.Controls.Clear();
        }

        /// <summary>
        ///     Adds each header back to the menu and adds footers via depth first
        /// </summary>
        /// <param name="menuList"></param>
        private void AddHeader(HeaderButton menuList)
        {
            AddControl(menuList);
            if (menuList.isExpanded)
            {
                foreach (MenuButton btn in menuList.GetButtons())
                {
                    //Console.WriteLine("Adding menut item " + btn.ItemName);
                    AddControl(btn);
                }
            }

        }

        /// <summary>
        ///     Actually adds the control to the form
        ///     Manipulates the space between buttons and keeps splitter in correct spot
        /// </summary>
        /// <param name="btn"></param>

        private void AddControl(FormButton btn)
        {
            //Console.WriteLine("Adding Control : " + btn.Name);
            btn.Width = Width;
            btn.Location = new Point(0, LastY);
            LastY += btn.Height + DEF_CTRL_BUFFER;
            //expand containers as well
            mParentCtrl.Height += btn.Height + DEF_CTRL_BUFFER;
            Container.Height += btn.Height + DEF_CTRL_BUFFER;
            Container.SplitterDistance = DEF_SPLITTER_DISTANCE; //sliding, it moves when you increase the heigh, but we don't want it to so I just reset it back
            //Console.WriteLine("mParentCtrl.Height = " + mParentCtrl.Height);
            //Console.WriteLine("MenuPanel.Height = " + MenuPanel.Height);
            //Console.WriteLine("Button name, loc = " + btn.Name + ", " + btn.Location.ToString());
            MenuPanel.Controls.Add(btn);

        }

        /// <summary>
        ///     Resets form back to 'default' dimmensions
        /// </summary>
        private void ResetFormDim()
        {
            Container.Width = DEF_BOX_SIZE_WIDTH;
            Container.Height = DEF_BOX_SIZE_HEIGHT;
            mParentCtrl.Height = DEF_BOX_SIZE_HEIGHT;
            Container.SplitterDistance = DEF_SPLITTER_DISTANCE;
        }


        /// <summary>
        ///     Goes through all buttons, and for all menu items sets selected to false unless it is = Selected (set everytime a new item is selected)
        ///     Does not refresh, but does impact button rendering
        /// </summary>
        private void ResetSubMenus()
        {

            foreach (HeaderButton hdr in MenuHeaders)
            {
                foreach (MenuButton btn in hdr.GetButtons())
                {
                    if (btn == Selected)
                    {
                        btn.SetMenuButonState(true);
                    }
                    else
                    {
                        btn.SetMenuButonState(false);
                    }
                }
            }
        }

        private void ResetHeaderMenus()
        {
            foreach (HeaderButton hdr in MenuHeaders)
            {
                if (hdr == SelectedHeader)
                {
                    hdr.setExpanded(true);
                    //hdr.setAsSelected(true);
                }
                else
                {
                    hdr.setExpanded(false);
                    //hdr.setAsSelected(false);
                }

                //foreach (MenuButton btn in hdr.GetButtons())
                //{
                //    if (btn == Selected)
                //    {
                //        btn.SetMenuButonState(true);
                //    }
                //    else
                //    {
                //        btn.SetMenuButonState(false);
                //    }
                //}
            }
        }


        //Returns the text on the button that is currently selected
        public String getSelectedText()
        {
            return Selected.Text;
        }


    }


    /*#######################################
    # Class FormButton
    #######################################*/

    /// <summary>
    ///     Parent class to other two buttons, helps deal with events
    /// </summary>
    class FormButton : Button
    {
        public delegate void dynMenuExpMenuClickEventHandler(object sender, EventArgs e);

        protected void setXY(int x, int y)
        {
            this.Width = x;
            this.Height = y;
        }

        public event dynMenuExpMenuClickEventHandler HeaderItemSelected;
        public event dynMenuExpMenuClickEventHandler FooterItemSelected;

        public virtual void OnHeaderItemSelected(EventArgs e)
        {
            Console.WriteLine("OnMenutItemChanged run");
            if (HeaderItemSelected != null)
            {
                HeaderItemSelected(this, e);
            }

        }

        public virtual void OnMenuItemSelected(EventArgs e)
        {
            Console.WriteLine("OnMenutItemChanged run");
            if (FooterItemSelected != null)
            {
                FooterItemSelected(this, e);
            }

        }
    }

    /*#######################################
    # Class HeaderButton
    #######################################*/

    /// <summary>
    ///     Represents a menu category, not a menu item.  Can collapse to hid its own menut items (it has a list of)
    /// </summary>
    class HeaderButton : FormButton
    {
        public List<MenuButton> subMenus;
        public String HeaderName { get; set; }
        public bool isExpanded;
        public bool ContainsSelected { get; set; }

        public HeaderButton() : this("empty", new List<MenuButton>()) { }
        public HeaderButton(String headerName, List<MenuButton> subMenus)
        {
            this.HeaderName = headerName;
            this.Name = "ctrl" + headerName;
            SetHeaderText();
            this.subMenus = subMenus;
            SetDefaultDesign();
            Height = 35;
            //this.Margin = new Padding(0, 500, 0, 500);
            


            this.Click += new System.EventHandler(HeaderButtonOnClickEvent);
            ContainsSelected = false;
        }

        private void SetDefaultDesign()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;


            //this.BackColor = Color.DarkKhaki;// A little too green, going to try some other options
            //this.BackColor = Color.FromArgb(255,249, 211, 121);
            this.BackColor = Color.FromArgb(255, 231, 200, 95);
            
            this.ForeColor = Color.DarkRed;

            this.Font = new Font(this.Font.Name, 12, FontStyle.Bold);
            TextAlign = ContentAlignment.MiddleLeft;
            this.Text = " + " + HeaderName;

            FlatAppearance.MouseOverBackColor = Color.LemonChiffon;
        }

        private void SetSelectedDesign()
        {
            this.FlatStyle = FlatStyle.Flat;
            
                        
            this.Text = " - " + HeaderName;
            //FlatAppearance.MouseOverBackColor = Color.DimGray;
        }

        private void HeaderButtonOnClickEvent(object sender, EventArgs e)
        {
            HeaderButton tempHdr = (HeaderButton)sender;
            tempHdr.isExpanded = !tempHdr.isExpanded;
            SetHeaderText();
            OnHeaderItemSelected(new EventArgs());


            //Need to refresh the menu itself probably with delegate event combo
        }

        private void SetHeaderText()
        {
            setDisplay();
        }

        public List<MenuButton> GetButtons()
        {
            return subMenus;
        }



        public void setExpanded(bool b)
        {
            isExpanded = b;
            SetHeaderText();
        }

        public void setAsSelected(bool b)
        {
            //Console.WriteLine("VVVVVVVVVVVVVVVVVVVVVV - setting " + this.HeaderName + " to containesSelected = " + b);
            ContainsSelected = b;
            SetHeaderText();
        }

        private void setDisplay()
        {
            //Console.WriteLine("Adding Header " + HeaderName);
            if (isExpanded)
            {
                SetSelectedDesign();
            }
            else
            {
                SetDefaultDesign();
            }
        }



    }


    /*#######################################
    # Class MenuButton
    #######################################*/

    /// <summary>
    ///     Represents a selectable menut item
    /// </summary>
    class MenuButton : FormButton
    {
        public String ItemName { get; set; }
        public String ucSubMenuName { get; set; }
        //public EnumEmaTableTypes ucSubQry { get; set; }
        public bool Checked { get; set; }


        public MenuButton(String itemName, String ucSubMenuName)
        {
            this.Name = "ctrl" + itemName;
            this.Text = itemName;
            this.ItemName = itemName;
            this.ucSubMenuName = ucSubMenuName;
          

            /******************
             * Design
             ******************/
            
            FlatAppearance.BorderSize = 0;
            SetDefaultDesign();
            
            //Physical properties
            this.Height = 30;
            Margin = new Padding(0, 500, 0, 500);
            Checked = false;
            //Add event handler
            this.Click += new System.EventHandler(MenuButtonOnClickEvent);
        }

        
        private void MenuButtonOnClickEvent(object sender, EventArgs e)
        {
            SetMenuButonState(true);
            OnMenuItemSelected(new EventArgs());
        }

        private MenuButton(bool b)
        {
            Checked = b;

        }

        public void SetMenuButonState(bool b)
        {
            Checked = b;
            if (Checked)
            {
                /******************
                 * Selected
                 ******************/
                SetSelectedDesign();
            }
            else
            {
                /******************
                 * Not Selected
                 ******************/
                SetDefaultDesign();
            }
        }

        private void SetDefaultDesign()
        {
            FlatStyle = FlatStyle.Flat;
            this.BackColor = Color.Transparent;
            this.ForeColor = Color.White;
            TextAlign = ContentAlignment.MiddleRight;
            //FlatAppearance.MouseOverBackColor = Color.Goldenrod;
            FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 242, 205, 160);
            Font = new Font(this.Font, FontStyle.Regular);
        }

        private void SetSelectedDesign()
        {
            //BackColor = Color.FromArgb(255, 186, 169, 82);
            BackColor = Color.FromArgb(255, 135, 138, 160);
            ForeColor = Color.LightGoldenrodYellow;
            Font = new Font(this.Font, FontStyle.Bold);
            FlatAppearance.MouseOverBackColor = Color.Peru;
        }

       


    }
}
