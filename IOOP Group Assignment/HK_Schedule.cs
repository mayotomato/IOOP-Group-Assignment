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
        public string sqlDateFormat;

        public HK_Schedule()
        {
            InitializeComponent();
            data_Reservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_RoomCleaning.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            if (data_Reservations.SelectedRows.Count > 0)
            {
                int rowIndex = data_Reservations.SelectedRows[0].Index;
                DataGridViewRow selectedRow = data_Reservations.Rows[rowIndex];

                // Retrieve the ID of the selected row
                int id = Convert.ToInt32(selectedRow.Cells["SuppliesID"].Value); // Ensure "ID" is the correct column name

                // Confirm deletion with the user
                DialogResult result = MessageBox.Show("Are you sure you want to delete this entry?", "Confirm Delete", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    // Call method to choose from database

                    

                    // Optionally, refresh the DataGridView
                    LoadReservations();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void ChooseReservation()
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

            string query = $"SELECT * FROM Reservations WHERE CAST(CheckinDateTime AS DATE) = DATEADD(day, 1, '{sqlDateFormat}');";

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
            LoadReservations();
        }

        private void HK_Schedule_Load(object sender, EventArgs e)
        {
            LoadCleaning();
            LoadReservations();
        }

        private void cal_Reservations_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime selectedDate = e.Start.Date;
            sqlDateFormat = selectedDate.ToString("yyyy-MM-dd");
            
            LoadReservations();

        }
    }
}
