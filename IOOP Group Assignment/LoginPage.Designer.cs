namespace IOOP_Group_Assignment
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.HotelTitle = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.UserLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.CustomerRadio = new System.Windows.Forms.RadioButton();
            this.ReceptionistRadio = new System.Windows.Forms.RadioButton();
            this.ManagerRadio = new System.Windows.Forms.RadioButton();
            this.HousekeepingRadio = new System.Windows.Forms.RadioButton();
            this.UserTypes = new System.Windows.Forms.GroupBox();
            this.LoginDetails = new System.Windows.Forms.GroupBox();
            this.PasswordVisibilityButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.LoginPagePrompt = new System.Windows.Forms.Label();
            this.NewUserLinkLabel = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.UserTypes.SuspendLayout();
            this.LoginDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // HotelTitle
            // 
            this.HotelTitle.AutoSize = true;
            this.HotelTitle.Font = new System.Drawing.Font("Copperplate Gothic Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HotelTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.HotelTitle.Location = new System.Drawing.Point(140, 87);
            this.HotelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.HotelTitle.Name = "HotelTitle";
            this.HotelTitle.Size = new System.Drawing.Size(607, 69);
            this.HotelTitle.TabIndex = 0;
            this.HotelTitle.Text = "GoodStay Hotel";
            // 
            // UsernameBox
            // 
            this.UsernameBox.BackColor = System.Drawing.Color.White;
            this.UsernameBox.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameBox.Location = new System.Drawing.Point(30, 37);
            this.UsernameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(229, 24);
            this.UsernameBox.TabIndex = 1;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(27, 19);
            this.UserLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(66, 17);
            this.UserLabel.TabIndex = 3;
            this.UserLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordLabel.Location = new System.Drawing.Point(27, 97);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(61, 17);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.White;
            this.PasswordBox.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(30, 116);
            this.PasswordBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(229, 24);
            this.PasswordBox.TabIndex = 6;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // CustomerRadio
            // 
            this.CustomerRadio.AutoSize = true;
            this.CustomerRadio.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerRadio.Location = new System.Drawing.Point(50, 25);
            this.CustomerRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerRadio.Name = "CustomerRadio";
            this.CustomerRadio.Size = new System.Drawing.Size(80, 21);
            this.CustomerRadio.TabIndex = 7;
            this.CustomerRadio.Text = "Customer";
            this.CustomerRadio.UseVisualStyleBackColor = true;
            this.CustomerRadio.CheckedChanged += new System.EventHandler(this.CustomerRadio_CheckedChanged);
            // 
            // ReceptionistRadio
            // 
            this.ReceptionistRadio.AutoSize = true;
            this.ReceptionistRadio.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionistRadio.Location = new System.Drawing.Point(128, 25);
            this.ReceptionistRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReceptionistRadio.Name = "ReceptionistRadio";
            this.ReceptionistRadio.Size = new System.Drawing.Size(96, 21);
            this.ReceptionistRadio.TabIndex = 8;
            this.ReceptionistRadio.Text = "Receptionist";
            this.ReceptionistRadio.UseVisualStyleBackColor = true;
            this.ReceptionistRadio.CheckedChanged += new System.EventHandler(this.ReceptionistRadio_CheckedChanged);
            // 
            // ManagerRadio
            // 
            this.ManagerRadio.AutoSize = true;
            this.ManagerRadio.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManagerRadio.Location = new System.Drawing.Point(222, 25);
            this.ManagerRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ManagerRadio.Name = "ManagerRadio";
            this.ManagerRadio.Size = new System.Drawing.Size(78, 21);
            this.ManagerRadio.TabIndex = 9;
            this.ManagerRadio.Text = "Manager";
            this.ManagerRadio.UseVisualStyleBackColor = true;
            this.ManagerRadio.CheckedChanged += new System.EventHandler(this.ManagerRadio_CheckedChanged);
            // 
            // HousekeepingRadio
            // 
            this.HousekeepingRadio.AutoSize = true;
            this.HousekeepingRadio.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HousekeepingRadio.Location = new System.Drawing.Point(297, 25);
            this.HousekeepingRadio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.HousekeepingRadio.Name = "HousekeepingRadio";
            this.HousekeepingRadio.Size = new System.Drawing.Size(105, 21);
            this.HousekeepingRadio.TabIndex = 10;
            this.HousekeepingRadio.Text = "Housekeeping";
            this.HousekeepingRadio.UseVisualStyleBackColor = true;
            this.HousekeepingRadio.CheckedChanged += new System.EventHandler(this.HousekeepingRadio_CheckedChanged);
            // 
            // UserTypes
            // 
            this.UserTypes.AutoSize = true;
            this.UserTypes.Controls.Add(this.HousekeepingRadio);
            this.UserTypes.Controls.Add(this.ManagerRadio);
            this.UserTypes.Controls.Add(this.ReceptionistRadio);
            this.UserTypes.Controls.Add(this.CustomerRadio);
            this.UserTypes.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypes.Location = new System.Drawing.Point(212, 347);
            this.UserTypes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserTypes.Name = "UserTypes";
            this.UserTypes.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UserTypes.Size = new System.Drawing.Size(453, 65);
            this.UserTypes.TabIndex = 11;
            this.UserTypes.TabStop = false;
            // 
            // LoginDetails
            // 
            this.LoginDetails.AutoSize = true;
            this.LoginDetails.Controls.Add(this.PasswordVisibilityButton);
            this.LoginDetails.Controls.Add(this.PasswordBox);
            this.LoginDetails.Controls.Add(this.PasswordLabel);
            this.LoginDetails.Controls.Add(this.UserLabel);
            this.LoginDetails.Controls.Add(this.UsernameBox);
            this.LoginDetails.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginDetails.Location = new System.Drawing.Point(281, 167);
            this.LoginDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginDetails.Name = "LoginDetails";
            this.LoginDetails.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginDetails.Size = new System.Drawing.Size(309, 159);
            this.LoginDetails.TabIndex = 12;
            this.LoginDetails.TabStop = false;
            // 
            // PasswordVisibilityButton
            // 
            this.PasswordVisibilityButton.FlatAppearance.BorderSize = 0;
            this.PasswordVisibilityButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordVisibilityButton.Image = global::IOOP_Group_Assignment.Properties.Resources.Eye_Show;
            this.PasswordVisibilityButton.Location = new System.Drawing.Point(263, 119);
            this.PasswordVisibilityButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.PasswordVisibilityButton.Name = "PasswordVisibilityButton";
            this.PasswordVisibilityButton.Size = new System.Drawing.Size(32, 21);
            this.PasswordVisibilityButton.TabIndex = 16;
            this.PasswordVisibilityButton.UseVisualStyleBackColor = true;
            this.PasswordVisibilityButton.Click += new System.EventHandler(this.PasswordVisibilityButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.Location = new System.Drawing.Point(316, 424);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(244, 32);
            this.LoginButton.TabIndex = 13;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = false;
            // 
            // LoginPagePrompt
            // 
            this.LoginPagePrompt.AutoSize = true;
            this.LoginPagePrompt.ForeColor = System.Drawing.Color.IndianRed;
            this.LoginPagePrompt.Location = new System.Drawing.Point(354, 462);
            this.LoginPagePrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoginPagePrompt.Name = "LoginPagePrompt";
            this.LoginPagePrompt.Size = new System.Drawing.Size(169, 13);
            this.LoginPagePrompt.TabIndex = 14;
            this.LoginPagePrompt.Text = "Username or password is incorrect";
            this.LoginPagePrompt.Click += new System.EventHandler(this.LoginPagePrompt_Click);
            // 
            // NewUserLinkLabel
            // 
            this.NewUserLinkLabel.AutoSize = true;
            this.NewUserLinkLabel.Location = new System.Drawing.Point(363, 328);
            this.NewUserLinkLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NewUserLinkLabel.Name = "NewUserLinkLabel";
            this.NewUserLinkLabel.Size = new System.Drawing.Size(142, 13);
            this.NewUserLinkLabel.TabIndex = 15;
            this.NewUserLinkLabel.TabStop = true;
            this.NewUserLinkLabel.Text = "New user? Register account";
            this.NewUserLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NewUserLinkLabel_LinkClicked);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(389, 482);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(92, 13);
            this.linkLabel1.TabIndex = 16;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgot Password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.NewUserLinkLabel);
            this.Controls.Add(this.LoginPagePrompt);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.LoginDetails);
            this.Controls.Add(this.UserTypes);
            this.Controls.Add(this.HotelTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GoodStay Hotel";
            this.UserTypes.ResumeLayout(false);
            this.UserTypes.PerformLayout();
            this.LoginDetails.ResumeLayout(false);
            this.LoginDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HotelTitle;
        private System.Windows.Forms.TextBox UsernameBox;
        private System.Windows.Forms.Label UserLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.RadioButton CustomerRadio;
        private System.Windows.Forms.RadioButton ReceptionistRadio;
        private System.Windows.Forms.RadioButton ManagerRadio;
        private System.Windows.Forms.RadioButton HousekeepingRadio;
        private System.Windows.Forms.GroupBox UserTypes;
        private System.Windows.Forms.GroupBox LoginDetails;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label LoginPagePrompt;
        private System.Windows.Forms.LinkLabel NewUserLinkLabel;
        private System.Windows.Forms.Button PasswordVisibilityButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

