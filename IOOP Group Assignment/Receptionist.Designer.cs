namespace IOOP_Group_Assignment
{
    partial class Receptionist
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
            this.manage_acc_panel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_acc_link = new System.Windows.Forms.LinkLabel();
            this.search_res_link = new System.Windows.Forms.LinkLabel();
            this.checkin_link = new System.Windows.Forms.LinkLabel();
            this.checkout_link = new System.Windows.Forms.LinkLabel();
            this.ReceptionistLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.searchres_panel = new System.Windows.Forms.Panel();
            this.RoomIdTextBox = new System.Windows.Forms.TextBox();
            this.CheckOutLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.booking_display = new System.Windows.Forms.ListBox();
            this.searchres_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fullnameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.SubmitRegisterButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.check_out_panel = new System.Windows.Forms.Panel();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkout_button = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.manage_acc_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.searchres_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.check_out_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // manage_acc_panel
            // 
            this.manage_acc_panel.Controls.Add(this.flowLayoutPanel2);
            this.manage_acc_panel.Location = new System.Drawing.Point(206, 2);
            this.manage_acc_panel.Name = "manage_acc_panel";
            this.manage_acc_panel.Size = new System.Drawing.Size(592, 445);
            this.manage_acc_panel.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(8, 8);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Controls.Add(this.ReceptionistLabel);
            this.panel1.Controls.Add(this.checkout_link);
            this.panel1.Controls.Add(this.checkin_link);
            this.panel1.Controls.Add(this.search_res_link);
            this.panel1.Controls.Add(this.m_acc_link);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 444);
            this.panel1.TabIndex = 1;
            // 
            // m_acc_link
            // 
            this.m_acc_link.AutoSize = true;
            this.m_acc_link.LinkColor = System.Drawing.Color.White;
            this.m_acc_link.Location = new System.Drawing.Point(48, 148);
            this.m_acc_link.Name = "m_acc_link";
            this.m_acc_link.Size = new System.Drawing.Size(89, 13);
            this.m_acc_link.TabIndex = 3;
            this.m_acc_link.TabStop = true;
            this.m_acc_link.Text = "Manage Account";
            // 
            // search_res_link
            // 
            this.search_res_link.AutoSize = true;
            this.search_res_link.LinkColor = System.Drawing.Color.White;
            this.search_res_link.Location = new System.Drawing.Point(48, 188);
            this.search_res_link.Name = "search_res_link";
            this.search_res_link.Size = new System.Drawing.Size(106, 13);
            this.search_res_link.TabIndex = 4;
            this.search_res_link.TabStop = true;
            this.search_res_link.Text = "Search Reservations";
            this.search_res_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // checkin_link
            // 
            this.checkin_link.AutoSize = true;
            this.checkin_link.LinkColor = System.Drawing.Color.White;
            this.checkin_link.Location = new System.Drawing.Point(48, 225);
            this.checkin_link.Name = "checkin_link";
            this.checkin_link.Size = new System.Drawing.Size(97, 13);
            this.checkin_link.TabIndex = 5;
            this.checkin_link.TabStop = true;
            this.checkin_link.Text = "Check In Customer";
            // 
            // checkout_link
            // 
            this.checkout_link.AutoSize = true;
            this.checkout_link.LinkColor = System.Drawing.Color.White;
            this.checkout_link.Location = new System.Drawing.Point(48, 270);
            this.checkout_link.Name = "checkout_link";
            this.checkout_link.Size = new System.Drawing.Size(105, 13);
            this.checkout_link.TabIndex = 6;
            this.checkout_link.TabStop = true;
            this.checkout_link.Text = "Check Out Customer";
            // 
            // ReceptionistLabel
            // 
            this.ReceptionistLabel.AutoSize = true;
            this.ReceptionistLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceptionistLabel.ForeColor = System.Drawing.Color.White;
            this.ReceptionistLabel.Location = new System.Drawing.Point(2, 30);
            this.ReceptionistLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ReceptionistLabel.Name = "ReceptionistLabel";
            this.ReceptionistLabel.Size = new System.Drawing.Size(203, 37);
            this.ReceptionistLabel.TabIndex = 7;
            this.ReceptionistLabel.Text = "Receptionist";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(48, 305);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(74, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Update Profile";
            // 
            // searchres_panel
            // 
            this.searchres_panel.Controls.Add(this.check_out_panel);
            this.searchres_panel.Controls.Add(this.panel2);
            this.searchres_panel.Controls.Add(this.searchres_button);
            this.searchres_panel.Controls.Add(this.booking_display);
            this.searchres_panel.Controls.Add(this.label1);
            this.searchres_panel.Controls.Add(this.RoomIdTextBox);
            this.searchres_panel.Controls.Add(this.CheckOutLabel);
            this.searchres_panel.Location = new System.Drawing.Point(206, 2);
            this.searchres_panel.Name = "searchres_panel";
            this.searchres_panel.Size = new System.Drawing.Size(592, 445);
            this.searchres_panel.TabIndex = 1;
            this.searchres_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.searchres_panel_Paint);
            // 
            // RoomIdTextBox
            // 
            this.RoomIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomIdTextBox.Location = new System.Drawing.Point(156, 107);
            this.RoomIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.RoomIdTextBox.Multiline = true;
            this.RoomIdTextBox.Name = "RoomIdTextBox";
            this.RoomIdTextBox.Size = new System.Drawing.Size(389, 25);
            this.RoomIdTextBox.TabIndex = 12;
            // 
            // CheckOutLabel
            // 
            this.CheckOutLabel.AutoSize = true;
            this.CheckOutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutLabel.ForeColor = System.Drawing.Color.Navy;
            this.CheckOutLabel.Location = new System.Drawing.Point(24, 110);
            this.CheckOutLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CheckOutLabel.Name = "CheckOutLabel";
            this.CheckOutLabel.Size = new System.Drawing.Size(128, 20);
            this.CheckOutLabel.TabIndex = 11;
            this.CheckOutLabel.Text = "Room Name/Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(177, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(233, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search Reservations";
            // 
            // booking_display
            // 
            this.booking_display.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.booking_display.FormattingEnabled = true;
            this.booking_display.ItemHeight = 16;
            this.booking_display.Location = new System.Drawing.Point(37, 226);
            this.booking_display.Margin = new System.Windows.Forms.Padding(2);
            this.booking_display.Name = "booking_display";
            this.booking_display.Size = new System.Drawing.Size(516, 164);
            this.booking_display.TabIndex = 16;
            // 
            // searchres_button
            // 
            this.searchres_button.BackColor = System.Drawing.Color.Navy;
            this.searchres_button.ForeColor = System.Drawing.Color.White;
            this.searchres_button.Location = new System.Drawing.Point(140, 153);
            this.searchres_button.Name = "searchres_button";
            this.searchres_button.Size = new System.Drawing.Size(306, 49);
            this.searchres_button.TabIndex = 17;
            this.searchres_button.Text = "Search for Reservation ";
            this.searchres_button.UseVisualStyleBackColor = false;
            this.searchres_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.roomComboBox);
            this.panel2.Controls.Add(this.SubmitRegisterButton);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.fullnameTextBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.passwordTextBox);
            this.panel2.Controls.Add(this.FirstNameLabel);
            this.panel2.Controls.Add(this.usernameTextBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(592, 445);
            this.panel2.TabIndex = 18;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(139, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(307, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Check In Customer";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.Navy;
            this.FirstNameLabel.Location = new System.Drawing.Point(49, 99);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(91, 20);
            this.FirstNameLabel.TabIndex = 10;
            this.FirstNameLabel.Text = "Username";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.Color.Navy;
            this.usernameTextBox.Location = new System.Drawing.Point(196, 95);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.usernameTextBox.Multiline = true;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(298, 24);
            this.usernameTextBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(49, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Password";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.Navy;
            this.passwordTextBox.Location = new System.Drawing.Point(196, 149);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(298, 24);
            this.passwordTextBox.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(49, 211);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Fullname";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fullnameTextBox
            // 
            this.fullnameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameTextBox.ForeColor = System.Drawing.Color.Navy;
            this.fullnameTextBox.Location = new System.Drawing.Point(196, 207);
            this.fullnameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fullnameTextBox.Multiline = true;
            this.fullnameTextBox.Name = "fullnameTextBox";
            this.fullnameTextBox.Size = new System.Drawing.Size(298, 24);
            this.fullnameTextBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Navy;
            this.label5.Location = new System.Drawing.Point(49, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Room Type";
            // 
            // roomComboBox
            // 
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.ItemHeight = 13;
            this.roomComboBox.Items.AddRange(new object[] {
            "Cutsomer"});
            this.roomComboBox.Location = new System.Drawing.Point(195, 276);
            this.roomComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(298, 21);
            this.roomComboBox.TabIndex = 18;
            // 
            // SubmitRegisterButton
            // 
            this.SubmitRegisterButton.BackColor = System.Drawing.Color.Navy;
            this.SubmitRegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitRegisterButton.ForeColor = System.Drawing.Color.White;
            this.SubmitRegisterButton.Location = new System.Drawing.Point(80, 385);
            this.SubmitRegisterButton.Margin = new System.Windows.Forms.Padding(2);
            this.SubmitRegisterButton.Name = "SubmitRegisterButton";
            this.SubmitRegisterButton.Size = new System.Drawing.Size(403, 38);
            this.SubmitRegisterButton.TabIndex = 19;
            this.SubmitRegisterButton.Text = "Check In";
            this.SubmitRegisterButton.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Navy;
            this.label6.Location = new System.Drawing.Point(49, 338);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Check In Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 338);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // check_out_panel
            // 
            this.check_out_panel.Controls.Add(this.dateTimePicker2);
            this.check_out_panel.Controls.Add(this.label7);
            this.check_out_panel.Controls.Add(this.comboBox1);
            this.check_out_panel.Controls.Add(this.checkout_button);
            this.check_out_panel.Controls.Add(this.label8);
            this.check_out_panel.Controls.Add(this.label9);
            this.check_out_panel.Controls.Add(this.textBox1);
            this.check_out_panel.Controls.Add(this.label10);
            this.check_out_panel.Controls.Add(this.textBox2);
            this.check_out_panel.Controls.Add(this.label11);
            this.check_out_panel.Controls.Add(this.textBox3);
            this.check_out_panel.Controls.Add(this.label12);
            this.check_out_panel.Location = new System.Drawing.Point(3, 1);
            this.check_out_panel.Name = "check_out_panel";
            this.check_out_panel.Size = new System.Drawing.Size(592, 445);
            this.check_out_panel.TabIndex = 22;
            this.check_out_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.check_out_panel_Paint);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(230, 337);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(241, 20);
            this.dateTimePicker2.TabIndex = 33;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Navy;
            this.label7.Location = new System.Drawing.Point(74, 337);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Check Out Date";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Items.AddRange(new object[] {
            "Cutsomer"});
            this.comboBox1.Location = new System.Drawing.Point(220, 275);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(298, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // checkout_button
            // 
            this.checkout_button.BackColor = System.Drawing.Color.Navy;
            this.checkout_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkout_button.ForeColor = System.Drawing.Color.White;
            this.checkout_button.Location = new System.Drawing.Point(105, 384);
            this.checkout_button.Margin = new System.Windows.Forms.Padding(2);
            this.checkout_button.Name = "checkout_button";
            this.checkout_button.Size = new System.Drawing.Size(403, 38);
            this.checkout_button.TabIndex = 31;
            this.checkout_button.Text = "Check Out Customer";
            this.checkout_button.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Navy;
            this.label8.Location = new System.Drawing.Point(74, 273);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 29;
            this.label8.Text = "Room Type";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Navy;
            this.label9.Location = new System.Drawing.Point(74, 210);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 20);
            this.label9.TabIndex = 27;
            this.label9.Text = "Fullname";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Navy;
            this.textBox1.Location = new System.Drawing.Point(221, 206);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(298, 24);
            this.textBox1.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Navy;
            this.label10.Location = new System.Drawing.Point(74, 152);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 20);
            this.label10.TabIndex = 25;
            this.label10.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Navy;
            this.textBox2.Location = new System.Drawing.Point(221, 148);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(298, 24);
            this.textBox2.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Navy;
            this.label11.Location = new System.Drawing.Point(74, 98);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Username";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Navy;
            this.textBox3.Location = new System.Drawing.Point(221, 94);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(298, 24);
            this.textBox3.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Navy;
            this.label12.Location = new System.Drawing.Point(149, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(334, 37);
            this.label12.TabIndex = 22;
            this.label12.Text = "Check Out Customer";
            // 
            // Receptionist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchres_panel);
            this.Controls.Add(this.manage_acc_panel);
            this.Name = "Receptionist";
            this.Text = "Receptionist";
            this.manage_acc_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.searchres_panel.ResumeLayout(false);
            this.searchres_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.check_out_panel.ResumeLayout(false);
            this.check_out_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel manage_acc_panel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel checkout_link;
        private System.Windows.Forms.LinkLabel checkin_link;
        private System.Windows.Forms.LinkLabel search_res_link;
        private System.Windows.Forms.LinkLabel m_acc_link;
        private System.Windows.Forms.Label ReceptionistLabel;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel searchres_panel;
        private System.Windows.Forms.TextBox RoomIdTextBox;
        private System.Windows.Forms.Label CheckOutLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchres_button;
        private System.Windows.Forms.ListBox booking_display;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fullnameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox roomComboBox;
        private System.Windows.Forms.Button SubmitRegisterButton;
        private System.Windows.Forms.Panel check_out_panel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button checkout_button;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label12;
    }
}