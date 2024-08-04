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
        public List<string> rowData;

        public HK_Schedule()
        {
            InitializeComponent();
            data_Reservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_RoomCleaning.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            List<string> rowData = new List<string>();
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
                DataGridViewRow selectedRow = data_Reservations.SelectedRows[0];


                // Retrieve data from selected row
                foreach (DataGridViewCell cell in selectedRow.Cells)
                {
                    rowData.Add(cell.Value?.ToString() ?? "NULL");
                }

                // Display data in a message box
                MessageBox.Show("Selected Row Data:\n" + string.Join("\n", rowData));

                UpdateReservationsPnl();

            }
            else
            {
                MessageBox.Show("Please select a row to view.");
            }
        }

        private void UpdateReservationsPnl() 
        {
            // Set the Check-in time label
            lbl_Checkin.Text = "Check-in Time: " + rowData[2];

            // Retrieve RoomID
            string roomid = rowData[1]; // Ensure this index matches the RoomID column

            // Retrieve information from the Rooms table
            Housekeeper house = new Housekeeper();
            var roomInfo = house.RetrieveRoomInformation(roomid);

            lbl_RoomNum2.Text = "Room Number: " + roomInfo.Item1;
            lbl_Condition2.Text = "Condition: " + roomInfo.Item2;

            if (roomInfo.Item2 == "Clean")
            {
                lbl_Warning.Text = "*Room must be prepared";
            }
            else if (roomInfo.Item2 == "Dirty")
            {
                lbl_Warning.Text = "*Room must be cleaned then prepared";
            }
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

            string query = $"SELECT ReservationID, RoomID, CheckinDateTime, Notes FROM Reservations WHERE CAST(CheckinDateTime AS DATE) = DATEADD(day, 1, '{sqlDateFormat}');";

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "Reservations");

                data_Reservations.DataSource = dataSet.Tables["Reservations"];
            }
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

        private void btn_Refresh2_Click(object sender, EventArgs e)
        {
            LoadReservations();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            LoadCleaning();
        }

        private void btn_MarkPrepared_Click(object sender, EventArgs e) { }
        //{
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
        //    con.Open();

        //    SqlCommand cmd = new SqlCommand("UPDATE Supplies SET SuppliesName = @SupplyName WHERE SuppliesID = @ID", con);
        //    cmd.Parameters.AddWithValue("@SupplyName", newSupplyName);
        //    cmd.Parameters.AddWithValue("@ID", id);

        //    try
        //    {
        //        int rowsAffected = cmd.ExecuteNonQuery();

        //        if (rowsAffected > 0)
        //        {
        //            MessageBox.Show("Record updated successfully.");

        //            LoadData("Supplies");
        //        }
        //        else
        //        {
        //            MessageBox.Show("No record found with the specified ID.");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }
        //}
    }
}
