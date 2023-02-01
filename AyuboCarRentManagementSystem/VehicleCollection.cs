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
    public partial class FrmVehicleCollection : Form
    {
        public FrmVehicleCollection()
        {
            InitializeComponent();
        }

        private void FrmVehicleCollection_Load(object sender, EventArgs e)
        {
            GetVehicleTypesToCbox();
            GetDataToGridview();
            LoadTypesToGridView();
        }
        private void GetVehicleTypesToCbox()
        {
            try
            {
                string query = "SELECT `vc_VehicleType` FROM `tb_vehicletype`";
                MySqlCommand Mycom = new MySqlCommand(query, cls_Table_Connection.con);
                MySqlDataReader Myreader;
                cls_Table_Connection.open_connection();
                Myreader = Mycom.ExecuteReader();
                if (Myreader.HasRows)
                {
                    while (Myreader.Read())
                    {
                        string vehicletype = Myreader.GetString(0).ToString();
                        cmdVehicleType.Items.Add(vehicletype);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cls_Table_Connection.close_connection();
            }
        }
        private void SaveDetails()
        {
            if (txtVehicleNo.Text == "")
            {
                MessageBox.Show("Empty Value..", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "INSERT INTO `db_ayuborentmanagementsystem`.`tb_vehiclecollection`( `vc_VehicleType`, `vc_VehicleNo`) VALUES ('" + cmdVehicleType.Text + "','" + txtVehicleNo.Text + "');";
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
        }

        private void UpdateDetails()
        {
            if (txtVehicleNo.Text == "")
            {
                MessageBox.Show("Empty Value..", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "UPDATE `db_ayuborentmanagementsystem`.`tb_vehiclecollection` SET `vc_VehicleType`='" + cmdVehicleType.Text + "',`vc_VehicleNo`='" + txtVehicleNo.Text + "' WHERE `vc_VehicleType`='" + cmdVehicleType.Text + "'";
                    //UPDATE `tb_vehiclecollection` SET `vc_VehicleType`=[value-1],`vc_VehicleNo`=[value-2] WHERE
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

        private void GetDataToGridview()
        {
            try
            {
                MySqlCommand resultscommand = null;
                MySqlDataAdapter mysqladp = new MySqlDataAdapter();
                DataTable resultstable = new DataTable();
                resultscommand = new MySqlCommand("SELECT * FROM `db_ayuborentmanagementsystem`.`tb_vehiclecollection`", cls_Table_Connection.con);
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveDetails();
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDetails();
        }

        private void ClearAll()
        {
            cmdVehicleType.ResetText();
            txtVehicleNo.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int SelectedRow;
                SelectedRow = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[SelectedRow];
                cmdVehicleType.Text = row.Cells[0].Value.ToString();
                txtVehicleNo.Text = row.Cells[1].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DeleteDetails();
        }
        private void DeleteDetails()
        {
            if (MessageBox.Show("Do you want to delete record?", "Delete record !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "DELETE FROM `db_ayuborentmanagementsystem`.`tb_vehiclecollection` WHERE `vc_VehicleNo`='" + txtVehicleNo.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                    cmd.ExecuteNonQuery();
                    GetDataToGridview();
                    MessageBox.Show("Record Deleted", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void LoadTypesToGridView()
        {
            try
            {
                MySqlCommand resultscommand = null;
                MySqlDataAdapter mysqladp = new MySqlDataAdapter();
                DataTable resultstable = new DataTable();
                resultscommand = new MySqlCommand("SELECT * FROM `db_ayuborentmanagementsystem`.`tb_vehicletype`", cls_Table_Connection.con);
                mysqladp.SelectCommand = resultscommand;
                mysqladp.Fill(resultstable);
                dataGridView2.DataSource = resultstable;
                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rent Management System", MessageBoxButtons.OK);
            }
        }
    }
}
