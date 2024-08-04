namespace IOOP_Group_Assignment
{
    partial class Manage_reservations
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reservationIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationMadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGuestsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nightsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.goodStayHotelDatabaseDataSet = new IOOP_Group_Assignment.GoodStayHotelDatabaseDataSet();
            this.reservationsTableAdapter = new IOOP_Group_Assignment.GoodStayHotelDatabaseDataSetTableAdapters.ReservationsTableAdapter();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodStayHotelDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.reservationIDDataGridViewTextBoxColumn,
            this.roomIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.reservationMadeDataGridViewTextBoxColumn,
            this.checkinDateTimeDataGridViewTextBoxColumn,
            this.checkoutDateTimeDataGridViewTextBoxColumn,
            this.totalGuestsDataGridViewTextBoxColumn,
            this.nightsDataGridViewTextBoxColumn,
            this.reservationStatusDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservationsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(755, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            this.reservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID";
            this.reservationIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            this.reservationIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservationIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // roomIDDataGridViewTextBoxColumn
            // 
            this.roomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.HeaderText = "RoomID";
            this.roomIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.roomIDDataGridViewTextBoxColumn.Name = "roomIDDataGridViewTextBoxColumn";
            this.roomIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID";
            this.customerIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            this.customerIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservationMadeDataGridViewTextBoxColumn
            // 
            this.reservationMadeDataGridViewTextBoxColumn.DataPropertyName = "ReservationMade";
            this.reservationMadeDataGridViewTextBoxColumn.HeaderText = "ReservationMade";
            this.reservationMadeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationMadeDataGridViewTextBoxColumn.Name = "reservationMadeDataGridViewTextBoxColumn";
            this.reservationMadeDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkinDateTimeDataGridViewTextBoxColumn
            // 
            this.checkinDateTimeDataGridViewTextBoxColumn.DataPropertyName = "CheckinDateTime";
            this.checkinDateTimeDataGridViewTextBoxColumn.HeaderText = "CheckinDateTime";
            this.checkinDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkinDateTimeDataGridViewTextBoxColumn.Name = "checkinDateTimeDataGridViewTextBoxColumn";
            this.checkinDateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkoutDateTimeDataGridViewTextBoxColumn
            // 
            this.checkoutDateTimeDataGridViewTextBoxColumn.DataPropertyName = "CheckoutDateTime";
            this.checkoutDateTimeDataGridViewTextBoxColumn.HeaderText = "CheckoutDateTime";
            this.checkoutDateTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkoutDateTimeDataGridViewTextBoxColumn.Name = "checkoutDateTimeDataGridViewTextBoxColumn";
            this.checkoutDateTimeDataGridViewTextBoxColumn.Width = 125;
            // 
            // totalGuestsDataGridViewTextBoxColumn
            // 
            this.totalGuestsDataGridViewTextBoxColumn.DataPropertyName = "TotalGuests";
            this.totalGuestsDataGridViewTextBoxColumn.HeaderText = "TotalGuests";
            this.totalGuestsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalGuestsDataGridViewTextBoxColumn.Name = "totalGuestsDataGridViewTextBoxColumn";
            this.totalGuestsDataGridViewTextBoxColumn.Width = 125;
            // 
            // nightsDataGridViewTextBoxColumn
            // 
            this.nightsDataGridViewTextBoxColumn.DataPropertyName = "Nights";
            this.nightsDataGridViewTextBoxColumn.HeaderText = "Nights";
            this.nightsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nightsDataGridViewTextBoxColumn.Name = "nightsDataGridViewTextBoxColumn";
            this.nightsDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservationStatusDataGridViewTextBoxColumn
            // 
            this.reservationStatusDataGridViewTextBoxColumn.DataPropertyName = "ReservationStatus";
            this.reservationStatusDataGridViewTextBoxColumn.HeaderText = "ReservationStatus";
            this.reservationStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reservationStatusDataGridViewTextBoxColumn.Name = "reservationStatusDataGridViewTextBoxColumn";
            this.reservationStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            this.paymentStatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance";
            this.balanceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            this.balanceDataGridViewTextBoxColumn.Width = 125;
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            this.notesDataGridViewTextBoxColumn.Width = 125;
            // 
            // reservationsBindingSource
            // 
            this.reservationsBindingSource.DataMember = "Reservations";
            this.reservationsBindingSource.DataSource = this.goodStayHotelDatabaseDataSet;
            // 
            // goodStayHotelDatabaseDataSet
            // 
            this.goodStayHotelDatabaseDataSet.DataSetName = "GoodStayHotelDatabaseDataSet";
            this.goodStayHotelDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservationsTableAdapter
            // 
            this.reservationsTableAdapter.ClearBeforeFill = true;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSaveChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.White;
            this.btnSaveChanges.Location = new System.Drawing.Point(610, 382);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(157, 50);
            this.btnSaveChanges.TabIndex = 1;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = false;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // Manage_reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 444);
            this.Controls.Add(this.btnSaveChanges);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manage_reservations";
            this.Text = "Manage reservations";
            this.Load += new System.EventHandler(this.Manage_reservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.goodStayHotelDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private GoodStayHotelDatabaseDataSet goodStayHotelDatabaseDataSet;
        private System.Windows.Forms.BindingSource reservationsBindingSource;
        private GoodStayHotelDatabaseDataSetTableAdapters.ReservationsTableAdapter reservationsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationMadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGuestsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nightsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservationStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnSaveChanges;
    }
}