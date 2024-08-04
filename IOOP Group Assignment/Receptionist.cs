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
    public partial class Receptionist : Form
    {
        public Receptionist()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AddCustomer Add = new AddCustomer();
            Add.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteCustomer Delete = new DeleteCustomer();
            Delete.ShowDialog();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            booking booking = new booking();
            booking.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Check_In checkIn = new Check_In();
            checkIn.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Checkout checkOUT = new Checkout();
            checkOUT.ShowDialog();
        }

        private void Receptionist_Load(object sender, EventArgs e)
        {

        }

    }
}
