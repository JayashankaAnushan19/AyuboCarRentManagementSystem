namespace AyuboCarRentManagementSystem
{
    partial class FrmVehicleTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVehicleTypes));
            this.lblID = new System.Windows.Forms.Label();
            this.lblVehicleType = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtVehicleType = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPerDayRent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPerWeekRent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPerMonthRent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxDayKMLimit = new System.Windows.Forms.TextBox();
            this.txtMaxWeekKMLimit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaxMonthKMLimit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtExtraKMCharge = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtExtraHourCharge = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOverNightCharge = new System.Windows.Forms.TextBox();
            this.rbtnPerDay = new System.Windows.Forms.RadioButton();
            this.rbtnPerWeek = new System.Windows.Forms.RadioButton();
            this.rbtnPerMonth = new System.Windows.Forms.RadioButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaxKMLimitRent = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtExtraKMChargeForRent = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBasicCharge = new System.Windows.Forms.TextBox();
            this.lblMaxTimeLimit = new System.Windows.Forms.Label();
            this.txtMaxTimeLimit = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtMaxKMLimitForHire = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMaxTimeLimitLongHire = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(8, 51);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(97, 19);
            this.lblID.TabIndex = 35;
            this.lblID.Text = "Package Name";
            // 
            // lblVehicleType
            // 
            this.lblVehicleType.AutoSize = true;
            this.lblVehicleType.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleType.Location = new System.Drawing.Point(833, 51);
            this.lblVehicleType.Name = "lblVehicleType";
            this.lblVehicleType.Size = new System.Drawing.Size(89, 19);
            this.lblVehicleType.TabIndex = 38;
            this.lblVehicleType.Text = "Vehicle Type";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.LightCyan;
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(214, 50);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(192, 27);
            this.txtName.TabIndex = 3;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // txtVehicleType
            // 
            this.txtVehicleType.BackColor = System.Drawing.Color.LightCyan;
            this.txtVehicleType.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleType.Location = new System.Drawing.Point(980, 50);
            this.txtVehicleType.Name = "txtVehicleType";
            this.txtVehicleType.Size = new System.Drawing.Size(215, 27);
            this.txtVehicleType.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.PaleGreen;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1059, 336);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 46);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Gold;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(906, 336);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(133, 46);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(753, 336);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 46);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Per Day Rent";
            // 
            // txtPerDayRent
            // 
            this.txtPerDayRent.BackColor = System.Drawing.Color.LightCyan;
            this.txtPerDayRent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerDayRent.Location = new System.Drawing.Point(214, 96);
            this.txtPerDayRent.Name = "txtPerDayRent";
            this.txtPerDayRent.Size = new System.Drawing.Size(192, 27);
            this.txtPerDayRent.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "Per Week Rent";
            // 
            // txtPerWeekRent
            // 
            this.txtPerWeekRent.BackColor = System.Drawing.Color.LightCyan;
            this.txtPerWeekRent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerWeekRent.Location = new System.Drawing.Point(626, 96);
            this.txtPerWeekRent.Name = "txtPerWeekRent";
            this.txtPerWeekRent.Size = new System.Drawing.Size(177, 27);
            this.txtPerWeekRent.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(833, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Per Month Rent";
            // 
            // txtPerMonthRent
            // 
            this.txtPerMonthRent.BackColor = System.Drawing.Color.LightCyan;
            this.txtPerMonthRent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerMonthRent.Location = new System.Drawing.Point(979, 96);
            this.txtPerMonthRent.Name = "txtPerMonthRent";
            this.txtPerMonthRent.Size = new System.Drawing.Size(216, 27);
            this.txtPerMonthRent.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 34;
            this.label4.Text = "Package Category";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Max Day KM Limit";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(438, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "Max Week KM Limit";
            // 
            // txtMaxDayKMLimit
            // 
            this.txtMaxDayKMLimit.BackColor = System.Drawing.Color.LightCyan;
            this.txtMaxDayKMLimit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxDayKMLimit.Location = new System.Drawing.Point(214, 205);
            this.txtMaxDayKMLimit.Name = "txtMaxDayKMLimit";
            this.txtMaxDayKMLimit.Size = new System.Drawing.Size(192, 27);
            this.txtMaxDayKMLimit.TabIndex = 8;
            // 
            // txtMaxWeekKMLimit
            // 
            this.txtMaxWeekKMLimit.BackColor = System.Drawing.Color.LightCyan;
            this.txtMaxWeekKMLimit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxWeekKMLimit.Location = new System.Drawing.Point(626, 205);
            this.txtMaxWeekKMLimit.Name = "txtMaxWeekKMLimit";
            this.txtMaxWeekKMLimit.Size = new System.Drawing.Size(177, 27);
            this.txtMaxWeekKMLimit.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(833, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Max Month KM Limit";
            // 
            // txtMaxMonthKMLimit
            // 
            this.txtMaxMonthKMLimit.BackColor = System.Drawing.Color.LightCyan;
            this.txtMaxMonthKMLimit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxMonthKMLimit.Location = new System.Drawing.Point(979, 207);
            this.txtMaxMonthKMLimit.Name = "txtMaxMonthKMLimit";
            this.txtMaxMonthKMLimit.Size = new System.Drawing.Size(216, 27);
            this.txtMaxMonthKMLimit.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "Extra KM Charge";
            // 
            // txtExtraKMCharge
            // 
            this.txtExtraKMCharge.BackColor = System.Drawing.Color.LightCyan;
            this.txtExtraKMCharge.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraKMCharge.Location = new System.Drawing.Point(626, 242);
            this.txtExtraKMCharge.Name = "txtExtraKMCharge";
            this.txtExtraKMCharge.Size = new System.Drawing.Size(177, 27);
            this.txtExtraKMCharge.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(833, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 19);
            this.label9.TabIndex = 26;
            this.label9.Text = "Extra Hour Charge";
            // 
            // txtExtraHourCharge
            // 
            this.txtExtraHourCharge.BackColor = System.Drawing.Color.LightCyan;
            this.txtExtraHourCharge.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraHourCharge.Location = new System.Drawing.Point(979, 242);
            this.txtExtraHourCharge.Name = "txtExtraHourCharge";
            this.txtExtraHourCharge.Size = new System.Drawing.Size(216, 27);
            this.txtExtraHourCharge.TabIndex = 12;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(8, 282);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(159, 19);
            this.label11.TabIndex = 29;
            this.label11.Text = "Over Night Stay Charge";
            // 
            // txtOverNightCharge
            // 
            this.txtOverNightCharge.BackColor = System.Drawing.Color.LightCyan;
            this.txtOverNightCharge.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOverNightCharge.Location = new System.Drawing.Point(214, 279);
            this.txtOverNightCharge.Name = "txtOverNightCharge";
            this.txtOverNightCharge.Size = new System.Drawing.Size(192, 27);
            this.txtOverNightCharge.TabIndex = 16;
            // 
            // rbtnPerDay
            // 
            this.rbtnPerDay.AutoSize = true;
            this.rbtnPerDay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPerDay.Location = new System.Drawing.Point(214, 5);
            this.rbtnPerDay.Name = "rbtnPerDay";
            this.rbtnPerDay.Size = new System.Drawing.Size(87, 24);
            this.rbtnPerDay.TabIndex = 0;
            this.rbtnPerDay.TabStop = true;
            this.rbtnPerDay.Text = "For Rent";
            this.rbtnPerDay.UseVisualStyleBackColor = true;
            this.rbtnPerDay.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.rbtnPerDay.Click += new System.EventHandler(this.rbtnPerDay_Click);
            // 
            // rbtnPerWeek
            // 
            this.rbtnPerWeek.AutoSize = true;
            this.rbtnPerWeek.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPerWeek.Location = new System.Drawing.Point(351, 5);
            this.rbtnPerWeek.Name = "rbtnPerWeek";
            this.rbtnPerWeek.Size = new System.Drawing.Size(114, 24);
            this.rbtnPerWeek.TabIndex = 1;
            this.rbtnPerWeek.TabStop = true;
            this.rbtnPerWeek.Text = "For Day Hire";
            this.rbtnPerWeek.UseVisualStyleBackColor = true;
            this.rbtnPerWeek.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            this.rbtnPerWeek.Click += new System.EventHandler(this.rbtnPerWeek_Click);
            // 
            // rbtnPerMonth
            // 
            this.rbtnPerMonth.AutoSize = true;
            this.rbtnPerMonth.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnPerMonth.Location = new System.Drawing.Point(516, 5);
            this.rbtnPerMonth.Name = "rbtnPerMonth";
            this.rbtnPerMonth.Size = new System.Drawing.Size(122, 24);
            this.rbtnPerMonth.TabIndex = 2;
            this.rbtnPerMonth.TabStop = true;
            this.rbtnPerMonth.Text = "For Long Hire";
            this.rbtnPerMonth.UseVisualStyleBackColor = true;
            this.rbtnPerMonth.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            this.rbtnPerMonth.Click += new System.EventHandler(this.rbtnPerMonth_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(159, 19);
            this.label12.TabIndex = 30;
            this.label12.Text = "Max KM Limit For Rent";
            // 
            // txtMaxKMLimitRent
            // 
            this.txtMaxKMLimitRent.BackColor = System.Drawing.Color.LightCyan;
            this.txtMaxKMLimitRent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxKMLimitRent.Location = new System.Drawing.Point(214, 130);
            this.txtMaxKMLimitRent.Name = "txtMaxKMLimitRent";
            this.txtMaxKMLimitRent.Size = new System.Drawing.Size(192, 27);
            this.txtMaxKMLimitRent.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(-1, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(1202, 19);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.RosyBrown;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1, 77);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(1202, 19);
            this.textBox2.TabIndex = 36;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Salmon;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(13, 336);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(133, 46);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(438, 133);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(175, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "Extra KM Charge For Rent";
            // 
            // txtExtraKMChargeForRent
            // 
            this.txtExtraKMChargeForRent.BackColor = System.Drawing.Color.LightCyan;
            this.txtExtraKMChargeForRent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExtraKMChargeForRent.Location = new System.Drawing.Point(626, 130);
            this.txtExtraKMChargeForRent.Name = "txtExtraKMChargeForRent";
            this.txtExtraKMChargeForRent.Size = new System.Drawing.Size(177, 27);
            this.txtExtraKMChargeForRent.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(438, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(78, 19);
            this.label14.TabIndex = 38;
            this.label14.Text = "Vehicle  ID";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.BackColor = System.Drawing.Color.LightCyan;
            this.txtVehicleID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleID.Location = new System.Drawing.Point(626, 50);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.Size = new System.Drawing.Size(177, 27);
            this.txtVehicleID.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(833, 170);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 19);
            this.label15.TabIndex = 25;
            this.label15.Text = "Basic Charge";
            // 
            // txtBasicCharge
            // 
            this.txtBasicCharge.BackColor = System.Drawing.Color.LightCyan;
            this.txtBasicCharge.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBasicCharge.Location = new System.Drawing.Point(979, 167);
            this.txtBasicCharge.Name = "txtBasicCharge";
            this.txtBasicCharge.Size = new System.Drawing.Size(216, 27);
            this.txtBasicCharge.TabIndex = 15;
            // 
            // lblMaxTimeLimit
            // 
            this.lblMaxTimeLimit.AutoSize = true;
            this.lblMaxTimeLimit.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxTimeLimit.Location = new System.Drawing.Point(8, 170);
            this.lblMaxTimeLimit.Name = "lblMaxTimeLimit";
            this.lblMaxTimeLimit.Size = new System.Drawing.Size(108, 19);
            this.lblMaxTimeLimit.TabIndex = 23;
            this.lblMaxTimeLimit.Text = "Max Time Limit";
            // 
            // txtMaxTimeLimit
            // 
            this.txtMaxTimeLimit.BackColor = System.Drawing.Color.LightCyan;
            this.txtMaxTimeLimit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxTimeLimit.Location = new System.Drawing.Point(214, 167);
            this.txtMaxTimeLimit.Name = "txtMaxTimeLimit";
            this.txtMaxTimeLimit.Size = new System.Drawing.Size(192, 27);
            this.txtMaxTimeLimit.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(438, 170);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(190, 19);
            this.label16.TabIndex = 23;
            this.label16.Text = "Max KM Limit For Day Hire";
            // 
            // txtMaxKMLimitForHire
            // 
            this.txtMaxKMLimitForHire.BackColor = System.Drawing.Color.LightCyan;
            this.txtMaxKMLimitForHire.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxKMLimitForHire.Location = new System.Drawing.Point(626, 167);
            this.txtMaxKMLimitForHire.Name = "txtMaxKMLimitForHire";
            this.txtMaxKMLimitForHire.Size = new System.Drawing.Size(177, 27);
            this.txtMaxKMLimitForHire.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("High Tower Text", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(195, 19);
            this.label10.TabIndex = 31;
            this.label10.Text = "Max Day Limit For Long Hire";
            // 
            // txtMaxTimeLimitLongHire
            // 
            this.txtMaxTimeLimitLongHire.BackColor = System.Drawing.Color.LightCyan;
            this.txtMaxTimeLimitLongHire.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaxTimeLimitLongHire.Location = new System.Drawing.Point(214, 242);
            this.txtMaxTimeLimitLongHire.Name = "txtMaxTimeLimitLongHire";
            this.txtMaxTimeLimitLongHire.Size = new System.Drawing.Size(192, 27);
            this.txtMaxTimeLimitLongHire.TabIndex = 11;
            // 
            // FrmVehicleTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(1204, 400);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rbtnPerMonth);
            this.Controls.Add(this.rbtnPerWeek);
            this.Controls.Add(this.rbtnPerDay);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtMaxTimeLimit);
            this.Controls.Add(this.txtMaxKMLimitForHire);
            this.Controls.Add(this.txtMaxMonthKMLimit);
            this.Controls.Add(this.txtMaxWeekKMLimit);
            this.Controls.Add(this.txtPerMonthRent);
            this.Controls.Add(this.txtExtraHourCharge);
            this.Controls.Add(this.txtOverNightCharge);
            this.Controls.Add(this.txtMaxTimeLimitLongHire);
            this.Controls.Add(this.txtExtraKMCharge);
            this.Controls.Add(this.txtMaxDayKMLimit);
            this.Controls.Add(this.txtBasicCharge);
            this.Controls.Add(this.txtExtraKMChargeForRent);
            this.Controls.Add(this.txtMaxKMLimitRent);
            this.Controls.Add(this.txtPerWeekRent);
            this.Controls.Add(this.txtPerDayRent);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.lblMaxTimeLimit);
            this.Controls.Add(this.txtVehicleType);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblVehicleType);
            this.Controls.Add(this.lblID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmVehicleTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Packages";
            this.Load += new System.EventHandler(this.FrmVehicleTypes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblVehicleType;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtVehicleType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPerDayRent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPerWeekRent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPerMonthRent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxDayKMLimit;
        private System.Windows.Forms.TextBox txtMaxWeekKMLimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaxMonthKMLimit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtExtraKMCharge;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtExtraHourCharge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOverNightCharge;
        private System.Windows.Forms.RadioButton rbtnPerDay;
        private System.Windows.Forms.RadioButton rbtnPerWeek;
        private System.Windows.Forms.RadioButton rbtnPerMonth;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaxKMLimitRent;
        protected System.Windows.Forms.TextBox textBox1;
        protected System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtExtraKMChargeForRent;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBasicCharge;
        private System.Windows.Forms.Label lblMaxTimeLimit;
        private System.Windows.Forms.TextBox txtMaxTimeLimit;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtMaxKMLimitForHire;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtMaxTimeLimitLongHire;
    }
}