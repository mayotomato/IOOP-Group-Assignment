namespace IOOP_Group_Assignment
{
    partial class ManageHousekeepingForm
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
            this.pnl_Manage_Housekeeping = new System.Windows.Forms.Panel();
            this.btn_Assign = new System.Windows.Forms.Button();
            this.lbl_Maintenance_Date = new System.Windows.Forms.Label();
            this.timebox_Maintenance_Date = new System.Windows.Forms.DateTimePicker();
            this.lbl_Assign_Room = new System.Windows.Forms.Label();
            this.tmp_Arrow = new System.Windows.Forms.Label();
            this.lbl_Assign_Worker = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pnl_Manage_Housekeeping.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_Manage_Housekeeping
            // 
            this.pnl_Manage_Housekeeping.Controls.Add(this.btn_Assign);
            this.pnl_Manage_Housekeeping.Controls.Add(this.lbl_Maintenance_Date);
            this.pnl_Manage_Housekeeping.Controls.Add(this.timebox_Maintenance_Date);
            this.pnl_Manage_Housekeeping.Controls.Add(this.lbl_Assign_Room);
            this.pnl_Manage_Housekeeping.Controls.Add(this.tmp_Arrow);
            this.pnl_Manage_Housekeeping.Controls.Add(this.lbl_Assign_Worker);
            this.pnl_Manage_Housekeeping.Controls.Add(this.dataGridView2);
            this.pnl_Manage_Housekeeping.Controls.Add(this.dataGridView1);
            this.pnl_Manage_Housekeeping.Location = new System.Drawing.Point(12, 12);
            this.pnl_Manage_Housekeeping.Name = "pnl_Manage_Housekeeping";
            this.pnl_Manage_Housekeeping.Size = new System.Drawing.Size(615, 487);
            this.pnl_Manage_Housekeeping.TabIndex = 11;
            // 
            // btn_Assign
            // 
            this.btn_Assign.Location = new System.Drawing.Point(506, 421);
            this.btn_Assign.Name = "btn_Assign";
            this.btn_Assign.Size = new System.Drawing.Size(75, 23);
            this.btn_Assign.TabIndex = 7;
            this.btn_Assign.Text = "Assign";
            this.btn_Assign.UseVisualStyleBackColor = true;
            // 
            // lbl_Maintenance_Date
            // 
            this.lbl_Maintenance_Date.AutoSize = true;
            this.lbl_Maintenance_Date.Location = new System.Drawing.Point(33, 251);
            this.lbl_Maintenance_Date.Name = "lbl_Maintenance_Date";
            this.lbl_Maintenance_Date.Size = new System.Drawing.Size(98, 13);
            this.lbl_Maintenance_Date.TabIndex = 6;
            this.lbl_Maintenance_Date.Text = "Maintenance Date:";
            // 
            // timebox_Maintenance_Date
            // 
            this.timebox_Maintenance_Date.Location = new System.Drawing.Point(149, 245);
            this.timebox_Maintenance_Date.Name = "timebox_Maintenance_Date";
            this.timebox_Maintenance_Date.Size = new System.Drawing.Size(200, 20);
            this.timebox_Maintenance_Date.TabIndex = 5;
            // 
            // lbl_Assign_Room
            // 
            this.lbl_Assign_Room.AutoSize = true;
            this.lbl_Assign_Room.Location = new System.Drawing.Point(359, 32);
            this.lbl_Assign_Room.Name = "lbl_Assign_Room";
            this.lbl_Assign_Room.Size = new System.Drawing.Size(54, 13);
            this.lbl_Assign_Room.TabIndex = 4;
            this.lbl_Assign_Room.Text = "To Room:";
            // 
            // tmp_Arrow
            // 
            this.tmp_Arrow.AutoSize = true;
            this.tmp_Arrow.Location = new System.Drawing.Point(291, 128);
            this.tmp_Arrow.Name = "tmp_Arrow";
            this.tmp_Arrow.Size = new System.Drawing.Size(22, 13);
            this.tmp_Arrow.TabIndex = 3;
            this.tmp_Arrow.Text = "--->";
            // 
            // lbl_Assign_Worker
            // 
            this.lbl_Assign_Worker.AutoSize = true;
            this.lbl_Assign_Worker.Location = new System.Drawing.Point(30, 32);
            this.lbl_Assign_Worker.Name = "lbl_Assign_Worker";
            this.lbl_Assign_Worker.Size = new System.Drawing.Size(79, 13);
            this.lbl_Assign_Worker.TabIndex = 2;
            this.lbl_Assign_Worker.Text = "Assign Worker:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(362, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(219, 151);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(219, 151);
            this.dataGridView1.TabIndex = 0;
            // 
            // ManageHousekeepingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 509);
            this.Controls.Add(this.pnl_Manage_Housekeeping);
            this.Name = "ManageHousekeepingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Housekeeping";
            this.pnl_Manage_Housekeeping.ResumeLayout(false);
            this.pnl_Manage_Housekeeping.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Manage_Housekeeping;
        private System.Windows.Forms.Button btn_Assign;
        private System.Windows.Forms.Label lbl_Maintenance_Date;
        private System.Windows.Forms.DateTimePicker timebox_Maintenance_Date;
        private System.Windows.Forms.Label lbl_Assign_Room;
        private System.Windows.Forms.Label tmp_Arrow;
        private System.Windows.Forms.Label lbl_Assign_Worker;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}