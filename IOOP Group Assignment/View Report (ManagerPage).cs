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
    public partial class ViewReportForm : Form
    {
        private Manager admin;

        public ViewReportForm(Manager admin)
        {
            InitializeComponent();
            cal.DateChanged += cal_DateChanged;
            this.admin = admin;

        }

        private void ViewReportForm_Load(object sender, EventArgs e)
        {
            RefreshTotalRooms();
            RefreshTotalRevenue();
        }
        private void cal_DateChanged(object sender, DateRangeEventArgs e)
        {
            listview_Rooms.Clear();
            lbl_Revenue.Text = "[]";

            // Handle date change event here
            DateTime startDate = e.Start;
            DateTime endDate = e.End;


            //MessageBox.Show($"Selected Date Range: {startDate.ToShortDateString()} to {endDate.ToShortDateString()}");
            int[] roomIDs =  admin.GetRoomData(startDate);
            foreach (int roomID in roomIDs)
            {
                // Create a ListViewItem with the RoomID
                ListViewItem item = new ListViewItem(roomID.ToString());

                // Add the ListViewItem to the ListView
                listview_Rooms.Items.Add(item);
            }

            lbl_Revenue.Text = admin.GetRevenueByDate(startDate).ToString();
        }

        private void RefreshTotalRooms()
        {
            lbl_Total_Rooms.Text = admin.GetTotalRooms().ToString();
        }
        private void RefreshTotalRevenue()
        {
            lbl_Total_Revenue.Text = admin.GetTotalRevenue().ToString();
        }
    }
}
