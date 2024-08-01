using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    public partial class Check_In : Form
    {
        private string connectionString = @"Server=(localdb)\mssqllocaldb;Integrated Security=true;AttachDbFilename=D:\ioop\IOOP Group Assignment\HotelDatabase.mdf;";
        public Check_In()
        {
            InitializeComponent();
            LoadRoomTypes();
        }
        private void LoadRoomTypes()
        {
            roomTypeComboBox.Items.Add("Single - $100/night");
            roomTypeComboBox.Items.Add("Double - $150/night");
            roomTypeComboBox.Items.Add("Suite - $250/night");
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRoom = roomTypeComboBox.SelectedItem.ToString();
            if (selectedRoom.Contains("Single"))
                roomPriceTextBox.Text = "100";
            else if (selectedRoom.Contains("Double"))
                roomPriceTextBox.Text = "150";
            else if (selectedRoom.Contains("Suite"))
                roomPriceTextBox.Text = "250";

            CalculateTotalBalance(); // Recalculate total balance on room type change
        }
        private void CalculateTotalBalance()
        {
            if (int.TryParse(roomPriceTextBox.Text, out int roomPrice))
            {
                DateTime checkinDate = checkinDateTimePicker.Value;
                DateTime checkoutDate = checkinDateTimePicker.Value;
                int nights = (checkoutDate - checkinDate).Days;
                if (nights < 1) nights = 1; // Minimum 1 night stay

                int totalBalance = roomPrice * nights;
                totalBalanceTextBox.Text = totalBalance.ToString();
            }
        }

        private void Check_In_Load(object sender, EventArgs e)
        {

        }

        private void checkinButton_Click(object sender, EventArgs e)
        {

            string customerID = customerIDTextBox.Text;
            string roomType = roomTypeComboBox.SelectedItem?.ToString();
            DateTime checkinDate = checkinDateTimePicker.Value;
            DateTime checkoutDate = checkoutDateTimePicker.Value;
            int nights = (checkoutDate - checkinDate).Days;
            if (nights < 1) nights = 1; // Minimum 1 night stay
            int roomPrice = int.Parse(roomPriceTextBox.Text);
            int totalBalance = roomPrice * nights;

            if (string.IsNullOrEmpty(customerID) || string.IsNullOrEmpty(roomType))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Reservations (CustomerID, RoomID, CheckinDateTime, CheckoutDateTime, Nights, Balance) " +
                                   "VALUES (@CustomerID, @RoomType, @CheckinDateTime, @CheckoutDateTime, @Nights, @Balance)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CustomerID", customerID);
                    cmd.Parameters.AddWithValue("@RoomType", roomType);
                    cmd.Parameters.AddWithValue("@CheckinDateTime", checkinDate);
                    cmd.Parameters.AddWithValue("@CheckoutDateTime", checkoutDate);
                    cmd.Parameters.AddWithValue("@Nights", nights);
                    cmd.Parameters.AddWithValue("@Balance", totalBalance);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Customer checked in successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving reservation: " + ex.Message);
                }
            }
        }

        private void getBillButton_Click(object sender, EventArgs e)
        {
            CalculateTotalBalance();
        }
    }
}
