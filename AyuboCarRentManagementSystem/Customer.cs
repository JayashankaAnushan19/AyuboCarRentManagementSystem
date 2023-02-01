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
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
            GetDataToGridview();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("ID Session Empty... Please Enter Correct ID", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Name Session Empty... Please Enter Correct Name", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Address Session Empty... Please Enter Correct Address", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
            }
            else if (txtTelNo.Text == "")
            {
                MessageBox.Show("Tel No. Session Empty... Please Enter Correct Tel No", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelNo.Focus();
            }
            else if (cboxGender.Text == "")
            {
                MessageBox.Show("Gender Session Empty... Please Enter Correct Gender", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboxGender.Focus();
            }
            else if (cboxGender.Text != "Male")
            {
                if (cboxGender.Text != "Female")
                {
                    MessageBox.Show("You Entered Gender is invalid... Please Select Correct Gender", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboxGender.Focus();
                    return;
                }
            }
            else if (MessageBox.Show("Do you want to save details ?", "Save details.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                SaveDetails();
            }

        }

        private void SaveDetails()
        {
            try
            {
                cls_Table_Connection.open_connection();
                string myCommand = "INSERT INTO `db_ayuborentmanagementsystem`.`tb_customer` (`c_NIC`, `c_Name`, `c_Gender`, `c_Address`,`c_Tel`) VALUES ('" + txtId.Text + "', '" + txtName.Text + "', '" + cboxGender.Text + "', '" + txtAddress.Text + "','" + txtTelNo.Text + "');";
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

        private void FrmCustomer_Load(object sender, EventArgs e)
        {

        }
        private void ClearAll()
        {
            txtId.Clear();
            txtName.Clear();
            txtTelNo.Clear();
            txtAddress.Clear();
            cboxGender.ResetText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
        private void GetDataToGridview()
        {
            try
            {
                MySqlCommand resultscommand = null;
                MySqlDataAdapter mysqladp = new MySqlDataAdapter();
                DataTable resultstable = new DataTable();
                resultscommand = new MySqlCommand("select * from tb_customer", cls_Table_Connection.con);
                mysqladp.SelectCommand = resultscommand;
                mysqladp.Fill(resultstable);
                dataGridView1.DataSource = resultstable;
                dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rent Management System",MessageBoxButtons.OK);
            }
        }
        private void LoadFindedData()
        {
            try
            {
                cls_Table_Connection.open_connection();

                string sql = "select * from tb_customer;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cls_Table_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("c_NIC='" + txtId.Text + "'");
                DataRow dr = returnrow[0];
                txtName.Text = (dr["c_Name"].ToString());
                cboxGender.Text = (dr["c_Gender"].ToString());
                txtAddress.Text = (dr["c_Address"].ToString());
                txtTelNo.Text = (dr["c_Tel"].ToString());

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

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        { }

        private void txtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadFindedData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete record?", "Delete record !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "DELETE FROM `tb_customer` WHERE `c_NIC`='" + txtId.Text + "'";
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int SelectedRow;
                SelectedRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[SelectedRow];
                txtId.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                cboxGender.Text = row.Cells[2].Value.ToString();
                txtAddress.Text = row.Cells[3].Value.ToString();
                txtTelNo.Text = row.Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUpdate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("ID Session Empty... Please Enter Correct ID", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtId.Focus();
            }
            else if (txtName.Text == "")
            {
                MessageBox.Show("Name Session Empty... Please Enter Correct Name", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("Address Session Empty... Please Enter Correct Address", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Focus();
            }
            else if (txtTelNo.Text == "")
            {
                MessageBox.Show("Tel No. Session Empty... Please Enter Correct Tel No", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelNo.Focus();
            }
            else if (cboxGender.Text == "")
            {
                MessageBox.Show("Gender Session Empty... Please Enter Correct Gender", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboxGender.Focus();
            }
            else if (cboxGender.Text != "Male")
            {
                if (cboxGender.Text != "Female")
                {
                    MessageBox.Show("You Entered Gender is invalid... Please Select Correct Gender", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cboxGender.Focus();
                    return;
                }
            }
            else if (MessageBox.Show("Do you want to update details ?", "Update details.", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "UPDATE `db_ayuborentmanagementsystem`.`tb_customer` SET `c_NIC`='" + txtId.Text + "', `c_Name`='" + txtName.Text + "',`c_Gender`='" + cboxGender.Text + "',`c_Address`='" + txtAddress.Text + "',`c_Tel`='" + txtTelNo.Text + "' WHERE `c_NIC`='" + txtId.Text + "'";
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
    } 
    
}

