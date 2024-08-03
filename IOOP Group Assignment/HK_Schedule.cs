using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    public partial class HK_Schedule : Form
    {
        public HK_Schedule()
        {
            InitializeComponent();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            HK_IssueReport f3 = new HK_IssueReport();
            f3.ShowDialog();
        }

        private void pnl_RoomDetailView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_RoomChoose2_Click(object sender, EventArgs e)
        {

        }

        private void LoadCleaning()
        {
            string query = "SELECT * FROM " + "HousekeepingSchedule";

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "HousekeepingSchedule");

                data_RoomCleaning.DataSource = dataSet.Tables["HousekeepingSchedule"];
            }
        }

        private void LoadReservations()
        {

            string query = "SELECT * FROM " + "Reservations WHERE ";

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "Reservations");

                data_Reservations.DataSource = dataSet.Tables["Reservations"];
            }
        }

        private void data_Reservations_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabClnSchdl_Click(object sender, EventArgs e)
        {
            LoadCleaning();
        }

        private void tabReservations_Click(object sender, EventArgs e)
        {
            LoadData("Reservations", data_Reservations);
        }
    }
}
