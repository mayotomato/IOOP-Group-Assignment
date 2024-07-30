namespace IOOP_Group_Assignment
{
    partial class ManageAccountsForm
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
            this.tabcntrl_Manage_Accounts = new System.Windows.Forms.TabControl();
            this.Add = new System.Windows.Forms.TabPage();
            this.txtbox_Password = new System.Windows.Forms.TextBox();
            this.txtbox_Username = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_User_Type = new System.Windows.Forms.Label();
            this.datagrid_Add = new System.Windows.Forms.DataGridView();
            this.cmbbx_User_Type = new System.Windows.Forms.ComboBox();
            this.btn_Add_User = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.TabPage();
            this.txtbox_Edit_Password = new System.Windows.Forms.TextBox();
            this.txtbox_Edit_Username = new System.Windows.Forms.TextBox();
            this.lbl_Edit_Password = new System.Windows.Forms.Label();
            this.lbl_Edit_Username = new System.Windows.Forms.Label();
            this.lbl_Edit_User_Type = new System.Windows.Forms.Label();
            this.cmbbx_Edit_User_Type = new System.Windows.Forms.ComboBox();
            this.btn_Edit_User = new System.Windows.Forms.Button();
            this.datagrid_Edit = new System.Windows.Forms.DataGridView();
            this.tabcntrl_Manage_Accounts.SuspendLayout();
            this.Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Add)).BeginInit();
            this.Edit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Edit)).BeginInit();
            this.SuspendLayout();
            // 
            // tabcntrl_Manage_Accounts
            // 
            this.tabcntrl_Manage_Accounts.Controls.Add(this.Add);
            this.tabcntrl_Manage_Accounts.Controls.Add(this.Edit);
            this.tabcntrl_Manage_Accounts.Location = new System.Drawing.Point(165, 60);
            this.tabcntrl_Manage_Accounts.Name = "tabcntrl_Manage_Accounts";
            this.tabcntrl_Manage_Accounts.SelectedIndex = 0;
            this.tabcntrl_Manage_Accounts.Size = new System.Drawing.Size(555, 441);
            this.tabcntrl_Manage_Accounts.TabIndex = 1;
            // 
            // Add
            // 
            this.Add.Controls.Add(this.txtbox_Password);
            this.Add.Controls.Add(this.txtbox_Username);
            this.Add.Controls.Add(this.lbl_Password);
            this.Add.Controls.Add(this.lbl_Username);
            this.Add.Controls.Add(this.lbl_User_Type);
            this.Add.Controls.Add(this.datagrid_Add);
            this.Add.Controls.Add(this.cmbbx_User_Type);
            this.Add.Controls.Add(this.btn_Add_User);
            this.Add.Location = new System.Drawing.Point(4, 22);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(3);
            this.Add.Size = new System.Drawing.Size(547, 415);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add User";
            this.Add.UseVisualStyleBackColor = true;
            // 
            // txtbox_Password
            // 
            this.txtbox_Password.Location = new System.Drawing.Point(142, 296);
            this.txtbox_Password.Name = "txtbox_Password";
            this.txtbox_Password.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Password.TabIndex = 10;
            this.txtbox_Password.UseSystemPasswordChar = true;
            // 
            // txtbox_Username
            // 
            this.txtbox_Username.Location = new System.Drawing.Point(142, 252);
            this.txtbox_Username.Name = "txtbox_Username";
            this.txtbox_Username.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Username.TabIndex = 9;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(63, 299);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Password.TabIndex = 8;
            this.lbl_Password.Text = "Password:";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(63, 255);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(58, 13);
            this.lbl_Username.TabIndex = 7;
            this.lbl_Username.Text = "Username:";
            // 
            // lbl_User_Type
            // 
            this.lbl_User_Type.AutoSize = true;
            this.lbl_User_Type.Location = new System.Drawing.Point(63, 212);
            this.lbl_User_Type.Name = "lbl_User_Type";
            this.lbl_User_Type.Size = new System.Drawing.Size(59, 13);
            this.lbl_User_Type.TabIndex = 6;
            this.lbl_User_Type.Text = "User Type:";
            // 
            // datagrid_Add
            // 
            this.datagrid_Add.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Add.Location = new System.Drawing.Point(66, 29);
            this.datagrid_Add.Name = "datagrid_Add";
            this.datagrid_Add.Size = new System.Drawing.Size(425, 149);
            this.datagrid_Add.TabIndex = 5;
            // 
            // cmbbx_User_Type
            // 
            this.cmbbx_User_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_User_Type.FormattingEnabled = true;
            this.cmbbx_User_Type.Items.AddRange(new object[] {
            "bing",
            "bong",
            "wa",
            "we"});
            this.cmbbx_User_Type.Location = new System.Drawing.Point(142, 209);
            this.cmbbx_User_Type.Name = "cmbbx_User_Type";
            this.cmbbx_User_Type.Size = new System.Drawing.Size(121, 21);
            this.cmbbx_User_Type.TabIndex = 1;
            // 
            // btn_Add_User
            // 
            this.btn_Add_User.Location = new System.Drawing.Point(425, 343);
            this.btn_Add_User.Name = "btn_Add_User";
            this.btn_Add_User.Size = new System.Drawing.Size(75, 23);
            this.btn_Add_User.TabIndex = 0;
            this.btn_Add_User.Text = "Confirm";
            this.btn_Add_User.UseVisualStyleBackColor = true;
            this.btn_Add_User.Click += new System.EventHandler(this.btn_Add_User_Click);
            // 
            // Edit
            // 
            this.Edit.Controls.Add(this.txtbox_Edit_Password);
            this.Edit.Controls.Add(this.txtbox_Edit_Username);
            this.Edit.Controls.Add(this.lbl_Edit_Password);
            this.Edit.Controls.Add(this.lbl_Edit_Username);
            this.Edit.Controls.Add(this.lbl_Edit_User_Type);
            this.Edit.Controls.Add(this.cmbbx_Edit_User_Type);
            this.Edit.Controls.Add(this.btn_Edit_User);
            this.Edit.Controls.Add(this.datagrid_Edit);
            this.Edit.Location = new System.Drawing.Point(4, 22);
            this.Edit.Name = "Edit";
            this.Edit.Padding = new System.Windows.Forms.Padding(3);
            this.Edit.Size = new System.Drawing.Size(547, 415);
            this.Edit.TabIndex = 1;
            this.Edit.Text = "Edit User";
            this.Edit.UseVisualStyleBackColor = true;
            // 
            // txtbox_Edit_Password
            // 
            this.txtbox_Edit_Password.Location = new System.Drawing.Point(151, 303);
            this.txtbox_Edit_Password.Name = "txtbox_Edit_Password";
            this.txtbox_Edit_Password.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Edit_Password.TabIndex = 16;
            // 
            // txtbox_Edit_Username
            // 
            this.txtbox_Edit_Username.Location = new System.Drawing.Point(151, 259);
            this.txtbox_Edit_Username.Name = "txtbox_Edit_Username";
            this.txtbox_Edit_Username.Size = new System.Drawing.Size(100, 20);
            this.txtbox_Edit_Username.TabIndex = 15;
            // 
            // lbl_Edit_Password
            // 
            this.lbl_Edit_Password.AutoSize = true;
            this.lbl_Edit_Password.Location = new System.Drawing.Point(72, 306);
            this.lbl_Edit_Password.Name = "lbl_Edit_Password";
            this.lbl_Edit_Password.Size = new System.Drawing.Size(56, 13);
            this.lbl_Edit_Password.TabIndex = 14;
            this.lbl_Edit_Password.Text = "Password:";
            // 
            // lbl_Edit_Username
            // 
            this.lbl_Edit_Username.AutoSize = true;
            this.lbl_Edit_Username.Location = new System.Drawing.Point(72, 262);
            this.lbl_Edit_Username.Name = "lbl_Edit_Username";
            this.lbl_Edit_Username.Size = new System.Drawing.Size(58, 13);
            this.lbl_Edit_Username.TabIndex = 13;
            this.lbl_Edit_Username.Text = "Username:";
            // 
            // lbl_Edit_User_Type
            // 
            this.lbl_Edit_User_Type.AutoSize = true;
            this.lbl_Edit_User_Type.Location = new System.Drawing.Point(72, 219);
            this.lbl_Edit_User_Type.Name = "lbl_Edit_User_Type";
            this.lbl_Edit_User_Type.Size = new System.Drawing.Size(59, 13);
            this.lbl_Edit_User_Type.TabIndex = 12;
            this.lbl_Edit_User_Type.Text = "User Type:";
            // 
            // cmbbx_Edit_User_Type
            // 
            this.cmbbx_Edit_User_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbbx_Edit_User_Type.FormattingEnabled = true;
            this.cmbbx_Edit_User_Type.Items.AddRange(new object[] {
            "bing",
            "bong",
            "wa",
            "we"});
            this.cmbbx_Edit_User_Type.Location = new System.Drawing.Point(151, 216);
            this.cmbbx_Edit_User_Type.Name = "cmbbx_Edit_User_Type";
            this.cmbbx_Edit_User_Type.Size = new System.Drawing.Size(121, 21);
            this.cmbbx_Edit_User_Type.TabIndex = 11;
            // 
            // btn_Edit_User
            // 
            this.btn_Edit_User.Location = new System.Drawing.Point(432, 360);
            this.btn_Edit_User.Name = "btn_Edit_User";
            this.btn_Edit_User.Size = new System.Drawing.Size(75, 23);
            this.btn_Edit_User.TabIndex = 7;
            this.btn_Edit_User.Text = "Confirm";
            this.btn_Edit_User.UseVisualStyleBackColor = true;
            // 
            // datagrid_Edit
            // 
            this.datagrid_Edit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Edit.Location = new System.Drawing.Point(52, 39);
            this.datagrid_Edit.Name = "datagrid_Edit";
            this.datagrid_Edit.Size = new System.Drawing.Size(425, 149);
            this.datagrid_Edit.TabIndex = 6;
            // 
            // ManageAccountsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tabcntrl_Manage_Accounts);
            this.Name = "ManageAccountsForm";
            this.Text = "Manage Accounts";
            this.tabcntrl_Manage_Accounts.ResumeLayout(false);
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Add)).EndInit();
            this.Edit.ResumeLayout(false);
            this.Edit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Edit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabcntrl_Manage_Accounts;
        private System.Windows.Forms.TabPage Add;
        private System.Windows.Forms.TextBox txtbox_Password;
        private System.Windows.Forms.TextBox txtbox_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_User_Type;
        private System.Windows.Forms.DataGridView datagrid_Add;
        private System.Windows.Forms.ComboBox cmbbx_User_Type;
        private System.Windows.Forms.Button btn_Add_User;
        private System.Windows.Forms.TabPage Edit;
        private System.Windows.Forms.TextBox txtbox_Edit_Password;
        private System.Windows.Forms.TextBox txtbox_Edit_Username;
        private System.Windows.Forms.Label lbl_Edit_Password;
        private System.Windows.Forms.Label lbl_Edit_Username;
        private System.Windows.Forms.Label lbl_Edit_User_Type;
        private System.Windows.Forms.ComboBox cmbbx_Edit_User_Type;
        private System.Windows.Forms.Button btn_Edit_User;
        private System.Windows.Forms.DataGridView datagrid_Edit;
    }
}