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
    public partial class Booking : Form
    {
        private string connectionString = @"Server=(localdb)\mssqllocaldb;Integrated Security=true;AttachDbFilename=D:\ioop\ioop\IOOP Group Assignment\GoodStayHotelDatabase.mdf;";

        public Booking()
        {
            InitializeComponent();
            BokingBtn.Click += new EventHandler(this.BokingBtn_Click);
        }

        private void booking_Load(object sender, EventArgs e)
        {
            // Optional: Add any initialization logic if needed
        }

        private void BokingBtn_Click(object sender, EventArgs e)
        {
            // Step 1: Retrieve CusID
            string cusID = CusIDTextbox.Text.Trim(); // Trim any whitespace

            if (string.IsNullOrWhiteSpace(cusID))
            {
                MessageBox.Show("Please enter a valid Customer ID.");
                return;
            }

            // Step 2: Query the Reservations table
            string query = "SELECT ReservationID, CheckinDateTime, CheckoutDateTime, Nights FROM Reservations WHERE CusID = @CusID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CusID", cusID);

                try
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            // Step 3: Format the message
                            string reservationID = reader["ReservationID"].ToString();
                            DateTime checkin = Convert.ToDateTime(reader["CheckinDateTime"]);
                            DateTime checkout = Convert.ToDateTime(reader["CheckoutDateTime"]);
                            int nights = Convert.ToInt32(reader["Nights"]);

                            string message = $"Your Reservation ID is {reservationID}. " +
                                             $"You will check in on {checkin:MM/dd/yyyy} and " +
                                             $"check out on {checkout:MM/dd/yyyy}. " +
                                             $"Your stay period is for a total of {nights} nights.";

                            // Step 4: Display the message
                            DisplayBoxBooking.Text = message;
                        }
                        else
                        {
                            DisplayBoxBooking.Text = "No reservation found for the provided customer ID.";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}