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
        public ManagerPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ManagerPage_Load(object sender, EventArgs e)
        {
            pnl_Main.Visible = true;
            pnl_Manage_Accounts.Visible = false;
            pnl_Manage_Rooms.Visible = false;
            pnl_Manage_Housekeeping.Visible = false;
            pnl_Report.Visible = false;
        }

        private void lnklbl_Manage_Account_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnl_Main.Visible = false;
            pnl_Manage_Accounts.Visible = true;
            pnl_Manage_Rooms.Visible = false;
            pnl_Manage_Housekeeping.Visible = false;
            pnl_Report.Visible = false;
        }

        private void lnklbl_Manage_Room_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnl_Main.Visible = false;
            pnl_Manage_Accounts.Visible = false;
            pnl_Manage_Rooms.Visible = true;
            pnl_Manage_Housekeeping.Visible = false;
            pnl_Report.Visible = false;
        }

        private void lnklb_Manage_Housekeeping_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnl_Main.Visible = false;
            pnl_Manage_Accounts.Visible = false;
            pnl_Manage_Rooms.Visible = false;
            pnl_Manage_Housekeeping.Visible = true;
            pnl_Report.Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lnklbl_View_Report_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnl_Main.Visible = false;
            pnl_Manage_Accounts.Visible = false;
            pnl_Manage_Rooms.Visible = false;
            pnl_Manage_Housekeeping.Visible = false;
            pnl_Report.Visible = true;
        }
    }
}
