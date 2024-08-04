using System;

namespace IOOP_Group_Assignment
{
    partial class Customer
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
            this.btn_Rooms = new System.Windows.Forms.Button();
            this.btn_Managereservations = new System.Windows.Forms.Button();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Pfp = new System.Windows.Forms.Button();
            this.btnSend_review = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Rooms
            // 
            this.btn_Rooms.AutoSize = true;
            this.btn_Rooms.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Rooms.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Rooms.FlatAppearance.BorderSize = 0;
            this.btn_Rooms.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Rooms.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Rooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Rooms.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Rooms.ForeColor = System.Drawing.Color.White;
            this.btn_Rooms.Location = new System.Drawing.Point(200, 146);
            this.btn_Rooms.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Rooms.Name = "btn_Rooms";
            this.btn_Rooms.Size = new System.Drawing.Size(186, 32);
            this.btn_Rooms.TabIndex = 38;
            this.btn_Rooms.Text = "Room check in ";
            this.btn_Rooms.UseVisualStyleBackColor = false;
            this.btn_Rooms.Click += new System.EventHandler(this.btn_Rooms_Click);
            // 
            // btn_Managereservations
            // 
            this.btn_Managereservations.AutoSize = true;
            this.btn_Managereservations.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Managereservations.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_Managereservations.FlatAppearance.BorderSize = 0;
            this.btn_Managereservations.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btn_Managereservations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Managereservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Managereservations.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Managereservations.ForeColor = System.Drawing.Color.White;
            this.btn_Managereservations.Location = new System.Drawing.Point(200, 187);
            this.btn_Managereservations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Managereservations.Name = "btn_Managereservations";
            this.btn_Managereservations.Size = new System.Drawing.Size(186, 32);
            this.btn_Managereservations.TabIndex = 37;
            this.btn_Managereservations.Text = "Manage reservations";
            this.btn_Managereservations.UseVisualStyleBackColor = false;
            this.btn_Managereservations.Click += new System.EventHandler(this.btn_Managereservations_Click);
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(66, 329);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(35, 13);
            this.lbl_Username.TabIndex = 35;
            this.lbl_Username.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 37);
            this.label1.TabIndex = 40;
            this.label1.Text = "Customer";
            // 
            // btn_Pfp
            // 
            this.btn_Pfp.Image = global::IOOP_Group_Assignment.Properties.Resources.person_110935__2_;
            this.btn_Pfp.Location = new System.Drawing.Point(6, 312);
            this.btn_Pfp.Name = "btn_Pfp";
            this.btn_Pfp.Size = new System.Drawing.Size(49, 46);
            this.btn_Pfp.TabIndex = 34;
            this.btn_Pfp.UseVisualStyleBackColor = true;
            // 
            // btnSend_review
            // 
            this.btnSend_review.AutoSize = true;
            this.btnSend_review.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSend_review.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnSend_review.FlatAppearance.BorderSize = 0;
            this.btnSend_review.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.btnSend_review.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSend_review.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend_review.Font = new System.Drawing.Font("Calibri", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend_review.ForeColor = System.Drawing.Color.White;
            this.btnSend_review.Location = new System.Drawing.Point(200, 228);
            this.btnSend_review.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend_review.Name = "btnSend_review";
            this.btnSend_review.Size = new System.Drawing.Size(186, 32);
            this.btnSend_review.TabIndex = 41;
            this.btnSend_review.Text = "Send review";
            this.btnSend_review.UseVisualStyleBackColor = false;
            this.btnSend_review.Click += new System.EventHandler(this.btnSend_review_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.btnSend_review);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Rooms);
            this.Controls.Add(this.btn_Managereservations);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.btn_Pfp);
            this.ForeColor = System.Drawing.Color.DarkBlue;
            this.Name = "Customer";
            this.Text = "customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_Sendreview_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btn_Rooms;
        private System.Windows.Forms.Button btn_Managereservations;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Button btn_Pfp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSend_review;
    }
}