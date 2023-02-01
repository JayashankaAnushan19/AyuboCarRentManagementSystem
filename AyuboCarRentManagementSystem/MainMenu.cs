using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AyuboCarRentManagementSystem
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reservationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmReservation reserve = new FrmReservation();
            reserve.MdiParent = this;
            reserve.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.MdiParent = this;
            about.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomer customer = new FrmCustomer();
            customer.MdiParent = this;
            customer.Show();
        }

        private void findCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomer customer = new FrmCustomer();
            customer.MdiParent = this;
            customer.Show();
        }

        private void pastReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmReservation reserve = new FrmReservation();
            reserve.MdiParent = this;
            reserve.Show();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void driversToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEmployee employee = new FrmEmployee();
            employee.MdiParent = this;
            employee.Show();
        }

        private void vehicleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVehicleTypes vehicletype = new FrmVehicleTypes();
            vehicletype.MdiParent = this;
            vehicletype.Show();
        }

        private void vehicleCollectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVehicleCollection vehiclecollection = new FrmVehicleCollection();
            vehiclecollection.MdiParent = this;
            vehiclecollection.Show();
        }

        private void addPaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPayment Payment = new FrmPayment();
            Payment.MdiParent = this;
            Payment.Show();
        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmChangePassword changepass = new FrmChangePassword();
            changepass.MdiParent = this;
            changepass.Show();
        }

        private void backupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackupRestore backrestore = new FrmBackupRestore();
            backrestore.MdiParent = this;
            backrestore.Show();
        }

        private void vehicleCollectionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmVehicleCollection vehiclecollection = new FrmVehicleCollection();
            vehiclecollection.MdiParent = this;
            vehiclecollection.Show();
        }

        private void viewPackagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPackageView packageview = new FrmPackageView();
            packageview.MdiParent = this;
            packageview.Show();
        }

        private void FrmMainMenu_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
            timer2.Enabled = true;
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolDate.Text = DateTime.Now.ToLongDateString()+"  ";
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            toolTime.Text = DateTime.Now.ToLongTimeString()+"  ";
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
