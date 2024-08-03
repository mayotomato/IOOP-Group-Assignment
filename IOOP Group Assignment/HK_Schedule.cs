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
    public partial class HK_Schedule : Form
    {
        public HK_Schedule()
        {
            InitializeComponent();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            HK_IssueReport f3 = new HK_IssueReport();
            f3.ShowDialog();
        }

        private void pnl_RoomDetailView_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_RoomChoose2_Click(object sender, EventArgs e)
        {

        }
    }
}
