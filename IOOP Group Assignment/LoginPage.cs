using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Group_Assignment
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void CustomerRadio_CheckedChanged(object sender, EventArgs e)
        {
            UserLabel.Text = "Email";
            NewUserLinkLabel.Text = "New user? Register account";

        }

        private void ReceptionistRadio_CheckedChanged(object sender, EventArgs e)
        {
            UserLabel.Text = "Username";
            NewUserLinkLabel.Text = "";
        }

        private void ManagerRadio_CheckedChanged(object sender, EventArgs e)
        {
            UserLabel.Text = "Username";
            NewUserLinkLabel.Text = "";
        }

        private void HousekeepingRadio_CheckedChanged(object sender, EventArgs e)
        {
            UserLabel.Text = "Username";
            NewUserLinkLabel.Text = "";
        }

        private void NewUserLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private bool passwordVisibility = false;
        private void PasswordVisibilityButton_Click(object sender, EventArgs e)
        {
            passwordVisibility = !passwordVisibility;

            if (passwordVisibility) 
            {
                PasswordBox.UseSystemPasswordChar = false;
                PasswordVisibilityButton.Image = Properties.Resources.Eye_Show;
            }
            else
            {
                PasswordBox.UseSystemPasswordChar = true;
                PasswordVisibilityButton.Image = Properties.Resources.Eye_Hide;
            }
        }

        private void LoginPagePrompt_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var (userType, name) = AuthenticateUser(UsernameBox.Text, PasswordBox.Text);

            if (userType != null)
            {
                // Successful login
                MessageBox.Show($"Login successful. User type: {userType}\nName: {name}");
                // Redirect to appropriate form based on userType
                switch (userType)
                {
                    case "Customer":
                        CustomerPage customerForm = new CustomerPage();
                        customerForm.Show();
                        break;
                    case "Receptionist":
                        ReceptionPage receptionForm = new ReceptionPage();
                        receptionForm.Show();
                        break;
                    case "Housekeeper":
                        Housekeeping housekeeingForm = new Housekeeping();
                        housekeeingForm.Show(); 
                        break;
                    case "Manager":
                        ManagerPage managerForm = new ManagerPage();
                        managerForm.Show();
                        break;
                    default:
                        MessageBox.Show("Unknown user type.");
                        break;
                }
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid username or password.");
            }
        }

        // Method to authenticate user and get the user type
        private (string UserType, string Name) AuthenticateUser(string username, string password)
        {
            // Define the connection string (update with your actual connection string)
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

            // Define the SQL query to check the username and password across multiple tables
            string query = @"
            SELECT UserType, Name
            FROM (
                SELECT 'Customer' AS UserType, Name
                FROM Customers
                WHERE Name = @Username AND Password = @Password
                UNION
                SELECT 'Receptionist' AS UserType, Name
                FROM Receptionists
                WHERE Username = @Username AND Password = @Password
                UNION
                SELECT 'Housekeeper' AS UserType, Name
                FROM Housekeepers
                WHERE Username = @Username AND Password = @Password
                UNION
                SELECT 'Manager' AS UserType, Name
                FROM Managers
                WHERE Username = @Username AND Password = @Password
            ) AS UserTypes";

            // Initialize user type and name
            string userType = null;
            string name = null;

            // Create a SqlConnection and SqlCommand to execute the query
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Add parameters to prevent SQL injection
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    try
                    {
                        // Open the connection
                        connection.Open();

                        // Execute the command and retrieve the result
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Read the result
                            if (reader.Read())
                            {
                                userType = reader["UserType"].ToString();
                                name = reader["Name"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle any errors that occurred during the process
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }

            // Return the user type and name
            return (userType, name);
        }

        private void HotelTitle_Click(object sender, EventArgs e)
        {

        }
    }
}
