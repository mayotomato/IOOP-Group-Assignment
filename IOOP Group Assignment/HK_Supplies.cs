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
using System.Configuration;

namespace IOOP_Group_Assignment
{
    public partial class HK_Supplies : Form
    {
        public HK_Supplies()
        {
            InitializeComponent();
            
        }

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string SupplyName = txtbox_SupplyName.Text;
            string SupplyType = txtbox_SupplyType.Text;
            int SupplyCount = 0;
            try
            {
                SupplyCount = int.Parse(txtbox_SupplyCount.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect Supply Count value");
                return;
            }

            if (string.IsNullOrEmpty(SupplyName) || string.IsNullOrEmpty(SupplyType))
            {
                MessageBox.Show("Please fill in all the required fields.");
                return;
            }

            AddSupply(SupplyName, SupplyType, SupplyCount);
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
