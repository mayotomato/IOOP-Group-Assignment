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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace IOOP_Group_Assignment
{
    public partial class ManageAccountsForm : Form
    {
        public ManageAccountsForm()
        {
            InitializeComponent();
        }

        private void btn_Add_User_Click(object sender, EventArgs e)
        {
            
            string query = "INSERT INTO Supplies (SupplyType, SuppliesName) VALUES ('test', 'test')";

            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myCS"].ToString());
            
            {
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    // Check if the insertion was successful
                    if (result > 0)
                    {
                        MessageBox.Show("User Added Successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Add User.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}"); 
                }
            }
        }
    }
}
