namespace AyuboCarRentManagementSystem
{
    partial class FrmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.driversToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleCollectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.packagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vehiclePackagesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPackagesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addPaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolCompany = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.reservationToolStripMenuItem,
            this.driversToolStripMenuItem,
            this.vehicleToolStripMenuItem2,
            this.packagesToolStripMenuItem,
            this.paymentsToolStripMenuItem,
            this.utilitiesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1202, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked_1);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Image = global::AyuboCarRentManagementSystem.Properties.Resources.Backup_center_icon;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(77, 21);
            this.menuToolStripMenuItem.Text = "System";
            this.menuToolStripMenuItem.Click += new System.EventHandler(this.menuToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerToolStripMenuItem});
            this.customerToolStripMenuItem.Image = global::AyuboCarRentManagementSystem.Properties.Resources.xsc_girl;
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.customerToolStripMenuItem.Text = "Customer";
            // 
            // addCustomerToolStripMenuItem
            // 
            this.addCustomerToolStripMenuItem.Name = "addCustomerToolStripMenuItem";
            this.addCustomerToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.addCustomerToolStripMenuItem.Text = "Add Customer";
            this.addCustomerToolStripMenuItem.Click += new System.EventHandler(this.addCustomerToolStripMenuItem_Click);
            // 
            // reservationToolStripMenuItem
            // 
            this.reservationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservationToolStripMenuItem1});
            this.reservationToolStripMenuItem.Image = global::AyuboCarRentManagementSystem.Properties.Resources.xsc_girl;
            this.reservationToolStripMenuItem.Name = "reservationToolStripMenuItem";
            this.reservationToolStripMenuItem.Size = new System.Drawing.Size(104, 21);
            this.reservationToolStripMenuItem.Text = "Reservation";
            // 
            // reservationToolStripMenuItem1
            // 
            this.reservationToolStripMenuItem1.Name = "reservationToolStripMenuItem1";
            this.reservationToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.reservationToolStripMenuItem1.Text = "Reservation";
            this.reservationToolStripMenuItem1.Click += new System.EventHandler(this.reservationToolStripMenuItem1_Click);
            // 
            // driversToolStripMenuItem
            // 
            this.driversToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driversToolStripMenuItem1});
            this.driversToolStripMenuItem.Image = global::AyuboCarRentManagementSystem.Properties.Resources.img_3118461;
            this.driversToolStripMenuItem.Name = "driversToolStripMenuItem";
            this.driversToolStripMenuItem.Size = new System.Drawing.Size(99, 21);
            this.driversToolStripMenuItem.Text = "Employees";
            this.driversToolStripMenuItem.Click += new System.EventHandler(this.driversToolStripMenuItem_Click);
            // 
            // driversToolStripMenuItem1
            // 
            this.driversToolStripMenuItem1.Name = "driversToolStripMenuItem1";
            this.driversToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.driversToolStripMenuItem1.Text = "Drivers";
            this.driversToolStripMenuItem1.Click += new System.EventHandler(this.driversToolStripMenuItem1_Click);
            // 
            // vehicleToolStripMenuItem2
            // 
            this.vehicleToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleCollectionToolStripMenuItem});
            this.vehicleToolStripMenuItem2.Image = global::AyuboCarRentManagementSystem.Properties.Resources.Transport_car;
            this.vehicleToolStripMenuItem2.Name = "vehicleToolStripMenuItem2";
            this.vehicleToolStripMenuItem2.Size = new System.Drawing.Size(76, 21);
            this.vehicleToolStripMenuItem2.Text = "Vehicle";
            // 
            // vehicleCollectionToolStripMenuItem
            // 
            this.vehicleCollectionToolStripMenuItem.Name = "vehicleCollectionToolStripMenuItem";
            this.vehicleCollectionToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.vehicleCollectionToolStripMenuItem.Text = "Vehicle Collection";
            this.vehicleCollectionToolStripMenuItem.Click += new System.EventHandler(this.vehicleCollectionToolStripMenuItem_Click_1);
            // 
            // packagesToolStripMenuItem
            // 
            this.packagesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehiclePackagesToolStripMenuItem1,
            this.viewPackagesToolStripMenuItem});
            this.packagesToolStripMenuItem.Image = global::AyuboCarRentManagementSystem.Properties.Resources._506621_200;
            this.packagesToolStripMenuItem.Name = "packagesToolStripMenuItem";
            this.packagesToolStripMenuItem.Size = new System.Drawing.Size(90, 21);
            this.packagesToolStripMenuItem.Text = "Packages";
            // 
            // vehiclePackagesToolStripMenuItem1
            // 
            this.vehiclePackagesToolStripMenuItem1.Name = "vehiclePackagesToolStripMenuItem1";
            this.vehiclePackagesToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.vehiclePackagesToolStripMenuItem1.Text = "Add Packages";
            this.vehiclePackagesToolStripMenuItem1.Click += new System.EventHandler(this.vehicleToolStripMenuItem1_Click);
            // 
            // viewPackagesToolStripMenuItem
            // 
            this.viewPackagesToolStripMenuItem.Name = "viewPackagesToolStripMenuItem";
            this.viewPackagesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.viewPackagesToolStripMenuItem.Text = "View Packages";
            this.viewPackagesToolStripMenuItem.Click += new System.EventHandler(this.viewPackagesToolStripMenuItem_Click);
            // 
            // paymentsToolStripMenuItem
            // 
            this.paymentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addPaymentToolStripMenuItem});
            this.paymentsToolStripMenuItem.Image = global::AyuboCarRentManagementSystem.Properties.Resources._16032;
            this.paymentsToolStripMenuItem.Name = "paymentsToolStripMenuItem";
            this.paymentsToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.paymentsToolStripMenuItem.Text = "Payments";
            // 
            // addPaymentToolStripMenuItem
            // 
            this.addPaymentToolStripMenuItem.Name = "addPaymentToolStripMenuItem";
            this.addPaymentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.addPaymentToolStripMenuItem.Text = "Payment";
            this.addPaymentToolStripMenuItem.Click += new System.EventHandler(this.addPaymentToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem1});
            this.utilitiesToolStripMenuItem.Image = global::AyuboCarRentManagementSystem.Properties.Resources._16032;
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(78, 21);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // changePasswordToolStripMenuItem1
            // 
            this.changePasswordToolStripMenuItem1.Name = "changePasswordToolStripMenuItem1";
            this.changePasswordToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.changePasswordToolStripMenuItem1.Text = "Change Password";
            this.changePasswordToolStripMenuItem1.Click += new System.EventHandler(this.changePasswordToolStripMenuItem1_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.changePasswordToolStripMenuItem.Text = "Change password";
            // 
            // addUsersToolStripMenuItem
            // 
            this.addUsersToolStripMenuItem.Name = "addUsersToolStripMenuItem";
            this.addUsersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.addUsersToolStripMenuItem.Text = "Users";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolDate,
            this.toolTime,
            this.toolCompany});
            this.statusStrip1.Location = new System.Drawing.Point(0, 406);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1202, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(204, 21);
            this.toolStripStatusLabel1.Text = "Migantha Software Solution";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click_1);
            // 
            // toolDate
            // 
            this.toolDate.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.toolDate.Name = "toolDate";
            this.toolDate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolDate.Size = new System.Drawing.Size(52, 21);
            this.toolDate.Text = "Date";
            // 
            // toolTime
            // 
            this.toolTime.BorderStyle = System.Windows.Forms.Border3DStyle.Bump;
            this.toolTime.Name = "toolTime";
            this.toolTime.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.toolTime.Size = new System.Drawing.Size(54, 21);
            this.toolTime.Text = "Time";
            // 
            // toolCompany
            // 
            this.toolCompany.Name = "toolCompany";
            this.toolCompany.Size = new System.Drawing.Size(260, 21);
            this.toolCompany.Text = "Ayubo Car Rent Company (PVT) Ltd.";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1202, 432);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMainMenu";
            this.Text = "Main Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem packagesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paymentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem driversToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vehiclePackagesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem utilitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addPaymentToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolDate;
        private System.Windows.Forms.ToolStripStatusLabel toolTime;
        private System.Windows.Forms.ToolStripStatusLabel toolCompany;
        private System.Windows.Forms.ToolStripMenuItem vehicleToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem vehicleCollectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPackagesToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}