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
    public partial class Checkout : Form
    {
        private string connectionString = @"Server=(localdb)\mssqllocaldb;Integrated Security=true;AttachDbFilename=D:\ioop\ioop\IOOP Group Assignment\GoodStayHotelDatabase.mdf;";


        public Checkout()
        {
            InitializeComponent();  
            CheckOut_btn.Click += new EventHandler(CheckOut_btn_Click_1);
            paymBtn.Click += new EventHandler(paymBtn_Click_1); 
        }
        private int GetReservationIDByName(string name)
        {
            int reservationID = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT ReservationID FROM Reservations WHERE Name = @Name", conn);
                    cmd.Parameters.AddWithValue("@Name", name);

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        reservationID = (int)reader["ReservationID"];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

            return reservationID;
        }

        private void UpdateRoomAvailability(string roomType, int reservationID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE rOOMS SET Availability = 'Available' WHERE RoomType = @RoomType AND ReservationID = @ReservationID", conn);
                    cmd.Parameters.AddWithValue("@RoomType", roomType);
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void UpdatePaymentStatus(int reservationID)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Reservations SET PaymentStatus = 'Collected' WHERE ReservationID = @ReservationID", conn);
                    cmd.Parameters.AddWithValue("@ReservationID", reservationID);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // Handle label6 click event if necessary
        }

        private void paymBtn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = name_TextBox.Text;
                int reservationID = GetReservationIDByName(name);

                if (reservationID > 0)
                {
                    UpdatePaymentStatus(reservationID);
                    paymTextbox.Text = "Payment has been collected. Thank you for using GoodStay Hotel.";
                }
                else
                {
                    MessageBox.Show("Reservation not found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void paymTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckOut_btn_Click_1(object sender, EventArgs e)
        {
            try
            {
                string name = name_TextBox.Text;
                string roomType = ComboBoxRoomType.SelectedItem?.ToString();
                int reservationID = GetReservationIDByName(name);

                if (reservationID > 0 && !string.IsNullOrEmpty(roomType))
                {
                    UpdateRoomAvailability(roomType, reservationID);
                    MessageBox.Show("Room availability updated successfully.");
                }
                else
                {
                    MessageBox.Show("Reservation not found or room type not selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }
    }
}