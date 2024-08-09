namespace IOOP_Group_Assignment
{
    partial class ViewReportForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Report = new System.Windows.Forms.Panel();
            this.listview_Rooms = new System.Windows.Forms.ListView();
            this.lbl_Rooms = new System.Windows.Forms.Label();
            this.lbl_Revenue = new System.Windows.Forms.Label();
            this.lbl_Revenue_label = new System.Windows.Forms.Label();
            this.cal_Reservation = new System.Windows.Forms.MonthCalendar();
            this.grpbox_Total_Revenue = new System.Windows.Forms.GroupBox();
            this.lbl_Total_Revenue = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpbox_Rooms_Reserved = new System.Windows.Forms.GroupBox();
            this.lbl_Total_Rooms = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Report.SuspendLayout();
            this.grpbox_Total_Revenue.SuspendLayout();
            this.grpbox_Rooms_Reserved.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Report
            // 
            this.pnl_Report.Controls.Add(this.listview_Rooms);
            this.pnl_Report.Controls.Add(this.lbl_Rooms);
            this.pnl_Report.Controls.Add(this.lbl_Revenue);
            this.pnl_Report.Controls.Add(this.lbl_Revenue_label);
            this.pnl_Report.Controls.Add(this.cal_Reservation);
            this.pnl_Report.Controls.Add(this.grpbox_Total_Revenue);
            this.pnl_Report.Controls.Add(this.lblTitle);
            this.pnl_Report.Controls.Add(this.grpbox_Rooms_Reserved);
            this.pnl_Report.Controls.Add(this.label1);
            this.pnl_Report.Location = new System.Drawing.Point(1, 1);
            this.pnl_Report.Name = "pnl_Report";
            this.pnl_Report.Size = new System.Drawing.Size(615, 487);
            this.pnl_Report.TabIndex = 12;
            // 
            // listview_Rooms
            // 
            this.listview_Rooms.HideSelection = false;
            this.listview_Rooms.Location = new System.Drawing.Point(332, 266);
            this.listview_Rooms.Name = "listview_Rooms";
            this.listview_Rooms.Size = new System.Drawing.Size(213, 185);
            this.listview_Rooms.TabIndex = 9;
            this.listview_Rooms.UseCompatibleStateImageBehavior = false;
            // 
            // lbl_Rooms
            // 
            this.lbl_Rooms.AutoSize = true;
            this.lbl_Rooms.Location = new System.Drawing.Point(388, 240);
            this.lbl_Rooms.Name = "lbl_Rooms";
            this.lbl_Rooms.Size = new System.Drawing.Size(92, 13);
            this.lbl_Rooms.TabIndex = 7;
            this.lbl_Rooms.Text = "Rooms Occupied:";
            // 
            // lbl_Revenue
            // 
            this.lbl_Revenue.AutoSize = true;
            this.lbl_Revenue.Location = new System.Drawing.Point(431, 198);
            this.lbl_Revenue.Name = "lbl_Revenue";
            this.lbl_Revenue.Size = new System.Drawing.Size(13, 13);
            this.lbl_Revenue.TabIndex = 6;
            this.lbl_Revenue.Text = "[]";
            // 
            // lbl_Revenue_label
            // 
            this.lbl_Revenue_label.AutoSize = true;
            this.lbl_Revenue_label.Location = new System.Drawing.Point(410, 165);
            this.lbl_Revenue_label.Name = "lbl_Revenue_label";
            this.lbl_Revenue_label.Size = new System.Drawing.Size(54, 13);
            this.lbl_Revenue_label.TabIndex = 5;
            this.lbl_Revenue_label.Text = "Revenue:";
            // 
            // cal_Reservation
            // 
            this.cal_Reservation.Location = new System.Drawing.Point(19, 138);
            this.cal_Reservation.MaxSelectionCount = 1;
            this.cal_Reservation.Name = "cal_Reservation";
            this.cal_Reservation.TabIndex = 4;
            // 
            // grpbox_Total_Revenue
            // 
            this.grpbox_Total_Revenue.Controls.Add(this.lbl_Total_Revenue);
            this.grpbox_Total_Revenue.Location = new System.Drawing.Point(34, 64);
            this.grpbox_Total_Revenue.Name = "grpbox_Total_Revenue";
            this.grpbox_Total_Revenue.Size = new System.Drawing.Size(200, 62);
            this.grpbox_Total_Revenue.TabIndex = 2;
            this.grpbox_Total_Revenue.TabStop = false;
            this.grpbox_Total_Revenue.Text = "Total Revenue";
            // 
            // lbl_Total_Revenue
            // 
            this.lbl_Total_Revenue.AutoSize = true;
            this.lbl_Total_Revenue.Location = new System.Drawing.Point(93, 29);
            this.lbl_Total_Revenue.Name = "lbl_Total_Revenue";
            this.lbl_Total_Revenue.Size = new System.Drawing.Size(13, 13);
            this.lbl_Total_Revenue.TabIndex = 9;
            this.lbl_Total_Revenue.Text = "[]";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(28, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(148, 33);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "View Report";
            // 
            // grpbox_Rooms_Reserved
            // 
            this.grpbox_Rooms_Reserved.Controls.Add(this.lbl_Total_Rooms);
            this.grpbox_Rooms_Reserved.Location = new System.Drawing.Point(345, 66);
            this.grpbox_Rooms_Reserved.Name = "grpbox_Rooms_Reserved";
            this.grpbox_Rooms_Reserved.Size = new System.Drawing.Size(200, 62);
            this.grpbox_Rooms_Reserved.TabIndex = 1;
            this.grpbox_Rooms_Reserved.TabStop = false;
            this.grpbox_Rooms_Reserved.Text = "Total Rooms Reserved";
            // 
            // lbl_Total_Rooms
            // 
            this.lbl_Total_Rooms.AutoSize = true;
            this.lbl_Total_Rooms.Location = new System.Drawing.Point(95, 27);
            this.lbl_Total_Rooms.Name = "lbl_Total_Rooms";
            this.lbl_Total_Rooms.Size = new System.Drawing.Size(13, 13);
            this.lbl_Total_Rooms.TabIndex = 10;
            this.lbl_Total_Rooms.Text = "[]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // ViewReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 488);
            this.Controls.Add(this.pnl_Report);
            this.Name = "ViewReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Report";
            this.Load += new System.EventHandler(this.ViewReportForm_Load);
            this.pnl_Report.ResumeLayout(false);
            this.pnl_Report.PerformLayout();
            this.grpbox_Total_Revenue.ResumeLayout(false);
            this.grpbox_Total_Revenue.PerformLayout();
            this.grpbox_Rooms_Reserved.ResumeLayout(false);
            this.grpbox_Rooms_Reserved.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Report;
        private System.Windows.Forms.GroupBox grpbox_Rooms_Reserved;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpbox_Total_Revenue;
        private System.Windows.Forms.Label lbl_Rooms;
        private System.Windows.Forms.Label lbl_Revenue;
        private System.Windows.Forms.Label lbl_Revenue_label;
        private System.Windows.Forms.MonthCalendar cal_Reservation;
        private System.Windows.Forms.Label lbl_Total_Rooms;
        private System.Windows.Forms.ListView listview_Rooms;
        private System.Windows.Forms.Label lbl_Total_Revenue;
    }
}