using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IOOP_Group_Assignment
{
    internal class Housekeeper
    {


        private void MarkCLeaned()
        {

        }

        public void DeleteEntryFromSupplies(int id)
        {
            // Connection string (replace with your actual connection string)
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

            // SQL query to delete the record
            string query = "DELETE FROM Supplies WHERE SuppliesID = @ID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ID", id);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No record found with the specified ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        public void AddSupply(string SupplyName, string SupplyType, int SupplyCount)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Supplies(SupplyType, SuppliesName, Count)" +
                "values (@a, @b, @c)", con);
            cmd.Parameters.AddWithValue("@a", SupplyType);
            cmd.Parameters.AddWithValue("@b", SupplyName);
            cmd.Parameters.AddWithValue("@c", SupplyCount);

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Supply added successfully.");
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"An error occurred while adding the supply: {ex.Message}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}");
            }
            finally
            {
                con.Close();
            }
        }

        public Tuple<string, string> RetrieveRoomInformation(string roomid)
        {
            // Connection string (replace with your actual connection string)
            string connectionString = ConfigurationManager.ConnectionStrings["myCS"].ToString();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // Open the connection
                con.Open();

                // Create the SQL command with parameterized query
                string query = "SELECT RoomNumber, Condition FROM Rooms WHERE RoomID = @RoomID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Add parameter to the command
                    cmd.Parameters.AddWithValue("@RoomID", roomid);

                    // Execute the command and retrieve data
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Retrieve RoomNumber and Condition
                            string roomNumber = reader["RoomNumber"].ToString();
                            string condition = reader["Condition"].ToString();

                            // Return the values as a tuple
                            return Tuple.Create(roomNumber, condition);
                        }
                        else
                        {
                            // Handle case where no record is found
                            return Tuple.Create("Not Found", "Not Found");
                        }
                    }
                }
            }
        }

    }
}
