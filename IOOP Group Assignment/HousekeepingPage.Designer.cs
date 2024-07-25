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
            this.SuppliesLabel = new System.Windows.Forms.LinkLabel();
            this.UpcomingLabel = new System.Windows.Forms.LinkLabel();
            this.RoomCleanLabel = new System.Windows.Forms.LinkLabel();
            this.HomeLabel = new System.Windows.Forms.LinkLabel();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.ProfilePictureButton = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // SuppliesLabel
            // 
            this.SuppliesLabel.AutoSize = true;
            this.SuppliesLabel.Location = new System.Drawing.Point(31, 249);
            this.SuppliesLabel.Name = "SuppliesLabel";
            this.SuppliesLabel.Size = new System.Drawing.Size(89, 13);
            this.SuppliesLabel.TabIndex = 24;
            this.SuppliesLabel.TabStop = true;
            this.SuppliesLabel.Text = "Manage Supplies";
            // 
            // UpcomingLabel
            // 
            this.UpcomingLabel.AutoSize = true;
            this.UpcomingLabel.Location = new System.Drawing.Point(31, 223);
            this.UpcomingLabel.Name = "UpcomingLabel";
            this.UpcomingLabel.Size = new System.Drawing.Size(151, 13);
            this.UpcomingLabel.TabIndex = 23;
            this.UpcomingLabel.TabStop = true;
            this.UpcomingLabel.Text = "Upcoming Room Reservations";
            // 
            // RoomCleanLabel
            // 
            this.RoomCleanLabel.AutoSize = true;
            this.RoomCleanLabel.Location = new System.Drawing.Point(31, 198);
            this.RoomCleanLabel.Name = "RoomCleanLabel";
            this.RoomCleanLabel.Size = new System.Drawing.Size(127, 13);
            this.RoomCleanLabel.TabIndex = 22;
            this.RoomCleanLabel.TabStop = true;
            this.RoomCleanLabel.Text = "Room Cleaning Schedule";
            this.RoomCleanLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RoomCleanLabel_LinkClicked);
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Location = new System.Drawing.Point(31, 172);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(35, 13);
            this.HomeLabel.TabIndex = 21;
            this.HomeLabel.TabStop = true;
            this.HomeLabel.Text = "Home";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(72, 29);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(35, 13);
            this.UserNameLabel.TabIndex = 20;
            this.UserNameLabel.Text = "Name";
            // 
            // ProfilePictureButton
            // 
            this.ProfilePictureButton.Image = global::IOOP_Group_Assignment.Properties.Resources.person_110935__2_;
            this.ProfilePictureButton.Location = new System.Drawing.Point(12, 12);
            this.ProfilePictureButton.Name = "ProfilePictureButton";
            this.ProfilePictureButton.Size = new System.Drawing.Size(49, 46);
            this.ProfilePictureButton.TabIndex = 19;
            this.ProfilePictureButton.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.DarkBlue;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(220, 561);
            this.splitter1.TabIndex = 18;
            this.splitter1.TabStop = false;
            // 
            // HousekeepingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.SuppliesLabel);
            this.Controls.Add(this.UpcomingLabel);
            this.Controls.Add(this.RoomCleanLabel);
            this.Controls.Add(this.HomeLabel);
            this.Controls.Add(this.UserNameLabel);
            this.Controls.Add(this.ProfilePictureButton);
            this.Controls.Add(this.splitter1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HousekeepingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoodStay Hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel SuppliesLabel;
        private System.Windows.Forms.LinkLabel UpcomingLabel;
        private System.Windows.Forms.LinkLabel RoomCleanLabel;
        private System.Windows.Forms.LinkLabel HomeLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button ProfilePictureButton;
        private System.Windows.Forms.Splitter splitter1;
    }
}

