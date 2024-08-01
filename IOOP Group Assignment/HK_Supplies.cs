using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            
        }

        private void AddSupply()
        {
            string SupplyName = txtbox_SupplyName.Text;
            string SupplyType = txtbox_SupplyType.Text;
            try
            {
                int SupplyCount = int.Parse(txtbox_SupplyCount.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Incorrect Supply Count");
            }



                

            
        }
    }

        
}
