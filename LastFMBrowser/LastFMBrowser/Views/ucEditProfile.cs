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
using LastFMBrowser.Models;

namespace LastFMBrowser.Views
{
    public partial class ucEditProfile : UserControl, ISwapPanelSubForm
    {

        private static LastFMDataEntities context { get; set; }
        private frmMain mParent { get; set; }

        /********************************
         * Constructor
        ********************************/
        public ucEditProfile()
        {
            InitializeComponent();

            
        }

        private void ucEditProfile_Load(object sender, EventArgs e)
        {
            
            mParent = (this.ParentForm as frmMain);
            context = new LastFMDataEntities();
            InitUC();
        }


        private void InitUC()
        {
            long tempID;
            tempID = mParent.GetActiveUser();
            RefUserList();
            mParent.SetActiveUser(tempID);
            SetUserList();
        }

        private void SetUserList() 
        {
            try
            {
                cmbSelectUser.SelectedValue = mParent.GetActiveUser();
            }
            catch (Exception Exc)
            {
                throw Exc;
            }
        }

        

        private void RefUserList()
        {

            Console.WriteLine("SQL = " + String.Format(ucDashboard.QRY_08_ALL_USERS));
            var results = context.Database.SqlQuery<QryUserList>(ucDashboard.QRY_08_ALL_USERS);

            Dictionary<long, string> listSource = new Dictionary<long, string>();
           
            foreach (var result in results)
            {
                listSource.Add(result.UserID, result.FullName);
            }

            if (listSource.Count == 0)
            {
                listSource.Add(-1, "<no available users>");
            }

            cmbSelectUser.DataSource = new BindingSource(listSource, null);
            cmbSelectUser.DisplayMember = "Value";
            cmbSelectUser.ValueMember = "Key";
        }
        /********************************
         * Form Initialization
        ********************************/

        public void RefreshUserControl()
        {
        }

        private void cmbSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
           if(mParent != null) mParent.SetActiveUser((long) ((KeyValuePair<long, string>)cmbSelectUser.SelectedItem).Key);
        }

        
    }

    class QryUserList
    {
        public string FullName { get; set; }
        public long UserID { get; set; }
    }

}
