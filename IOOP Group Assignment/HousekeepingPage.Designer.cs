namespace IOOP_Group_Assignment
{
    partial class HousekeepingPage
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
            this.lbl_Username = new System.Windows.Forms.Label();
            this.HousekeepingLabel = new System.Windows.Forms.Label();
            this.btn_ManageSupply = new System.Windows.Forms.Button();
            this.btn_Schedule = new System.Windows.Forms.Button();
            this.btn_Pfp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(72, 320);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(35, 13);
            this.lbl_Username.TabIndex = 20;
            this.lbl_Username.Text = "Name";
            // 
            // HousekeepingLabel
            // 
            this.HousekeepingLabel.AutoSize = true;
            this.HousekeepingLabel.Font = new System.Drawing.Font("Copperplate Gothic Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HousekeepingLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.HousekeepingLabel.Location = new System.Drawing.Point(158, 40);
            this.HousekeepingLabel.Name = "HousekeepingLabel";
            this.HousekeepingLabel.Size = new System.Drawing.Size(254, 35);
            this.HousekeepingLabel.TabIndex = 0;
            this.HousekeepingLabel.Text = "Housekeeping";
            // 
            // btn_ManageSupply
            // 
            this.btn_ManageSupply.AutoSize = true;
            this.btn_ManageSupply.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ManageSupply.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_ManageSupply.FlatAppearance.BorderSize = 0;
            this.btn_ManageSupply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_ManageSupply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_ManageSupply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ManageSupply.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ManageSupply.ForeColor = System.Drawing.Color.White;
            this.btn_ManageSupply.Location = new System.Drawing.Point(190, 189);
            this.btn_ManageSupply.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ManageSupply.Name = "btn_ManageSupply";
            this.btn_ManageSupply.Size = new System.Drawing.Size(186, 32);
            this.btn_ManageSupply.TabIndex = 29;
            this.btn_ManageSupply.Text = "Manage Supplies";
            this.btn_ManageSupply.UseVisualStyleBackColor = false;
            this.btn_ManageSupply.Click += new System.EventHandler(this.btn_ManageSupply_Click);
            // 
            // btn_Schedule
            // 
            this.btn_Schedule.AutoSize = true;
            this.btn_Schedule.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Schedule.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Schedule.FlatAppearance.BorderSize = 0;
            this.btn_Schedule.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Schedule.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Schedule.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Schedule.ForeColor = System.Drawing.Color.White;
            this.btn_Schedule.Location = new System.Drawing.Point(190, 140);
            this.btn_Schedule.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Schedule.Name = "btn_Schedule";
            this.btn_Schedule.Size = new System.Drawing.Size(186, 32);
            this.btn_Schedule.TabIndex = 30;
            this.btn_Schedule.Text = "Schedule";
            this.btn_Schedule.UseVisualStyleBackColor = false;
            this.btn_Schedule.Click += new System.EventHandler(this.btn_Schedule_Click);
            // 
            // btn_Pfp
            // 
            this.btn_Pfp.Image = global::IOOP_Group_Assignment.Properties.Resources.person_110935__2_;
            this.btn_Pfp.Location = new System.Drawing.Point(12, 303);
            this.btn_Pfp.Name = "btn_Pfp";
            this.btn_Pfp.Size = new System.Drawing.Size(49, 46);
            this.btn_Pfp.TabIndex = 19;
            this.btn_Pfp.UseVisualStyleBackColor = true;
            // 
            // HousekeepingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btn_Schedule);
            this.Controls.Add(this.btn_ManageSupply);
            this.Controls.Add(this.HousekeepingLabel);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.btn_Pfp);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "HousekeepingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Housekeeping";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btn_Pfp;
        private System.Windows.Forms.Label HousekeepingLabel;
        private System.Windows.Forms.Button btn_ManageSupply;
        private System.Windows.Forms.Button btn_Schedule;
    }
}

