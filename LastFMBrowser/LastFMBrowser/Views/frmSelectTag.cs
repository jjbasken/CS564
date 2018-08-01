using LastFMBrowser.Models;
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
    public partial class frmSelectTag : Form
    {
        /*******************************
        * Form Properties
        *******************************/

        private static LastFMDataEntities context { get; set; }
        public static int SelectedTagID { get; set; }

        /*******************************
        * Form Initialization
        *******************************/


        /// <summary>
        /// Constructor
        /// </summary>
        public frmSelectTag()
        {
            context = new LastFMDataEntities();
            InitializeComponent();
            SelectedTagID = -1;
            LoadLstSelect();
        }

        /// <summary>
        ///     Loads tag ist
        /// </summary>
        private void LoadLstSelect()
        {
            Console.WriteLine("Expected SQL = " + String.Format(ucDashboard.QRY_07_ALL_TAGS, txtSearch.Text));
            var results = context.Database.SqlQuery<QryTagList>(String.Format(ucDashboard.QRY_07_ALL_TAGS, txtSearch.Text));


            Dictionary<int, string> listSource = new Dictionary<int, string>();

            foreach (var result in results)
            {
                listSource.Add(Convert.ToInt32(result.TagID), result.TagValue);
            }

            lstSelect.DataSource = new BindingSource(listSource, null);
            lstSelect.DisplayMember = "Value";
            lstSelect.ValueMember = "Key";
        }

        /*******************************
        * Broadcasting
        *******************************/

        public delegate void TagSelectedEventHandler(object sender, EventArgs e);

        public event TagSelectedEventHandler TagSelected;

        public virtual void OnTagSelected(EventArgs e)
        {
            //Console.WriteLine("MenuItemSelected run");
            if (TagSelected != null)
            {
                TagSelected(this, e);
            }

        }


        /*******************************
        * Form Events
        *******************************/

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadLstSelect();
        }

        private void lstSelect_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
            SelectedTagID = Convert.ToInt32(lstSelect.SelectedValue);
            Console.WriteLine("Calling TagSelected with tagID = " + SelectedTagID);
            OnTagSelected(new EventArgs()); //Call for broadcast
        }


        

    }

    /*******************************
    * Helper classes
    *******************************/

    class QryTagList
    {
        public int TagID { get; set; }
        public string TagValue { get; set; }

    }
}
