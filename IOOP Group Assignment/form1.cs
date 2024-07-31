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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void HotelTitle_Click(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void btn_Rooms_Click(object sender, EventArgs e)
        {
            Send_review f2 = new Send_review();
            f2.Show();
        }

        private void btn_sendreview_Click(object sender, EventArgs e)
        {
            Send_review f2 = new Send_review();
            f2.Show();
        }

        private void btn_Managereservations_Click(object sender, EventArgs e)
        {
            Manage_reservations f2 = new Manage_reservations();
            f2.Show();
        }
    }
}
