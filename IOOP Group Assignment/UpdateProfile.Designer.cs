namespace IOOP_Group_Assignment
{
    partial class UpdateProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_SupplyName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtbox_Username = new System.Windows.Forms.TextBox();
            this.txtbox_Password = new System.Windows.Forms.TextBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.btn_Pfp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "Update Profile";
            // 
            // lbl_SupplyName
            // 
            this.lbl_SupplyName.AutoSize = true;
            this.lbl_SupplyName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_SupplyName.Location = new System.Drawing.Point(13, 70);
            this.lbl_SupplyName.Name = "lbl_SupplyName";
            this.lbl_SupplyName.Size = new System.Drawing.Size(103, 19);
            this.lbl_SupplyName.TabIndex = 27;
            this.lbl_SupplyName.Text = "Profile Picture:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 19);
            this.label3.TabIndex = 30;
            this.label3.Text = "Password:";
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Name.Location = new System.Drawing.Point(133, 116);
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(331, 26);
            this.txtbox_Name.TabIndex = 31;
            // 
            // txtbox_Username
            // 
            this.txtbox_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Username.Location = new System.Drawing.Point(133, 161);
            this.txtbox_Username.Name = "txtbox_Username";
            this.txtbox_Username.Size = new System.Drawing.Size(331, 26);
            this.txtbox_Username.TabIndex = 32;
            // 
            // txtbox_Password
            // 
            this.txtbox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Password.Location = new System.Drawing.Point(133, 211);
            this.txtbox_Password.Name = "txtbox_Password";
            this.txtbox_Password.Size = new System.Drawing.Size(331, 26);
            this.txtbox_Password.TabIndex = 33;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Confirm.Location = new System.Drawing.Point(361, 248);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(119, 29);
            this.btn_Confirm.TabIndex = 55;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = false;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // btn_Pfp
            // 
            this.btn_Pfp.Image = global::IOOP_Group_Assignment.Properties.Resources.person_110935__2_;
            this.btn_Pfp.Location = new System.Drawing.Point(133, 57);
            this.btn_Pfp.Name = "btn_Pfp";
            this.btn_Pfp.Size = new System.Drawing.Size(49, 46);
            this.btn_Pfp.TabIndex = 21;
            this.btn_Pfp.UseVisualStyleBackColor = true;
            this.btn_Pfp.Click += new System.EventHandler(this.btn_Pfp_Click);
            // 
            // UpdateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 281);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.txtbox_Password);
            this.Controls.Add(this.txtbox_Username);
            this.Controls.Add(this.txtbox_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_SupplyName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Pfp);
            this.MaximizeBox = false;
            this.Name = "UpdateProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Profile";
            this.Load += new System.EventHandler(this.UpdateProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Pfp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_SupplyName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.TextBox txtbox_Username;
        private System.Windows.Forms.TextBox txtbox_Password;
        private System.Windows.Forms.Button btn_Confirm;
    }
}