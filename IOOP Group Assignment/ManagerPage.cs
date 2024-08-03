using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    public partial class ManagerPage : Form
    {
        public Manager admin;

        public ManagerPage()
        {
            InitializeComponent();
            admin = new Manager("testusername", "testpassword", "testID");
        }


        public void ManagerPage_Load(object sender, EventArgs e)
        {
            /*pnl_Main.Visible = true;
            pnl_Manage_Accounts.Visible = false;
            pnl_Manage_Rooms.Visible = false;
            pnl_Manage_Housekeeping.Visible = false;
            pnl_Report.Visible = false;*/

            //wait should i declare the Form objects of the subpages when the main Manager form loads or do i delcare them after their corresponding buttons get pressed

            
        }

        private void btn_Manage_Accounts_Click(object sender, EventArgs e)
        {
            ManageAccountsForm form = new ManageAccountsForm(admin);
            form.Show();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            ManageRoomsForm form = new ManageRoomsForm(admin);
            form.Show();
        }
        private void btn_Manage_Housekeeping_Click(object sender, EventArgs e)
        {
            ManageHousekeepingForm form = new ManageHousekeepingForm(admin);

            form.Show();
        }
        private void btn_View_Report_Click(object sender, EventArgs e)
        {
            ViewReportForm form = new ViewReportForm(admin);

            form.Show();
        }

        

        

        
    }
}
