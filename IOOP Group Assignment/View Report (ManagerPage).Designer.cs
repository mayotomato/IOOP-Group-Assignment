namespace IOOP_Group_Assignment
{
    partial class ViewReportForm
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
            this.pnl_Report = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.pnl_Report.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Report
            // 
            this.pnl_Report.Controls.Add(this.button2);
            this.pnl_Report.Location = new System.Drawing.Point(135, 37);
            this.pnl_Report.Name = "pnl_Report";
            this.pnl_Report.Size = new System.Drawing.Size(615, 487);
            this.pnl_Report.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(219, 137);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // ViewReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pnl_Report);
            this.Name = "ViewReportForm";
            this.Text = "View Report";
            this.pnl_Report.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Report;
        private System.Windows.Forms.Button button2;
    }
}