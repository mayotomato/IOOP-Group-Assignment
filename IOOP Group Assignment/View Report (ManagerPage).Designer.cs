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
            this.grpbox_Total_Revenue = new System.Windows.Forms.GroupBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpbox_Rooms_Reserved = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbl_Revenue_label = new System.Windows.Forms.Label();
            this.lbl_Revenue = new System.Windows.Forms.Label();
            this.lbl_Rooms = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Report
            // 
            this.pnl_Report.Controls.Add(this.dataGridView1);
            this.pnl_Report.Controls.Add(this.lbl_Rooms);
            this.pnl_Report.Controls.Add(this.lbl_Revenue);
            this.pnl_Report.Controls.Add(this.lbl_Revenue_label);
            this.pnl_Report.Controls.Add(this.monthCalendar1);
            this.pnl_Report.Controls.Add(this.grpbox_Total_Revenue);
            this.pnl_Report.Controls.Add(this.lblTitle);
            this.pnl_Report.Controls.Add(this.grpbox_Rooms_Reserved);
            this.pnl_Report.Controls.Add(this.label1);
            this.pnl_Report.Location = new System.Drawing.Point(1, 1);
            this.pnl_Report.Name = "pnl_Report";
            this.pnl_Report.Size = new System.Drawing.Size(615, 487);
            this.pnl_Report.TabIndex = 12;
            // 
            // grpbox_Total_Revenue
            // 
            this.grpbox_Total_Revenue.Location = new System.Drawing.Point(34, 64);
            this.grpbox_Total_Revenue.Name = "grpbox_Total_Revenue";
            this.grpbox_Total_Revenue.Size = new System.Drawing.Size(200, 62);
            this.grpbox_Total_Revenue.TabIndex = 2;
            this.grpbox_Total_Revenue.TabStop = false;
            this.grpbox_Total_Revenue.Text = "Total Revenue";
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
            this.grpbox_Rooms_Reserved.Location = new System.Drawing.Point(345, 66);
            this.grpbox_Rooms_Reserved.Name = "grpbox_Rooms_Reserved";
            this.grpbox_Rooms_Reserved.Size = new System.Drawing.Size(200, 62);
            this.grpbox_Rooms_Reserved.TabIndex = 1;
            this.grpbox_Rooms_Reserved.TabStop = false;
            this.grpbox_Rooms_Reserved.Text = "Total Rooms Reserved";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(19, 138);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 4;
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
            // lbl_Revenue
            // 
            this.lbl_Revenue.AutoSize = true;
            this.lbl_Revenue.Location = new System.Drawing.Point(431, 198);
            this.lbl_Revenue.Name = "lbl_Revenue";
            this.lbl_Revenue.Size = new System.Drawing.Size(13, 13);
            this.lbl_Revenue.TabIndex = 6;
            this.lbl_Revenue.Text = "[]";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(320, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 195);
            this.dataGridView1.TabIndex = 8;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}