namespace IOOP_Group_Assignment
{
    partial class HK_Schedule
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
            this.tab_Schedule = new System.Windows.Forms.TabControl();
            this.tabClnSchdl = new System.Windows.Forms.TabPage();
            this.data_RoomCleaning = new System.Windows.Forms.DataGridView();
            this.pnl_RoomDetailView = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_Condition = new System.Windows.Forms.Label();
            this.lbl_Availability = new System.Windows.Forms.Label();
            this.lbl_RoomNum = new System.Windows.Forms.Label();
            this.btn_RoomChoose = new System.Windows.Forms.Button();
            this.cal_Cleaning = new System.Windows.Forms.MonthCalendar();
            this.tabReservations = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tab_Schedule.SuspendLayout();
            this.tabClnSchdl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_RoomCleaning)).BeginInit();
            this.pnl_RoomDetailView.SuspendLayout();
            this.tabReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Schedule
            // 
            this.tab_Schedule.Controls.Add(this.tabClnSchdl);
            this.tab_Schedule.Controls.Add(this.tabReservations);
            this.tab_Schedule.Location = new System.Drawing.Point(10, 17);
            this.tab_Schedule.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tab_Schedule.Name = "tab_Schedule";
            this.tab_Schedule.SelectedIndex = 0;
            this.tab_Schedule.Size = new System.Drawing.Size(1146, 862);
            this.tab_Schedule.TabIndex = 0;
            // 
            // tabClnSchdl
            // 
            this.tabClnSchdl.Controls.Add(this.data_RoomCleaning);
            this.tabClnSchdl.Controls.Add(this.pnl_RoomDetailView);
            this.tabClnSchdl.Controls.Add(this.btn_RoomChoose);
            this.tabClnSchdl.Controls.Add(this.cal_Cleaning);
            this.tabClnSchdl.Location = new System.Drawing.Point(8, 39);
            this.tabClnSchdl.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabClnSchdl.Name = "tabClnSchdl";
            this.tabClnSchdl.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabClnSchdl.Size = new System.Drawing.Size(1130, 815);
            this.tabClnSchdl.TabIndex = 0;
            this.tabClnSchdl.Text = "Cleaning Schedule";
            this.tabClnSchdl.UseVisualStyleBackColor = true;
            // 
            // data_RoomCleaning
            // 
            this.data_RoomCleaning.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_RoomCleaning.Location = new System.Drawing.Point(12, 50);
            this.data_RoomCleaning.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.data_RoomCleaning.Name = "data_RoomCleaning";
            this.data_RoomCleaning.RowHeadersWidth = 82;
            this.data_RoomCleaning.Size = new System.Drawing.Size(340, 677);
            this.data_RoomCleaning.TabIndex = 11;
            // 
            // pnl_RoomDetailView
            // 
            this.pnl_RoomDetailView.Controls.Add(this.button3);
            this.pnl_RoomDetailView.Controls.Add(this.button2);
            this.pnl_RoomDetailView.Controls.Add(this.button1);
            this.pnl_RoomDetailView.Controls.Add(this.lbl_Condition);
            this.pnl_RoomDetailView.Controls.Add(this.lbl_Availability);
            this.pnl_RoomDetailView.Controls.Add(this.lbl_RoomNum);
            this.pnl_RoomDetailView.Location = new System.Drawing.Point(384, 385);
            this.pnl_RoomDetailView.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnl_RoomDetailView.Name = "pnl_RoomDetailView";
            this.pnl_RoomDetailView.Size = new System.Drawing.Size(728, 410);
            this.pnl_RoomDetailView.TabIndex = 10;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(20, 331);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(238, 56);
            this.button3.TabIndex = 10;
            this.button3.Text = "Report Issue";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(20, 263);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "Mark Dirty";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 196);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "Mark Cleaned";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_Condition
            // 
            this.lbl_Condition.AutoSize = true;
            this.lbl_Condition.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Condition.Location = new System.Drawing.Point(24, 125);
            this.lbl_Condition.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Condition.Name = "lbl_Condition";
            this.lbl_Condition.Size = new System.Drawing.Size(155, 39);
            this.lbl_Condition.TabIndex = 2;
            this.lbl_Condition.Text = "Condition:";
            // 
            // lbl_Availability
            // 
            this.lbl_Availability.AutoSize = true;
            this.lbl_Availability.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Availability.Location = new System.Drawing.Point(24, 71);
            this.lbl_Availability.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Availability.Name = "lbl_Availability";
            this.lbl_Availability.Size = new System.Drawing.Size(174, 39);
            this.lbl_Availability.TabIndex = 1;
            this.lbl_Availability.Text = "Availability:";
            // 
            // lbl_RoomNum
            // 
            this.lbl_RoomNum.AutoSize = true;
            this.lbl_RoomNum.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RoomNum.Location = new System.Drawing.Point(24, 17);
            this.lbl_RoomNum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_RoomNum.Name = "lbl_RoomNum";
            this.lbl_RoomNum.Size = new System.Drawing.Size(225, 39);
            this.lbl_RoomNum.TabIndex = 0;
            this.lbl_RoomNum.Text = "Room Number: ";
            // 
            // btn_RoomChoose
            // 
            this.btn_RoomChoose.BackColor = System.Drawing.SystemColors.Window;
            this.btn_RoomChoose.Location = new System.Drawing.Point(114, 738);
            this.btn_RoomChoose.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_RoomChoose.Name = "btn_RoomChoose";
            this.btn_RoomChoose.Size = new System.Drawing.Size(238, 56);
            this.btn_RoomChoose.TabIndex = 9;
            this.btn_RoomChoose.Text = "Choose Room";
            this.btn_RoomChoose.UseVisualStyleBackColor = false;
            // 
            // cal_Cleaning
            // 
            this.cal_Cleaning.Location = new System.Drawing.Point(384, 50);
            this.cal_Cleaning.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.cal_Cleaning.Name = "cal_Cleaning";
            this.cal_Cleaning.TabIndex = 8;
            // 
            // tabReservations
            // 
            this.tabReservations.Controls.Add(this.dataGridView1);
            this.tabReservations.Controls.Add(this.panel1);
            this.tabReservations.Controls.Add(this.button7);
            this.tabReservations.Controls.Add(this.monthCalendar1);
            this.tabReservations.Location = new System.Drawing.Point(8, 39);
            this.tabReservations.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabReservations.Name = "tabReservations";
            this.tabReservations.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tabReservations.Size = new System.Drawing.Size(1130, 815);
            this.tabReservations.TabIndex = 1;
            this.tabReservations.Text = "Upcoming Reservations";
            this.tabReservations.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(340, 677);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(384, 385);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 410);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 263);
            this.button4.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(238, 56);
            this.button4.TabIndex = 10;
            this.button4.Text = "Report Issue";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(20, 196);
            this.button6.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(238, 56);
            this.button6.TabIndex = 8;
            this.button6.Text = "Mark Prepared";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Condition:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Check-in Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Room Number: ";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Window;
            this.button7.Location = new System.Drawing.Point(114, 738);
            this.button7.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(238, 56);
            this.button7.TabIndex = 13;
            this.button7.Text = "Choose Room";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(384, 50);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(18, 17, 18, 17);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 12;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // HK_Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1168, 887);
            this.Controls.Add(this.tab_Schedule);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.Name = "HK_Schedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HK_RoomCleaningSchedule";
            this.Load += new System.EventHandler(this.HK_RoomCleaningSchedule_Load);
            this.tab_Schedule.ResumeLayout(false);
            this.tabClnSchdl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_RoomCleaning)).EndInit();
            this.pnl_RoomDetailView.ResumeLayout(false);
            this.pnl_RoomDetailView.PerformLayout();
            this.tabReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Schedule;
        private System.Windows.Forms.TabPage tabClnSchdl;
        private System.Windows.Forms.DataGridView data_RoomCleaning;
        private System.Windows.Forms.Panel pnl_RoomDetailView;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_Condition;
        private System.Windows.Forms.Label lbl_Availability;
        private System.Windows.Forms.Label lbl_RoomNum;
        private System.Windows.Forms.Button btn_RoomChoose;
        private System.Windows.Forms.MonthCalendar cal_Cleaning;
        private System.Windows.Forms.TabPage tabReservations;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}