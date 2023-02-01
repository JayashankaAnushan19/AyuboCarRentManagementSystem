using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AyuboCarRentManagementSystem
{
    public partial class FrmPackageView : Form
    {
        public FrmPackageView()
        {
            InitializeComponent();
        }

        private void rbtnPerDay_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand resultscommand = null;
                MySqlDataAdapter mysqladp = new MySqlDataAdapter();
                DataTable resultstable = new DataTable();
                resultscommand = new MySqlCommand("SELECT * FROM `tb_rentpackages`", cls_Table_Connection.con);
                mysqladp.SelectCommand = resultscommand;
                mysqladp.Fill(resultstable);
                dataGridView1.DataSource = resultstable;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rent Management System", MessageBoxButtons.OK);
            }
        }

        private void rbtnPerWeek_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand resultscommand = null;
                MySqlDataAdapter mysqladp = new MySqlDataAdapter();
                DataTable resultstable = new DataTable();
                resultscommand = new MySqlCommand("SELECT * FROM `tb_dayhirepackages`", cls_Table_Connection.con);
                mysqladp.SelectCommand = resultscommand;
                mysqladp.Fill(resultstable);
                dataGridView1.DataSource = resultstable;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rent Management System", MessageBoxButtons.OK);
            }
        }

        private void rbtnPerMonth_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand resultscommand = null;
                MySqlDataAdapter mysqladp = new MySqlDataAdapter();
                DataTable resultstable = new DataTable();
                resultscommand = new MySqlCommand("SELECT * FROM `tb_longhirepackages`", cls_Table_Connection.con);
                mysqladp.SelectCommand = resultscommand;
                mysqladp.Fill(resultstable);
                dataGridView1.DataSource = resultstable;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rent Management System", MessageBoxButtons.OK);
            }
        }
    }
}
