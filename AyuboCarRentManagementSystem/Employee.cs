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
    
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
            GetDataToGridview();
        }

        private void FrmEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtNIC.Text == "")
            {
                MessageBox.Show("NIC Session Empty... Please Enter Correct NIC", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNIC.Focus();
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Name Session Empty... Please Enter Correct Name", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (txtTelNo.Text == "")
            {
                MessageBox.Show("Tel No. Session Empty... Please Enter Correct Tel No", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelNo.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Address Session Empty... Please Enter Correct Address", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
            }
            
            else if (txtPerDayRent.Text == "")
            {
                MessageBox.Show("Per Day Rent Session Empty... Please Enter Per Day Rent", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPerDayRent.Focus();
                
            }
            else if (txtOverNightRent.Text == "")
            {
                MessageBox.Show("Over Night Rent  Session Empty... Please Enter Over Night Rent", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOverNightRent.Focus();

            }
            else if (MessageBox.Show("Do you want to save details ?", "Save details.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                SaveData();
            }
        }

        private void SaveData()
        {
                try
                {
                cls_Table_Connection.open_connection();
                string myCommand = "INSERT INTO `db_ayuborentmanagementsystem`.`tb_driver` (`d_NIC`, `d_Name`, `d_Tel`, `d_Address`, `d_PerDayRent`, `d_OverNightRent`) VALUES ('" + txtNIC.Text+ "','"+txtName.Text+ "','"+txtTelNo.Text + "','"+txtAddress.Text+ "','"+txtPerDayRent.Text+ "','"+ txtOverNightRent.Text+"');";
                MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                    cmd.ExecuteNonQuery();
                    GetDataToGridview();
                    MessageBox.Show("Record Added", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Rent Management System", MessageBoxButtons.OK);
                }

                finally
                {
                    cls_Table_Connection.close_connection();
                    ClearAll();
                }
            }
        private void GetDataToGridview()
        {
            try
            {
                MySqlCommand resultscommand = null;
                MySqlDataAdapter mysqladp = new MySqlDataAdapter();
                DataTable resultstable = new DataTable();
                resultscommand = new MySqlCommand("SELECT * FROM `tb_driver`", cls_Table_Connection.con);
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

        private void ClearAll()
        {
            txtNIC.Clear();
            txtName.Clear();
            txtTelNo.Clear();
            txtAddress.Clear();
            txtOverNightRent.Clear();
            txtPerDayRent.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int SelectedRow;
                SelectedRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[SelectedRow];
                txtNIC.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtTelNo.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtPerDayRent.Text = row.Cells[4].Value.ToString();
                txtOverNightRent.Text = row.Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtNIC.Text == "")
            {
                MessageBox.Show("NIC Session Empty... Please Enter Correct NIC", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNIC.Focus();
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Name Session Empty... Please Enter Correct Name", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (txtTelNo.Text == "")
            {
                MessageBox.Show("Tel No. Session Empty... Please Enter Correct Tel No", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelNo.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Address Session Empty... Please Enter Correct Address", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
            }

            else if (txtPerDayRent.Text == "")
            {
                MessageBox.Show("Per Day Rent Session Empty... Please Enter Per Day Rent", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPerDayRent.Focus();

            }
            else if (txtOverNightRent.Text == "")
            {
                MessageBox.Show("Over Night Rent  Session Empty... Please Enter Over Night Rent", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOverNightRent.Focus();

            }
            else if (MessageBox.Show("Do you want to update details ?", "Update details.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "UPDATE `db_ayuborentmanagementsystem`.`tb_driver` SET `d_NIC`='" + txtNIC.Text+ "',`d_Name`='" + txtName.Text + "',`d_Tel`='" + txtTelNo.Text + "',`d_Address`='" + txtAddress.Text + "',`d_PerDayRent`='" + txtPerDayRent.Text + "',`d_OverNightRent`='" + txtOverNightRent.Text + "' WHERE `d_NIC`='" + txtNIC.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                    cmd.ExecuteNonQuery();
                    GetDataToGridview();
                    MessageBox.Show("Record Updated", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Rent Management System", MessageBoxButtons.OK);
                }
                finally
                {
                    cls_Table_Connection.close_connection();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Do you want to delete record?", "Delete record !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "DELETE FROM `tb_driver` WHERE `d_NIC`='" + txtNIC.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                    cmd.ExecuteNonQuery();
                    GetDataToGridview();
                    MessageBox.Show("Record Deleted", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Rent Management System");
                }
                finally
                {
                    cls_Table_Connection.close_connection();
                }
            }
        }
    }
    
}
