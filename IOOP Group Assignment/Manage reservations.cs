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
    public partial class Manage_reservations : Form
    {
    
        public Manage_reservations()
        {
            InitializeComponent();
            InitializeDataGridView();
        }
        private void InitializeDataGridView()
        {
            // Initialize and set properties for DataGridView
            dataGridView2 = new DataGridView
            {
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(600, 150),
                Columns =
                {
                new DataGridViewTextBoxColumn { HeaderText = "Room Type" },
                new DataGridViewTextBoxColumn { HeaderText = "Floor" },
                new DataGridViewTextBoxColumn { HeaderText = "Price" }
                }
            };
            // Add DataGridView to the form
            this.Controls.Add(dataGridView2);
        }
        public void AddRoomToDataGridView(string roomType, string floor, string price)
        {
            dataGridView2.Rows.Add(roomType, floor, price);
        }
        private void Manage_reservations_Load(object sender, EventArgs e)
        {

        }

    }
}
