namespace IOOP_Group_Assignment
{
    partial class ManagerPage
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
        //test
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lnklbl_Manage_Account = new System.Windows.Forms.LinkLabel();
            this.lnklbl_Manage_Room = new System.Windows.Forms.LinkLabel();
            this.lnklb_Manage_Housekeeping = new System.Windows.Forms.LinkLabel();
            this.lnklbl_View_Report = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(377, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(113, 33);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Manager";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lnklbl_Manage_Account
            // 
            this.lnklbl_Manage_Account.AutoSize = true;
            this.lnklbl_Manage_Account.Location = new System.Drawing.Point(380, 211);
            this.lnklbl_Manage_Account.Name = "lnklbl_Manage_Account";
            this.lnklbl_Manage_Account.Size = new System.Drawing.Size(94, 13);
            this.lnklbl_Manage_Account.TabIndex = 3;
            this.lnklbl_Manage_Account.TabStop = true;
            this.lnklbl_Manage_Account.Text = "Manage Accounts";
            this.lnklbl_Manage_Account.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_Manage_Account_LinkClicked);
            // 
            // lnklbl_Manage_Room
            // 
            this.lnklbl_Manage_Room.AutoSize = true;
            this.lnklbl_Manage_Room.Location = new System.Drawing.Point(380, 245);
            this.lnklbl_Manage_Room.Name = "lnklbl_Manage_Room";
            this.lnklbl_Manage_Room.Size = new System.Drawing.Size(82, 13);
            this.lnklbl_Manage_Room.TabIndex = 4;
            this.lnklbl_Manage_Room.TabStop = true;
            this.lnklbl_Manage_Room.Text = "Manage Rooms";
            this.lnklbl_Manage_Room.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_Manage_Room_LinkClicked);
            // 
            // lnklb_Manage_Housekeeping
            // 
            this.lnklb_Manage_Housekeeping.AutoSize = true;
            this.lnklb_Manage_Housekeeping.Location = new System.Drawing.Point(380, 284);
            this.lnklb_Manage_Housekeeping.Name = "lnklb_Manage_Housekeeping";
            this.lnklb_Manage_Housekeeping.Size = new System.Drawing.Size(118, 13);
            this.lnklb_Manage_Housekeeping.TabIndex = 5;
            this.lnklb_Manage_Housekeeping.TabStop = true;
            this.lnklb_Manage_Housekeeping.Text = "Manage Housekeeping";
            this.lnklb_Manage_Housekeeping.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklb_Manage_Housekeeping_LinkClicked);
            // 
            // lnklbl_View_Report
            // 
            this.lnklbl_View_Report.AutoSize = true;
            this.lnklbl_View_Report.Location = new System.Drawing.Point(380, 321);
            this.lnklbl_View_Report.Name = "lnklbl_View_Report";
            this.lnklbl_View_Report.Size = new System.Drawing.Size(65, 13);
            this.lnklbl_View_Report.TabIndex = 6;
            this.lnklbl_View_Report.TabStop = true;
            this.lnklbl_View_Report.Text = "View Report";
            this.lnklbl_View_Report.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklbl_View_Report_LinkClicked);
            // 
            // ManagerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.lnklbl_View_Report);
            this.Controls.Add(this.lnklb_Manage_Housekeeping);
            this.Controls.Add(this.lnklbl_Manage_Room);
            this.Controls.Add(this.lnklbl_Manage_Account);
            this.Controls.Add(this.lblTitle);
            this.Name = "ManagerPage";
            this.Text = "GoodStay Hotel";
            this.Load += new System.EventHandler(this.ManagerPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.LinkLabel lnklbl_Manage_Account;
        private System.Windows.Forms.LinkLabel lnklbl_Manage_Room;
        private System.Windows.Forms.LinkLabel lnklb_Manage_Housekeeping;
        private System.Windows.Forms.LinkLabel lnklbl_View_Report;
    }
}