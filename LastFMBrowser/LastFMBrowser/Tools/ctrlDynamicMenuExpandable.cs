using LastFMBrowser.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using LastFMBrowser.Views;

namespace LastFMBrowser.Tools
{
    public class ctrlDynamicMenuExpandable
    {

        public delegate void dynMenuExpItemSelectionEventHandler(object sender, EventArgs e);

        //public const string QRY_05_TOP_FIVE_ARTISTS = "SELECT * FROM sysMenuList ORDER BY rank;";
        /*******************************
        * Constances
        *******************************/
        protected const int DEF_CTRL_BUFFER = 4; //Buffer in between button controls
        protected const int DEF_SPLITTER_DISTANCE = 20;
        protected const int DEF_PANEL_SIZE_WIDTH = 195; // Desired width of the full panel (not necessaraly 
                                                        // same as width of container
        protected const int DEF_CONTAINER_SIZE_WIDTH = 195;
        protected const int DEF_BOX_SIZE_HEIGHT = 33; //Desired start height of the panel

        /*******************************
        * Member fields
        *******************************/
        int Width { get; set; }
        SplitContainer Container { get; set; } //Reference to the spliter panel sent into the control
        Panel MenuPanel { get; set; } //Right panel where the menu itself is
        MenuButton Selected { get; set; } //Selected menu button
        UserControl mParentCtrl { get; set; } //The control I am loaded in
        List<MenuButton> MenuList { get; set; } //List containing the menu buttons

        int LastY { get; set; } //Tracks current height of form, updated as controls are added


        /*******************************
        * Constructor
        *******************************/
        public ctrlDynamicMenuExpandable(UserControl mParentCtrl, SplitContainer container, Panel optPanelControl = null)
        {
            InitClass(mParentCtrl, container, optPanelControl);
            LoadMenuList();
            AddOnItemClickHandlers();
            RepaintMenu();
        }

        /*******************************
        * Class Initialization
        *******************************/

        /// <summary>
        ///     Initializes the class
        /// </summary>
        /// <param name="mParentCtrl"></param>
        /// <param name="container"></param>
        private void InitClass(UserControl mParentCtrl, SplitContainer container, Panel optPanel = null)
        {
            this.mParentCtrl = mParentCtrl;
            this.Container = container;
            if (optPanel == null) MenuPanel = Container.Panel2;
            else MenuPanel = optPanel;
            this.Width = Container.Width;
            LastY = 0 + DEF_CTRL_BUFFER;
        }

        /// <summary>
        ///     Initial load of the menu.  This was designed to be overhauled so that the list can be 
        ///     pulled in from a DB
        /// </summary>
        private void LoadMenuList()
        {
            MenuList = new List<MenuButton>();

            LastFMDataEntities context = new LastFMDataEntities();
            //Northwnd db = new Northwnd(@"c:\northwnd.mdf");
            IEnumerable<sysMenuList> results =
                context.sysMenuLists.SqlQuery(ucDashboard.QRY_05_TOP_FIVE_ARTISTS);

            foreach (var menuItem in results)
            {
                MenuButton mButton = new MenuButton(menuItem.menuID, menuItem.menuText, menuItem.menuSubFormName, menuItem.Rank);
                if (menuItem.isDefault == true) Selected = mButton; 
                MenuList.Add(mButton);
            }
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
                foreach (MenuButton item in MenuList)
                {
                    item.FooterItemSelected +=
                        new MenuButton.dynMenuExpMenuClickEventHandler(OnFooterItemClicked);
                }
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
            OnMenuItemSelected(new EventArgs());
            //I need a way for this to communicate to the containing form that an item has been selected

        }

        /*******************************
        * Public Interface
        *******************************/

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
            foreach (MenuButton btn in MenuList)
            {
                AddControl(btn);
            }


            ResetSubMenus();
        }

        public void ClearSelected()
        {
            Selected = null;
            foreach (MenuButton menuItem in MenuList)
            {
                menuItem.Checked = false;
            }
            RepaintMenu();
        }

        public string getSelectedSubFormName()
        {
            if (Selected == null)
                return "";
            else
                return Selected.ucSubMenuName;
        }

        public string GetSelectedBtnText()
        {
            if (Selected == null)
                return "";
            else
                return Selected.ItemName;
        }

        //Returns the text on the button that is currently selected
        public String getSelectedText()
        {
            return Selected.Text;
        }

        /*******************************
        * Private Helper Methods
        *******************************/

        /// <summary>
        ///     Removes all controls from the menu
        /// </summary>
        private void ClearMenu()
        {
            foreach (Control ctrl in MenuPanel.Controls)
            {
                if (ctrl.GetType() == typeof(MenuButton))
                {
                    MenuPanel.Controls.Remove(ctrl);
                }
            }

            //MenuPanel.Controls.Clear();
        }

        private void ResetFormDim()
        {
            Container.Width = DEF_CONTAINER_SIZE_WIDTH;
            Container.Height = DEF_BOX_SIZE_HEIGHT;
            MenuPanel.Width = DEF_PANEL_SIZE_WIDTH;
            MenuPanel.Height = DEF_BOX_SIZE_HEIGHT;
            mParentCtrl.Height = DEF_BOX_SIZE_HEIGHT;
            Container.SplitterDistance = DEF_SPLITTER_DISTANCE;
        }


        /// <summary>
        ///     Actually adds the control to the form
        ///     Manipulates the space between buttons and keeps splitter in correct spot
        /// </summary>
        /// <param name="btn"></param>
        private void AddControl(MenuButton btn)
        {
            //Console.WriteLine("Adding Control : " + btn.Name);
            btn.Width = DEF_PANEL_SIZE_WIDTH;
            btn.Location = new Point(0, LastY);
            LastY += btn.Height + DEF_CTRL_BUFFER;
            //expand containers as well
            mParentCtrl.Height += btn.Height + DEF_CTRL_BUFFER;
            Container.Height += btn.Height + DEF_CTRL_BUFFER;
            MenuPanel.Height += btn.Height + DEF_CTRL_BUFFER;
            Container.SplitterDistance = DEF_SPLITTER_DISTANCE; //sliding, it moves when you increase the heigh, but we don't want it to so I just reset it back
            MenuPanel.Controls.Add(btn);
            
        }

        /// <summary>
        ///     Goes through all buttons, and for all menu items sets selected to false unless it is = Selected (set everytime a new item is selected)
        ///     Does not refresh, but does impact button rendering
        /// </summary>
        private void ResetSubMenus()
        {

            foreach (MenuButton btn in MenuList)
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

     


    /*#######################################
    # Class MenuButton
    #######################################*/

    /// <summary>
    ///     Represents a selectable menut item
    /// </summary>
    class MenuButton : Button
    {
        public String ItemName { get; set; }
        public String ucSubMenuName { get; set; }
        public long? MenuID { get; set; }
        public int? Rank { get; set; }
        public bool Checked { get; set; }

        public delegate void dynMenuExpMenuClickEventHandler(object sender, EventArgs e);

        public MenuButton(long? menuID,  String itemName, String ucSubMenuName, int? rank)
        {
            this.MenuID = menuID;
            this.Rank = rank;
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
            Checked = false;
            //Add event handler
            this.Click += new System.EventHandler(MenuButtonOnClickEvent);
        }

        private MenuButton(bool b)
        {
            Checked = b;

        }

        public event dynMenuExpMenuClickEventHandler FooterItemSelected;

        public virtual void OnMenuItemSelected(EventArgs e)
        {
            Console.WriteLine("OnMenutItemChanged run");
            if (FooterItemSelected != null)
            {
                FooterItemSelected(this, e);
            }

        }

        private void MenuButtonOnClickEvent(object sender, EventArgs e)
        {
            SetMenuButonState(true);
            OnMenuItemSelected(new EventArgs());
        }

        protected void setXY(int x, int y)
        {
            this.Width = x;
            this.Height = y;
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
            BackColor = Color.FromArgb(255, 135, 138, 160);
            ForeColor = Color.FromArgb(255, 255, 235, 200);
            Font = new Font(this.Font, FontStyle.Bold);
            FlatAppearance.MouseOverBackColor = Color.Peru;
        }

        private void SetSelectedDesign()
        {
            //BackColor = Color.FromArgb(255, 253, 252, 230); 
            BackColor = Color.FromArgb(255, 222, 208, 189);
            ForeColor = Color.FromArgb(255, 124, 38, 41);
            Font = new Font(this.Font, FontStyle.Bold);
            FlatAppearance.MouseOverBackColor = Color.Peru;
        }
    }
}
