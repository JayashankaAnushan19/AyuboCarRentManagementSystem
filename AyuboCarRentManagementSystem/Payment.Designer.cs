namespace AyuboCarRentManagementSystem
{
    partial class FrmPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPayment));
            this.lblPackageId = new System.Windows.Forms.Label();
            this.lblCustomerNIC = new System.Windows.Forms.Label();
            this.lblRentedDate = new System.Windows.Forms.Label();
            this.lblReturnedDate = new System.Windows.Forms.Label();
            this.txtReservationID = new System.Windows.Forms.TextBox();
            this.txtCustomerNIC = new System.Windows.Forms.TextBox();
            this.lblRentedTime = new System.Windows.Forms.Label();
            this.lblReturnedTime = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateRented = new System.Windows.Forms.DateTimePicker();
            this.dateReturned = new System.Windows.Forms.DateTimePicker();
            this.btnShow = new System.Windows.Forms.Button();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblStartKMReading = new System.Windows.Forms.Label();
            this.lblEndKMReading = new System.Windows.Forms.Label();
            this.txtStartKMReading = new System.Windows.Forms.TextBox();
            this.txtEndKMReading = new System.Windows.Forms.TextBox();
            this.lblBasicCharge = new System.Windows.Forms.Label();
            this.lblOverNightCharge = new System.Windows.Forms.Label();
            this.lblExtraKMCharge = new System.Windows.Forms.Label();
            this.lblWaitingCharge = new System.Windows.Forms.Label();
            this.lblBasicChargeShow = new System.Windows.Forms.Label();
            this.lblOverNightChargeShow = new System.Windows.Forms.Label();
            this.lblWaitingChargeShow = new System.Windows.Forms.Label();
            this.lblTotalShow = new System.Windows.Forms.Label();
            this.gboxPackageType = new System.Windows.Forms.GroupBox();
            this.btnLongHire = new System.Windows.Forms.RadioButton();
            this.lblPackageType = new System.Windows.Forms.Label();
            this.rbtnDayHire = new System.Windows.Forms.RadioButton();
            this.rbtnRent = new System.Windows.Forms.RadioButton();
            this.timeRented = new System.Windows.Forms.DateTimePicker();
            this.timeReturned = new System.Windows.Forms.DateTimePicker();
            this.lblExtraKMChargeShow = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.gboxPay = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtnReserved = new System.Windows.Forms.RadioButton();
            this.rbtnNew = new System.Windows.Forms.RadioButton();
            this.gboxPackage = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cboxDriver = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboxVehicleType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbPackage = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDriverID = new System.Windows.Forms.ComboBox();
            this.lblDriNameShow = new System.Windows.Forms.Label();
            this.lblCustomerNameShow = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.gboxPackageType.SuspendLayout();
            this.gboxPay.SuspendLayout();
            this.gboxPackage.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPackageId
            // 
            this.lblPackageId.AutoSize = true;
            this.lblPackageId.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageId.Location = new System.Drawing.Point(16, 58);
            this.lblPackageId.Name = "lblPackageId";
            this.lblPackageId.Size = new System.Drawing.Size(155, 18);
            this.lblPackageId.TabIndex = 1;
            this.lblPackageId.Text = "Reservation Number";
            // 
            // lblCustomerNIC
            // 
            this.lblCustomerNIC.AutoSize = true;
            this.lblCustomerNIC.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNIC.Location = new System.Drawing.Point(17, 180);
            this.lblCustomerNIC.Name = "lblCustomerNIC";
            this.lblCustomerNIC.Size = new System.Drawing.Size(111, 18);
            this.lblCustomerNIC.TabIndex = 1;
            this.lblCustomerNIC.Text = "Customer NIC";
            // 
            // lblRentedDate
            // 
            this.lblRentedDate.AutoSize = true;
            this.lblRentedDate.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentedDate.Location = new System.Drawing.Point(16, 217);
            this.lblRentedDate.Name = "lblRentedDate";
            this.lblRentedDate.Size = new System.Drawing.Size(97, 18);
            this.lblRentedDate.TabIndex = 1;
            this.lblRentedDate.Text = "Rented Date";
            // 
            // lblReturnedDate
            // 
            this.lblReturnedDate.AutoSize = true;
            this.lblReturnedDate.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnedDate.Location = new System.Drawing.Point(476, 217);
            this.lblReturnedDate.Name = "lblReturnedDate";
            this.lblReturnedDate.Size = new System.Drawing.Size(112, 18);
            this.lblReturnedDate.TabIndex = 1;
            this.lblReturnedDate.Text = "Returned Date";
            // 
            // txtReservationID
            // 
            this.txtReservationID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReservationID.Location = new System.Drawing.Point(189, 55);
            this.txtReservationID.Name = "txtReservationID";
            this.txtReservationID.Size = new System.Drawing.Size(261, 27);
            this.txtReservationID.TabIndex = 3;
            this.txtReservationID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCustomerNIC
            // 
            this.txtCustomerNIC.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNIC.Location = new System.Drawing.Point(190, 177);
            this.txtCustomerNIC.Name = "txtCustomerNIC";
            this.txtCustomerNIC.Size = new System.Drawing.Size(262, 27);
            this.txtCustomerNIC.TabIndex = 3;
            this.txtCustomerNIC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCustomerNIC.TextAlignChanged += new System.EventHandler(this.txtCustomerNIC_TextAlignChanged);
            this.txtCustomerNIC.TextChanged += new System.EventHandler(this.txtCustomerNIC_TextChanged);
            // 
            // lblRentedTime
            // 
            this.lblRentedTime.AutoSize = true;
            this.lblRentedTime.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentedTime.Location = new System.Drawing.Point(16, 252);
            this.lblRentedTime.Name = "lblRentedTime";
            this.lblRentedTime.Size = new System.Drawing.Size(103, 18);
            this.lblRentedTime.TabIndex = 1;
            this.lblRentedTime.Text = "Rented Time ";
            // 
            // lblReturnedTime
            // 
            this.lblReturnedTime.AutoSize = true;
            this.lblReturnedTime.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReturnedTime.Location = new System.Drawing.Point(476, 252);
            this.lblReturnedTime.Name = "lblReturnedTime";
            this.lblReturnedTime.Size = new System.Drawing.Size(118, 18);
            this.lblReturnedTime.TabIndex = 1;
            this.lblReturnedTime.Text = "Returned Time ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 447);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 18);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total";
            // 
            // dateRented
            // 
            this.dateRented.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateRented.Location = new System.Drawing.Point(190, 212);
            this.dateRented.Name = "dateRented";
            this.dateRented.Size = new System.Drawing.Size(261, 27);
            this.dateRented.TabIndex = 4;
            // 
            // dateReturned
            // 
            this.dateReturned.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateReturned.Location = new System.Drawing.Point(614, 212);
            this.dateReturned.Name = "dateReturned";
            this.dateReturned.Size = new System.Drawing.Size(243, 27);
            this.dateReturned.TabIndex = 4;
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(464, 53);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(85, 29);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "Show";
            this.btnShow.UseMnemonic = false;
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(17, 22);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(45, 18);
            this.lblCash.TabIndex = 1;
            this.lblCash.Text = "Cash";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(17, 56);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(65, 18);
            this.lblBalance.TabIndex = 1;
            this.lblBalance.Text = "Balance";
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.Maroon;
            this.btnPay.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPay.Location = new System.Drawing.Point(657, 22);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(162, 61);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblStartKMReading
            // 
            this.lblStartKMReading.AutoSize = true;
            this.lblStartKMReading.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartKMReading.Location = new System.Drawing.Point(16, 285);
            this.lblStartKMReading.Name = "lblStartKMReading";
            this.lblStartKMReading.Size = new System.Drawing.Size(132, 18);
            this.lblStartKMReading.TabIndex = 1;
            this.lblStartKMReading.Text = "Start KM Reading";
            // 
            // lblEndKMReading
            // 
            this.lblEndKMReading.AutoSize = true;
            this.lblEndKMReading.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndKMReading.Location = new System.Drawing.Point(476, 285);
            this.lblEndKMReading.Name = "lblEndKMReading";
            this.lblEndKMReading.Size = new System.Drawing.Size(127, 18);
            this.lblEndKMReading.TabIndex = 1;
            this.lblEndKMReading.Text = "End KM Reading";
            // 
            // txtStartKMReading
            // 
            this.txtStartKMReading.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartKMReading.Location = new System.Drawing.Point(189, 282);
            this.txtStartKMReading.Name = "txtStartKMReading";
            this.txtStartKMReading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStartKMReading.Size = new System.Drawing.Size(261, 27);
            this.txtStartKMReading.TabIndex = 3;
            this.txtStartKMReading.Text = "0";
            this.txtStartKMReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtEndKMReading
            // 
            this.txtEndKMReading.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEndKMReading.Location = new System.Drawing.Point(613, 282);
            this.txtEndKMReading.Name = "txtEndKMReading";
            this.txtEndKMReading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEndKMReading.Size = new System.Drawing.Size(243, 27);
            this.txtEndKMReading.TabIndex = 3;
            this.txtEndKMReading.Text = "0";
            this.txtEndKMReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblBasicCharge
            // 
            this.lblBasicCharge.AutoSize = true;
            this.lblBasicCharge.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicCharge.Location = new System.Drawing.Point(13, 409);
            this.lblBasicCharge.Name = "lblBasicCharge";
            this.lblBasicCharge.Size = new System.Drawing.Size(94, 20);
            this.lblBasicCharge.TabIndex = 1;
            this.lblBasicCharge.Text = "Basic Charge";
            // 
            // lblOverNightCharge
            // 
            this.lblOverNightCharge.AutoSize = true;
            this.lblOverNightCharge.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverNightCharge.Location = new System.Drawing.Point(13, 413);
            this.lblOverNightCharge.Name = "lblOverNightCharge";
            this.lblOverNightCharge.Size = new System.Drawing.Size(180, 18);
            this.lblOverNightCharge.TabIndex = 1;
            this.lblOverNightCharge.Text = "Over Night Stay Charge";
            // 
            // lblExtraKMCharge
            // 
            this.lblExtraKMCharge.AutoSize = true;
            this.lblExtraKMCharge.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraKMCharge.Location = new System.Drawing.Point(476, 380);
            this.lblExtraKMCharge.Name = "lblExtraKMCharge";
            this.lblExtraKMCharge.Size = new System.Drawing.Size(131, 18);
            this.lblExtraKMCharge.TabIndex = 1;
            this.lblExtraKMCharge.Text = "Extra KM Charge";
            // 
            // lblWaitingCharge
            // 
            this.lblWaitingCharge.AutoSize = true;
            this.lblWaitingCharge.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitingCharge.Location = new System.Drawing.Point(476, 413);
            this.lblWaitingCharge.Name = "lblWaitingCharge";
            this.lblWaitingCharge.Size = new System.Drawing.Size(124, 18);
            this.lblWaitingCharge.TabIndex = 1;
            this.lblWaitingCharge.Text = "Waiting Charge";
            // 
            // lblBasicChargeShow
            // 
            this.lblBasicChargeShow.BackColor = System.Drawing.Color.CadetBlue;
            this.lblBasicChargeShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBasicChargeShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblBasicChargeShow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicChargeShow.Location = new System.Drawing.Point(193, 380);
            this.lblBasicChargeShow.Name = "lblBasicChargeShow";
            this.lblBasicChargeShow.Size = new System.Drawing.Size(257, 27);
            this.lblBasicChargeShow.TabIndex = 1;
            this.lblBasicChargeShow.Text = "Rs. 0";
            this.lblBasicChargeShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOverNightChargeShow
            // 
            this.lblOverNightChargeShow.BackColor = System.Drawing.Color.CadetBlue;
            this.lblOverNightChargeShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOverNightChargeShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblOverNightChargeShow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOverNightChargeShow.Location = new System.Drawing.Point(193, 413);
            this.lblOverNightChargeShow.Name = "lblOverNightChargeShow";
            this.lblOverNightChargeShow.Size = new System.Drawing.Size(257, 27);
            this.lblOverNightChargeShow.TabIndex = 1;
            this.lblOverNightChargeShow.Text = "Rs. 0";
            this.lblOverNightChargeShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOverNightChargeShow.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblWaitingChargeShow
            // 
            this.lblWaitingChargeShow.BackColor = System.Drawing.Color.CadetBlue;
            this.lblWaitingChargeShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWaitingChargeShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblWaitingChargeShow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWaitingChargeShow.Location = new System.Drawing.Point(613, 413);
            this.lblWaitingChargeShow.Name = "lblWaitingChargeShow";
            this.lblWaitingChargeShow.Size = new System.Drawing.Size(243, 27);
            this.lblWaitingChargeShow.TabIndex = 1;
            this.lblWaitingChargeShow.Text = "Rs. 0";
            this.lblWaitingChargeShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalShow
            // 
            this.lblTotalShow.BackColor = System.Drawing.Color.CadetBlue;
            this.lblTotalShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblTotalShow.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalShow.Location = new System.Drawing.Point(194, 451);
            this.lblTotalShow.Name = "lblTotalShow";
            this.lblTotalShow.Size = new System.Drawing.Size(257, 49);
            this.lblTotalShow.TabIndex = 1;
            this.lblTotalShow.Text = "Rs. 0";
            this.lblTotalShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblTotalShow.Click += new System.EventHandler(this.label12_Click);
            // 
            // gboxPackageType
            // 
            this.gboxPackageType.Controls.Add(this.btnLongHire);
            this.gboxPackageType.Controls.Add(this.lblPackageType);
            this.gboxPackageType.Controls.Add(this.rbtnDayHire);
            this.gboxPackageType.Controls.Add(this.rbtnRent);
            this.gboxPackageType.Location = new System.Drawing.Point(8, 88);
            this.gboxPackageType.Name = "gboxPackageType";
            this.gboxPackageType.Size = new System.Drawing.Size(849, 41);
            this.gboxPackageType.TabIndex = 10;
            this.gboxPackageType.TabStop = false;
            this.gboxPackageType.Enter += new System.EventHandler(this.gboxPackageType_Enter);
            // 
            // btnLongHire
            // 
            this.btnLongHire.AutoSize = true;
            this.btnLongHire.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLongHire.Location = new System.Drawing.Point(474, 11);
            this.btnLongHire.Name = "btnLongHire";
            this.btnLongHire.Size = new System.Drawing.Size(134, 23);
            this.btnLongHire.TabIndex = 12;
            this.btnLongHire.TabStop = true;
            this.btnLongHire.Text = "For Long Hire";
            this.btnLongHire.UseVisualStyleBackColor = true;
            this.btnLongHire.Click += new System.EventHandler(this.btnLongHire_Click);
            // 
            // lblPackageType
            // 
            this.lblPackageType.AutoSize = true;
            this.lblPackageType.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageType.Location = new System.Drawing.Point(9, 13);
            this.lblPackageType.Name = "lblPackageType";
            this.lblPackageType.Size = new System.Drawing.Size(110, 18);
            this.lblPackageType.TabIndex = 11;
            this.lblPackageType.Text = "Package Type";
            // 
            // rbtnDayHire
            // 
            this.rbtnDayHire.AutoSize = true;
            this.rbtnDayHire.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnDayHire.Location = new System.Drawing.Point(316, 11);
            this.rbtnDayHire.Name = "rbtnDayHire";
            this.rbtnDayHire.Size = new System.Drawing.Size(127, 23);
            this.rbtnDayHire.TabIndex = 13;
            this.rbtnDayHire.TabStop = true;
            this.rbtnDayHire.Text = "For Day Hire";
            this.rbtnDayHire.UseVisualStyleBackColor = true;
            this.rbtnDayHire.Click += new System.EventHandler(this.rbtnDayHire_Click);
            // 
            // rbtnRent
            // 
            this.rbtnRent.AutoSize = true;
            this.rbtnRent.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRent.Location = new System.Drawing.Point(186, 11);
            this.rbtnRent.Name = "rbtnRent";
            this.rbtnRent.Size = new System.Drawing.Size(94, 23);
            this.rbtnRent.TabIndex = 14;
            this.rbtnRent.TabStop = true;
            this.rbtnRent.Text = "For Rent";
            this.rbtnRent.UseVisualStyleBackColor = true;
            this.rbtnRent.CheckedChanged += new System.EventHandler(this.rbtnRent_CheckedChanged);
            this.rbtnRent.Click += new System.EventHandler(this.rbtnRent_Click);
            // 
            // timeRented
            // 
            this.timeRented.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeRented.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeRented.Location = new System.Drawing.Point(190, 247);
            this.timeRented.Name = "timeRented";
            this.timeRented.Size = new System.Drawing.Size(261, 27);
            this.timeRented.TabIndex = 4;
            this.timeRented.Value = new System.DateTime(2018, 9, 14, 13, 13, 25, 0);
            // 
            // timeReturned
            // 
            this.timeReturned.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeReturned.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeReturned.Location = new System.Drawing.Point(614, 247);
            this.timeReturned.Name = "timeReturned";
            this.timeReturned.Size = new System.Drawing.Size(243, 27);
            this.timeReturned.TabIndex = 4;
            this.timeReturned.Value = new System.DateTime(2018, 9, 14, 13, 13, 25, 0);
            // 
            // lblExtraKMChargeShow
            // 
            this.lblExtraKMChargeShow.BackColor = System.Drawing.Color.CadetBlue;
            this.lblExtraKMChargeShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblExtraKMChargeShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblExtraKMChargeShow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraKMChargeShow.Location = new System.Drawing.Point(613, 380);
            this.lblExtraKMChargeShow.Name = "lblExtraKMChargeShow";
            this.lblExtraKMChargeShow.Size = new System.Drawing.Size(243, 27);
            this.lblExtraKMChargeShow.TabIndex = 1;
            this.lblExtraKMChargeShow.Text = "Rs. 0";
            this.lblExtraKMChargeShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(180, 19);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(213, 27);
            this.textBox3.TabIndex = 3;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalance.Location = new System.Drawing.Point(180, 53);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(213, 27);
            this.txtBalance.TabIndex = 3;
            // 
            // gboxPay
            // 
            this.gboxPay.Controls.Add(this.textBox3);
            this.gboxPay.Controls.Add(this.btnPay);
            this.gboxPay.Controls.Add(this.lblCash);
            this.gboxPay.Controls.Add(this.lblBalance);
            this.gboxPay.Controls.Add(this.txtBalance);
            this.gboxPay.Location = new System.Drawing.Point(4, 509);
            this.gboxPay.Name = "gboxPay";
            this.gboxPay.Size = new System.Drawing.Size(859, 100);
            this.gboxPay.TabIndex = 11;
            this.gboxPay.TabStop = false;
            this.gboxPay.Enter += new System.EventHandler(this.gboxPay_Enter);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(476, 451);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 49);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "Calculate Total";
            this.btnCalculate.UseMnemonic = false;
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Package";
            // 
            // rbtnReserved
            // 
            this.rbtnReserved.AutoSize = true;
            this.rbtnReserved.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnReserved.Location = new System.Drawing.Point(186, 11);
            this.rbtnReserved.Name = "rbtnReserved";
            this.rbtnReserved.Size = new System.Drawing.Size(100, 23);
            this.rbtnReserved.TabIndex = 8;
            this.rbtnReserved.TabStop = true;
            this.rbtnReserved.Text = "Reserved";
            this.rbtnReserved.UseVisualStyleBackColor = true;
            this.rbtnReserved.CheckedChanged += new System.EventHandler(this.rbtnReserved_CheckedChanged);
            this.rbtnReserved.Click += new System.EventHandler(this.rbtnReserved_Click);
            // 
            // rbtnNew
            // 
            this.rbtnNew.AutoSize = true;
            this.rbtnNew.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNew.Location = new System.Drawing.Point(312, 11);
            this.rbtnNew.Name = "rbtnNew";
            this.rbtnNew.Size = new System.Drawing.Size(62, 23);
            this.rbtnNew.TabIndex = 9;
            this.rbtnNew.TabStop = true;
            this.rbtnNew.Text = "New";
            this.rbtnNew.UseVisualStyleBackColor = true;
            this.rbtnNew.CheckedChanged += new System.EventHandler(this.rbtnNew_CheckedChanged);
            this.rbtnNew.Click += new System.EventHandler(this.rbtnNew_Click);
            // 
            // gboxPackage
            // 
            this.gboxPackage.Controls.Add(this.rbtnNew);
            this.gboxPackage.Controls.Add(this.rbtnReserved);
            this.gboxPackage.Controls.Add(this.btnReset);
            this.gboxPackage.Controls.Add(this.label1);
            this.gboxPackage.Location = new System.Drawing.Point(8, 3);
            this.gboxPackage.Name = "gboxPackage";
            this.gboxPackage.Size = new System.Drawing.Size(849, 41);
            this.gboxPackage.TabIndex = 6;
            this.gboxPackage.TabStop = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(736, 9);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 29);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseMnemonic = false;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Driver Status";
            // 
            // cboxDriver
            // 
            this.cboxDriver.AutoSize = true;
            this.cboxDriver.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxDriver.Location = new System.Drawing.Point(190, 320);
            this.cboxDriver.Name = "cboxDriver";
            this.cboxDriver.Size = new System.Drawing.Size(121, 23);
            this.cboxDriver.TabIndex = 12;
            this.cboxDriver.Text = "With Driver";
            this.cboxDriver.UseVisualStyleBackColor = true;
            this.cboxDriver.CheckedChanged += new System.EventHandler(this.cboxDriver_CheckedChanged);
            this.cboxDriver.Click += new System.EventHandler(this.cboxDriver_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.Teal;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(4, 348);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(858, 15);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(478, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Vehicle Type";
            // 
            // cboxVehicleType
            // 
            this.cboxVehicleType.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxVehicleType.FormattingEnabled = true;
            this.cboxVehicleType.Location = new System.Drawing.Point(614, 143);
            this.cboxVehicleType.Name = "cboxVehicleType";
            this.cboxVehicleType.Size = new System.Drawing.Size(243, 25);
            this.cboxVehicleType.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Package";
            // 
            // cmbPackage
            // 
            this.cmbPackage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPackage.FormattingEnabled = true;
            this.cmbPackage.Location = new System.Drawing.Point(191, 143);
            this.cmbPackage.Name = "cmbPackage";
            this.cmbPackage.Size = new System.Drawing.Size(261, 25);
            this.cmbPackage.TabIndex = 13;
            this.cmbPackage.TextChanged += new System.EventHandler(this.cmbPackage_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Basic Charge";
            // 
            // cmbDriverID
            // 
            this.cmbDriverID.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDriverID.FormattingEnabled = true;
            this.cmbDriverID.Location = new System.Drawing.Point(341, 320);
            this.cmbDriverID.Name = "cmbDriverID";
            this.cmbDriverID.Size = new System.Drawing.Size(107, 25);
            this.cmbDriverID.TabIndex = 13;
            this.cmbDriverID.TextChanged += new System.EventHandler(this.cmbDriverID_TextChanged);
            this.cmbDriverID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbDriverID_KeyPress);
            // 
            // lblDriNameShow
            // 
            this.lblDriNameShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblDriNameShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDriNameShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblDriNameShow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDriNameShow.Location = new System.Drawing.Point(482, 319);
            this.lblDriNameShow.Name = "lblDriNameShow";
            this.lblDriNameShow.Size = new System.Drawing.Size(374, 27);
            this.lblDriNameShow.TabIndex = 1;
            this.lblDriNameShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCustomerNameShow
            // 
            this.lblCustomerNameShow.BackColor = System.Drawing.Color.Silver;
            this.lblCustomerNameShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomerNameShow.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblCustomerNameShow.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerNameShow.Location = new System.Drawing.Point(483, 177);
            this.lblCustomerNameShow.Name = "lblCustomerNameShow";
            this.lblCustomerNameShow.Size = new System.Drawing.Size(374, 27);
            this.lblCustomerNameShow.TabIndex = 1;
            this.lblCustomerNameShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(529, 468);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(52, 20);
            this.txtTemp.TabIndex = 16;
            this.txtTemp.Text = "0";
            // 
            // FrmPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(868, 618);
            this.Controls.Add(this.cboxVehicleType);
            this.Controls.Add(this.cmbDriverID);
            this.Controls.Add(this.cmbPackage);
            this.Controls.Add(this.cboxDriver);
            this.Controls.Add(this.gboxPay);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.timeReturned);
            this.Controls.Add(this.dateReturned);
            this.Controls.Add(this.timeRented);
            this.Controls.Add(this.dateRented);
            this.Controls.Add(this.txtEndKMReading);
            this.Controls.Add(this.txtStartKMReading);
            this.Controls.Add(this.txtCustomerNIC);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtReservationID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblOverNightCharge);
            this.Controls.Add(this.lblWaitingCharge);
            this.Controls.Add(this.lblExtraKMCharge);
            this.Controls.Add(this.lblEndKMReading);
            this.Controls.Add(this.lblBasicCharge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStartKMReading);
            this.Controls.Add(this.lblReturnedTime);
            this.Controls.Add(this.lblRentedTime);
            this.Controls.Add(this.lblReturnedDate);
            this.Controls.Add(this.lblRentedDate);
            this.Controls.Add(this.lblExtraKMChargeShow);
            this.Controls.Add(this.lblCustomerNameShow);
            this.Controls.Add(this.lblDriNameShow);
            this.Controls.Add(this.lblWaitingChargeShow);
            this.Controls.Add(this.lblTotalShow);
            this.Controls.Add(this.lblOverNightChargeShow);
            this.Controls.Add(this.lblBasicChargeShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCustomerNIC);
            this.Controls.Add(this.lblPackageId);
            this.Controls.Add(this.gboxPackage);
            this.Controls.Add(this.gboxPackageType);
            this.Controls.Add(this.txtTemp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.FrmPayment_Load);
            this.gboxPackageType.ResumeLayout(false);
            this.gboxPackageType.PerformLayout();
            this.gboxPay.ResumeLayout(false);
            this.gboxPay.PerformLayout();
            this.gboxPackage.ResumeLayout(false);
            this.gboxPackage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPackageId;
        private System.Windows.Forms.Label lblCustomerNIC;
        private System.Windows.Forms.Label lblRentedDate;
        private System.Windows.Forms.Label lblReturnedDate;
        private System.Windows.Forms.TextBox txtReservationID;
        private System.Windows.Forms.TextBox txtCustomerNIC;
        private System.Windows.Forms.Label lblRentedTime;
        private System.Windows.Forms.Label lblReturnedTime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateRented;
        private System.Windows.Forms.DateTimePicker dateReturned;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblStartKMReading;
        private System.Windows.Forms.Label lblEndKMReading;
        private System.Windows.Forms.TextBox txtStartKMReading;
        private System.Windows.Forms.TextBox txtEndKMReading;
        private System.Windows.Forms.Label lblBasicCharge;
        private System.Windows.Forms.Label lblOverNightCharge;
        private System.Windows.Forms.Label lblExtraKMCharge;
        private System.Windows.Forms.Label lblWaitingCharge;
        private System.Windows.Forms.Label lblBasicChargeShow;
        private System.Windows.Forms.Label lblOverNightChargeShow;
        private System.Windows.Forms.Label lblWaitingChargeShow;
        private System.Windows.Forms.Label lblTotalShow;
        private System.Windows.Forms.GroupBox gboxPackageType;
        private System.Windows.Forms.RadioButton btnLongHire;
        private System.Windows.Forms.Label lblPackageType;
        private System.Windows.Forms.RadioButton rbtnDayHire;
        private System.Windows.Forms.RadioButton rbtnRent;
        private System.Windows.Forms.DateTimePicker timeRented;
        private System.Windows.Forms.DateTimePicker timeReturned;
        private System.Windows.Forms.Label lblExtraKMChargeShow;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.GroupBox gboxPay;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtnReserved;
        private System.Windows.Forms.RadioButton rbtnNew;
        private System.Windows.Forms.GroupBox gboxPackage;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cboxDriver;
        protected System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboxVehicleType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbPackage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDriverID;
        private System.Windows.Forms.Label lblDriNameShow;
        private System.Windows.Forms.Label lblCustomerNameShow;
        private System.Windows.Forms.TextBox txtTemp;
    }
}