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
    public partial class FrmReservation : Form
    {
        //With Driver         Without Driver
        public FrmReservation()
        {
            InitializeComponent();
        }

        private void lblVehicleType_Click(object sender, EventArgs e)
        {

        }

        private void FrmReservation_Load(object sender, EventArgs e)
        {
            
            GetDataToGridview();
            GetVehicleTypesToCbox();

        }



        private void cmbPackageType_TextChanged(object sender, EventArgs e)
        {

            if (cmbPackageType.SelectedItem == "Day Hire")
            {
                cmbDriverStatus.SelectedIndex = 0;
                cmbDriverStatus.Enabled = false;
                return;

            }
            else if (cmbPackageType.SelectedItem == "Long Hire")
            {
                cmbDriverStatus.SelectedIndex = 0;
                cmbDriverStatus.Enabled = false;
            }
            else
            {
                cmbDriverStatus.SelectedIndex = 0;
                cmbDriverStatus.Enabled = true;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Table_Connection.open_connection();
                string CCN = "SELECT `vc_VehicleType` FROM `tb_vehicletype`";
                MySqlDataAdapter da = new MySqlDataAdapter(CCN, cls_Table_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("vc_VehicleType='" + cmbVehicleType.Text + "'");  //Get data from user input for check
                DataRow dr = returnrow[0];

                cls_Table_Connection.open_connection();
                string CCN1 = "SELECT * FROM `tb_customer`";
                MySqlDataAdapter da1 = new MySqlDataAdapter(CCN1, cls_Table_Connection.con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                DataRow[] returnrow1 = ds1.Tables[0].Select("c_NIC='" + txtCustomerId.Text + "'");  //Get data from user input for check
                DataRow dr1 = returnrow[0];

                if (txtCustomerId.Text == "")
                {
                    MessageBox.Show("Enter Customer ID...", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtCustomerId.Text != (dr["c_NIC"].ToString()))  //check validation
                {
                    MessageBox.Show("Invalid Customer... Please register customer details before reservation.", "Invalid ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if(MessageBox.Show("Do you want to register customer?","Register",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
                    {
                        FrmCustomer Cus = new FrmCustomer();
                        Cus.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Can not reserve without register !!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        this.Close();
                    }
                }
                else if (cmbPackageType.Text == "")
                {
                    MessageBox.Show("Enter Package Type...", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbVehicleType.Text == "")
                {
                    MessageBox.Show("Enter Vehicle Type...", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbDriverStatus.Text == "")
                {
                    MessageBox.Show("Enter Driver Status...", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbPackageType.SelectedItem != "Rent" || cmbPackageType.SelectedItem != "Day Hire" || cmbPackageType.SelectedItem != "Long Hire")
                {
                }
                else if (cmbVehicleType.Text != (dr["vc_VehicleType"].ToString()))  //check validation
                {
                    MessageBox.Show("Invalid Vehicle Type...", "Invalid ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                

                SaveData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rent Management System", MessageBoxButtons.OK);
            }

        }

        private void SaveData()
        {

            try
            {

                cls_Table_Connection.open_connection();
                string myCommand = "INSERT INTO `db_ayuborentmanagementsystem`.`tb_reservation`(`r_CusNIC`, `r_PackageID`, `r_VeicleType`, `r_DriverStatus`, `r_Date`) VALUES ('" + txtCustomerId.Text + "','" + cmbPackageType.Text + "','" + cmbVehicleType.Text + "','" + cmbDriverStatus.Text + "','" + dateTimePicker.Text + "');";
                MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                cmd.ExecuteNonQuery();
                GetDataToGridview();
                
                string sql = "SELECT * FROM `db_ayuborentmanagementsystem`.`tb_reservation`";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cls_Table_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("r_CusNIC='" + txtCustomerId.Text + "' AND r_PackageID='" + cmbPackageType.Text + "' AND r_VeicleType='" + cmbVehicleType.Text + "'");
                DataRow dr = returnrow[0];
                string ID = (dr["r_ID"].ToString());

                MessageBox.Show("Your Reservation ID = "+ID+"  "+"Record Added", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        private void UpdateDetails()
        {

            try
            {
                cls_Table_Connection.open_connection();
                string myCommand = "UPDATE `db_ayuborentmanagementsystem`.`tb_reservation` SET `r_CusNIC`='" + txtCustomerId.Text + "',`r_PackageID`='" + cmbPackageType.Text + "',`r_VeicleType`='" + cmbVehicleType.Text + "',`r_DriverStatus`='" + cmbDriverStatus.Text + "',`r_Date`='" + dateTimePicker.Text + "' WHERE `r_CusNIC`='" + txtCustomerId.Text + "' AND `r_PackageID`='" + cmbPackageType.Text + "' AND `r_VeicleType`='" + cmbVehicleType.Text + "' "; 
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

        private void ClearAll()
        {
            txtCustomerId.Clear();
            cmbPackageType.Text = "";
            cmbVehicleType.Text = "";
            cmbDriverStatus.Text = "";
            dateTimePicker.ResetText();

        }

        private void GetDataToGridview()
        {
            try
            {
                MySqlCommand resultscommand = null;
                MySqlDataAdapter mysqladp = new MySqlDataAdapter();
                DataTable resultstable = new DataTable();
                resultscommand = new MySqlCommand("SELECT * FROM `db_ayuborentmanagementsystem`.`tb_reservation`", cls_Table_Connection.con);
                mysqladp.SelectCommand = resultscommand;
                mysqladp.Fill(resultstable);
                dataGridView.DataSource = resultstable;
                dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rent Management System", MessageBoxButtons.OK);
            }
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
                        cmbVehicleType.Items.Add(vehicletype);
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

        private void DeleteDetails()
        {
            if (MessageBox.Show("Do you want to delete record?", "Delete record !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "DELETE FROM `db_ayuborentmanagementsystem`.`tb_reservation` WHERE `r_CusNIC`='" + txtCustomerId.Text + "' AND `r_PackageID`='" + cmbPackageType.Text + "' AND `r_VeicleType`='" + cmbVehicleType.Text + "'";
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

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                int SelectedRow;
                SelectedRow = e.RowIndex;
                DataGridViewRow row = dataGridView.Rows[SelectedRow];
                txtReservationID.Text = row.Cells[0].Value.ToString();
                txtCustomerId.Text = row.Cells[1].Value.ToString();
                cmbPackageType.Text = row.Cells[2].Value.ToString();
                cmbVehicleType.Text = row.Cells[3].Value.ToString();
                cmbDriverStatus.Text = row.Cells[4].Value.ToString();
                dateTimePicker.Text = row.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cls_Table_Connection.open_connection();
                string CCN = "SELECT `vc_VehicleType` FROM `tb_vehicletype`";
                MySqlDataAdapter da = new MySqlDataAdapter(CCN, cls_Table_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("vc_VehicleType='" + cmbVehicleType.Text + "'");  //Get data from user input for check
                DataRow dr = returnrow[0];


                if (txtCustomerId.Text == "")
                {
                    MessageBox.Show("Enter Customer ID...", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbPackageType.Text == "")
                {
                    MessageBox.Show("Enter Package Type...", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbVehicleType.Text == "")
                {
                    MessageBox.Show("Enter Vehicle Type...", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbDriverStatus.Text == "")
                {
                    MessageBox.Show("Enter Driver Status...", "Empty value", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (cmbPackageType.SelectedItem != "Rent" || cmbPackageType.SelectedItem != "Day Hire" || cmbPackageType.SelectedItem != "Long Hire")
                {
                }
                else if (cmbVehicleType.Text != (dr["vc_VehicleType"].ToString()))  //check validation
                {
                    MessageBox.Show("Invalid Vehicle Type...", "Invalid ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UpdateDetails();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Rent Management System", MessageBoxButtons.OK);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteDetails();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtReservationID.Clear();
            txtCustomerId.Clear();
            cmbPackageType.Text = "";
            cmbVehicleType.Text = "";
            cmbDriverStatus.Text = "";
            dateTimePicker.ResetText();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
