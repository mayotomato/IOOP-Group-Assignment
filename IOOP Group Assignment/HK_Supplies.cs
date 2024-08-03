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

        public string SupplyType;

        private void btn_Confirm_Click(object sender, EventArgs e)
        {
            string SupplyName = txtbox_SupplyName.Text;
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

            Housekeeper house = new Housekeeper();
            house.AddSupply(SupplyName, SupplyType, SupplyCount);

        }

        private void LoadData()
        {
            string query = "SELECT * FROM Supplies"; 

            using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, ConfigurationManager.ConnectionStrings["myCS"].ToString()))
            {
                DataSet dataSet = new DataSet();

                dataAdapter.Fill(dataSet, "Supplies");

                data_Supplies.DataSource = dataSet.Tables["Supplies"];
            }
        }

        private void radio_Cleaning_CheckedChanged(object sender, EventArgs e)
        {
            SupplyType = "CleaningSupplies";
        }

        private void radio_Equipment_CheckedChanged(object sender, EventArgs e)
        {
            SupplyType = "Equipment";
        }

        private void HK_Supplies_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }

        
}
