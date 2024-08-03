using System;
using System.Collections.Generic;
using System.Configuration;
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

        public void AddSupply(string SupplyName, string SupplyType, int SupplyCount)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO Supplies(SupplyType, SuppliesName, Count)" +
                "values (@a, @b, @c)", con);
            cmd.Parameters.AddWithValue("@a", SupplyName);
            cmd.Parameters.AddWithValue("@b", SupplyType);
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
    }
}