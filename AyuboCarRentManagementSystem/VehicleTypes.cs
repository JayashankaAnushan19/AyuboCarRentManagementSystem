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
    public partial class FrmVehicleTypes : Form
    {
        public FrmVehicleTypes()
        {
            InitializeComponent();
        }

        private void EmptyMSG(string Item)
        {
            MessageBox.Show(Item + " Session Empty", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (rbtnPerDay.Checked == true)
            {
                RentSaveDetails();
            }
            else if (rbtnPerWeek.Checked == true)
            {
                DayHireSaveDetails();
            }
            else if (rbtnPerMonth.Checked == true)
            {
                LongHireSaveDetails();
            }
            else
            {
                MessageBox.Show("Wrong Input Please Select Valid Package Type..", "Select..", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RentSaveDetails()
        {
            if (txtName.Text == "")
            {
                EmptyMSG("Name");
                txtName.Focus();
            }
            else if (txtVehicleType.Text == "")
            {
                EmptyMSG("Vehicle Type");
                txtVehicleType.Focus();
            }
            else if (txtPerDayRent.Text == "")
            {
                EmptyMSG("Per Day Rent");
                txtPerDayRent.Focus();
            }
            else if (txtPerWeekRent.Text == "")
            {
                EmptyMSG("Per Week Rent");
                txtPerWeekRent.Focus();
            }
            else if (txtPerMonthRent.Text == "")
            {
                EmptyMSG("Per Month Rent");
                txtPerMonthRent.Focus();
            }
            else if (txtMaxKMLimitRent.Text == "")
            {
                EmptyMSG("Max KM Limit");
                txtMaxKMLimitRent.Focus();
            }
            else if (txtExtraKMChargeForRent.Text == "")
            {
                EmptyMSG("Extra KM Charge");
                txtExtraKMChargeForRent.Focus();
            }
            else
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "INSERT INTO `db_ayuborentmanagementsystem`.`tb_rentpackages`(`rp_Name`, `rp_VehType`, `rp_PerDayRent`, `rp_PerWeekRent`, `rp_PerMonthRent`, `rp_MaxKMLimit`, `rp_ExtraKMCharge`) VALUES ('" + txtName.Text + "','" + txtVehicleType.Text + "','" + txtPerDayRent.Text + "','" + txtPerWeekRent.Text + "','" + txtPerMonthRent.Text + "','" + txtMaxKMLimitRent.Text + "','" + txtExtraKMChargeForRent.Text + "');";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                    cmd.ExecuteNonQuery();
                    VehicleTypeAdd();
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

        private void DayHireSaveDetails()
        {
            if (txtName.Text == "")
            {
                EmptyMSG("Name");
                txtName.Focus();
            }
            else if (txtVehicleType.Text == "")
            {
                EmptyMSG("Vehicle Type");
                txtVehicleType.Focus();
            }

            else if (txtMaxKMLimitForHire.Text == "")
            {
                EmptyMSG("Max KM Limit");
                txtMaxDayKMLimit.Focus();
            }
            else if (txtMaxTimeLimit.Text == "")
            {
                EmptyMSG("Max Time Limit");
                txtMaxWeekKMLimit.Focus();
            }
            else if (txtExtraKMCharge.Text == "") //
            {
                EmptyMSG("Extra KM Charge");
                txtExtraKMCharge.Focus();
            }
            else if (txtExtraHourCharge.Text == "") //
            {
                EmptyMSG("Extra Hour Charge");
                txtExtraHourCharge.Focus();
            }
            else if (txtBasicCharge.Text == "") //
            {
                EmptyMSG("Basic Charge");
                txtExtraHourCharge.Focus();
            }
            else
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "INSERT INTO `db_ayuborentmanagementsystem`.`tb_dayhirepackages`(`dhp_Name`, `dhp_Vehtype`, `dhp_ExtraKMCharge`, `dhp_ExtraHourCharge`, `dhp_MaxTime`, `dhp_MaxKMLimit`, `dhp_BasicCharge`) VALUES ('" + txtName.Text + "','" + txtVehicleType.Text + "','" + txtExtraKMCharge.Text + "','" + txtExtraHourCharge.Text + "','" + txtMaxTimeLimit.Text + "','" + txtMaxKMLimitForHire.Text + "','" + txtBasicCharge.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                    cmd.ExecuteNonQuery();
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

        private void LongHireSaveDetails()
        {
            if (txtName.Text == "")
            {
                EmptyMSG("Name");
                txtName.Focus();
            }
            else if (txtVehicleType.Text == "")
            {
                EmptyMSG("Vehicle Type");
                txtVehicleType.Focus();
            }

            else if (txtMaxKMLimitForHire.Text == "")
            {
                EmptyMSG("Max KM Limit");
                txtMaxDayKMLimit.Focus();
            }
            else if (txtMaxTimeLimit.Text == "")
            {
                EmptyMSG("Max Time Limit");
                txtMaxWeekKMLimit.Focus();
            }
            else if (txtExtraKMCharge.Text == "") //
            {
                EmptyMSG("Extra KM Charge");
                txtExtraKMCharge.Focus();
            }
            else if (txtExtraHourCharge.Text == "") //
            {
                EmptyMSG("Extra Hour Charge");
                txtExtraHourCharge.Focus();
            }
            else if (txtBasicCharge.Text == "") //
            {
                EmptyMSG("Basic Charge");
                txtExtraHourCharge.Focus();
            }
            else
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "INSERT INTO `db_ayuborentmanagementsystem`.`tb_longhirepackages`(`lhp_Name`, `lhp_Vehtype`, `lhp_extrakmCharge`, `lhp_extrahourcharge`, `lhp_overnightcharge`, `lhp_MaxTimeLimit`, `lhp_MaxKMLimit`, `lhp_Basic`) VALUES ('" + txtName.Text + "','" + txtVehicleType.Text + "','" + txtExtraKMCharge.Text + "','" + txtExtraHourCharge.Text + "','" + txtOverNightCharge.Text + "','" + txtMaxTimeLimit.Text + "','" + txtMaxKMLimitForHire.Text + "','" + txtBasicCharge.Text + "');";
                    //INSERT INTO `tb_longhirepackages`                                                                                                                                                                                                                (`lhp_Name`,                 `lhp_Vehtype`,           `lhp_extrakmCharge`,            `lhp_extrahourcharge`,           `lhp_overnightcharge`,             `lhp_MaxTimeLimit`,               `lhp_MaxKMLimit`,                    `lhp_Basic`) VALUES ([value-1],[value-2],[value-3],[value-4],[value-5],[value-6],[value-7],[value-8])
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                    cmd.ExecuteNonQuery();
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

        private void VehicleTypeAdd()
        {
            try
            {
                cls_Table_Connection.open_connection();
                string myCommand = "INSERT INTO `db_ayuborentmanagementsystem`.`tb_vehicletype`(`vc_ID`, `vc_VehicleType`) VALUES ('"+txtVehicleID.Text+"','"+txtVehicleType.Text+"');";
                MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                cmd.ExecuteNonQuery();
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

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbtnPerDay_Click(object sender, EventArgs e)
        {
            txtMaxDayKMLimit.Enabled = false;
            txtMaxWeekKMLimit.Enabled = false;
            txtMaxMonthKMLimit.Enabled = false;
            txtExtraKMCharge.Enabled = true;
            txtExtraHourCharge.Enabled = true;
            txtOverNightCharge.Enabled = false;
            txtMaxTimeLimit.Enabled = false;
            txtBasicCharge.Enabled = false;
            txtMaxKMLimitRent.Enabled = true;
            txtExtraKMChargeForRent.Enabled = true;
            txtMaxKMLimitForHire.Enabled = false;
            txtExtraKMCharge.Enabled = false;
            txtExtraHourCharge.Enabled = false;

        }

        private void rbtnPerWeek_Click(object sender, EventArgs e)
        {
            txtPerDayRent.Enabled = false;
            txtPerWeekRent.Enabled = false;
            txtPerMonthRent.Enabled = false;

            txtMaxKMLimitRent.Enabled = false;
            txtExtraKMChargeForRent.Enabled = false; 
            
            txtMaxTimeLimit.Enabled = true;
            txtMaxKMLimitForHire.Enabled = true;
            txtBasicCharge.Enabled = true;

            txtMaxDayKMLimit.Enabled = false;
            txtMaxWeekKMLimit.Enabled = false;
            txtMaxMonthKMLimit.Enabled = false;

            txtExtraKMCharge.Enabled = true;
            txtExtraHourCharge.Enabled = true;

            txtOverNightCharge.Enabled = false;

        }

        private void rbtnPerMonth_Click(object sender, EventArgs e)
        {
            txtPerDayRent.Enabled = false;
            txtPerWeekRent.Enabled = false;
            txtPerMonthRent.Enabled = false;
            txtMaxKMLimitRent.Enabled = false;
            txtExtraKMChargeForRent.Enabled = false;
            txtMaxTimeLimit.Enabled = true;
            txtMaxKMLimitForHire.Enabled = true;
            txtBasicCharge.Enabled = true;
            txtMaxDayKMLimit.Enabled = false;
            txtMaxWeekKMLimit.Enabled = false;
            txtMaxMonthKMLimit.Enabled = false;
            txtExtraKMCharge.Enabled = true;
            txtExtraHourCharge.Enabled = true;
            txtOverNightCharge.Enabled = true;
        }

        private void FrmVehicleTypes_Load(object sender, EventArgs e)
        {

        }
        private void ClearAll()
        {
            txtName.Clear();
            txtVehicleID.Clear();
            txtVehicleType.Clear();
            txtPerDayRent.Clear();
            txtPerWeekRent.Clear();
            txtPerMonthRent.Clear();
            txtMaxDayKMLimit.Clear();
            txtMaxWeekKMLimit.Clear();
            txtMaxMonthKMLimit.Clear();
            txtExtraKMCharge.Clear();
            txtExtraHourCharge.Clear();
            txtMaxKMLimitRent.Clear();
            txtExtraKMChargeForRent.Clear();
            txtOverNightCharge.Clear();
            txtMaxKMLimitForHire.Clear();
            txtMaxTimeLimit.Clear();
            txtBasicCharge.Clear();
            txtMaxTimeLimitLongHire.Clear();
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbtnPerDay.Checked == true)
            {
                RentUpdate();
            }
            else if (rbtnPerWeek.Checked == true)
            {
                DayHireUpdate();
            }
            else if (rbtnPerMonth.Checked == true)
            {
                LongHireUpdate();
            }
            else
            {
                MessageBox.Show("Error....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearAll();
            }
        }

        private void LoadRentData()
        {
            try
            {
                cls_Table_Connection.open_connection();

                string sql = "SELECT * FROM `tb_rentpackages`;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cls_Table_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("rp_Name='" + txtName.Text + "'");
                DataRow dr = returnrow[0];
                
                txtName.Text = (dr["rp_Name"].ToString());
                txtVehicleType.Text = (dr["rp_VehType"].ToString());
                txtPerDayRent.Text = (dr["rp_PerDayRent"].ToString());
                txtPerWeekRent.Text = (dr["rp_PerWeekRent"].ToString());
                txtPerMonthRent.Text = (dr["rp_PerMonthRent"].ToString());
                txtMaxKMLimitRent.Text = (dr["rp_MaxKMLimit"].ToString());
                txtExtraKMChargeForRent.Text = (dr["rp_ExtraKMCharge"].ToString());

                string sql1 = "SELECT * FROM `tb_vehicletype`;";
                MySqlDataAdapter da1 = new MySqlDataAdapter(sql1, cls_Table_Connection.con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                DataRow[] returnrow1 = ds1.Tables[0].Select("vc_VehicleType='" + txtVehicleType.Text + "'");
                DataRow dr1 = returnrow1[0];

                txtVehicleID.Text = (dr1["vc_ID"].ToString());

            }
            catch 
            {
                
            }
            finally
            {
                cls_Table_Connection.close_connection();
            }
        }

        private void LoadDayHireData()
        {
            try
            {
                cls_Table_Connection.open_connection();

                string sql = "SELECT * FROM `tb_dayhirepackages`;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cls_Table_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("dhp_Name='" + txtName.Text + "'");
                DataRow dr = returnrow[0];
                
                txtVehicleType.Text = (dr["dhp_Vehtype"].ToString());
                txtExtraKMCharge.Text = (dr["dhp_ExtraKMCharge"].ToString());
                txtExtraHourCharge.Text = (dr["dhp_ExtraHourCharge"].ToString());
                txtMaxTimeLimit.Text = (dr["dhp_MaxTime"].ToString());
                txtMaxKMLimitForHire.Text = (dr["dhp_MaxKMLimit"].ToString());
                txtBasicCharge.Text = (dr["dhp_BasicCharge"].ToString());
                

                string sql1 = "SELECT * FROM `tb_vehicletype`;";
                MySqlDataAdapter da1 = new MySqlDataAdapter(sql1, cls_Table_Connection.con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                DataRow[] returnrow1 = ds1.Tables[0].Select("vc_VehicleType='" + txtVehicleType.Text + "'");
                DataRow dr1 = returnrow1[0];

                txtVehicleID.Text = (dr1["vc_ID"].ToString());

            }
            catch
            {

            }
            finally
            {
                cls_Table_Connection.close_connection();
            }
        }

        private void LoadLongHireData()
        {
            try
            {
                cls_Table_Connection.open_connection();

                string sql = "SELECT * FROM `tb_longhirepackages`;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cls_Table_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("lhp_Name='" + txtName.Text + "'");
                DataRow dr = returnrow[0];
                
                txtName.Text = (dr["lhp_Name"].ToString());
                txtVehicleType.Text = (dr["lhp_Vehtype"].ToString());
                txtPerDayRent.Text = (dr["lhp_Perdayrent"].ToString());
                txtPerWeekRent.Text = (dr["lhp_perweekrent"].ToString());
                txtPerMonthRent.Text = (dr["lhp_permonthrent"].ToString());
                txtMaxDayKMLimit.Text = (dr["lhp_daykmlimit"].ToString());
                txtMaxWeekKMLimit.Text = (dr["lhp_weekkmlimit"].ToString());
                txtMaxMonthKMLimit.Text = (dr["lhp_permonthkmlimit"].ToString());
                txtExtraKMCharge.Text = (dr["lhp_extrakmCharge"].ToString());
                txtExtraHourCharge.Text = (dr["lhp_extradaycharge"].ToString());
                txtOverNightCharge.Text = (dr["lhp_overnightcharge"].ToString());

                string sql1 = "SELECT * FROM `tb_vehicletype`;";
                MySqlDataAdapter da1 = new MySqlDataAdapter(sql1, cls_Table_Connection.con);
                DataSet ds1 = new DataSet();
                da1.Fill(ds1);
                DataRow[] returnrow1 = ds1.Tables[0].Select("vc_VehicleType='" + txtVehicleType.Text + "'");
                DataRow dr1 = returnrow1[0];

                txtVehicleID.Text = (dr1["vc_ID"].ToString());

            }
            catch
            {

            }
            finally
            {
                cls_Table_Connection.close_connection();
            }
        }
        private void RentUpdate()
        {
            if (txtName.Text == "")
            {
                EmptyMSG("Name");
                txtName.Focus();
            }
            else if (txtVehicleType.Text == "")
            {
                EmptyMSG("Vehicle Type");
                txtVehicleType.Focus();
            }
            else if (txtPerDayRent.Text == "")
            {
                EmptyMSG("Per Day Rent");
                txtPerDayRent.Focus();
            }
            else if (txtPerWeekRent.Text == "")
            {
                EmptyMSG("Per Week Rent");
                txtPerWeekRent.Focus();
            }
            else if (txtPerMonthRent.Text == "")
            {
                EmptyMSG("Per Month Rent");
                txtPerMonthRent.Focus();
            }
            else if (txtMaxKMLimitRent.Text == "")
            {
                EmptyMSG("Max KM Limit");
                txtMaxKMLimitRent.Focus();
            }
            else if (txtExtraKMChargeForRent.Text == "")
            {
                EmptyMSG("Extra KM Charge");
                txtExtraKMChargeForRent.Focus();
            }
            else
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "UPDATE `db_ayuborentmanagementsystem`.`tb_rentpackages` SET `rp_Name`='" + txtName.Text + "',`rp_VehType`='" + txtVehicleType.Text + "',`rp_PerDayRent`='" + txtPerDayRent.Text + "',`rp_PerWeekRent`='" + txtPerWeekRent.Text + "',`rp_PerMonthRent`='" + txtPerMonthRent.Text + "',`rp_MaxKMLimit`='" + txtMaxKMLimitRent.Text + "',`rp_ExtraKMCharge`='" + txtExtraKMChargeForRent.Text + "' WHERE `rp_Name`='" + txtName.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void DayHireUpdate()
        {
            if (txtName.Text == "")
            {
                EmptyMSG("Name");
                txtName.Focus();
            }
            else if (txtVehicleType.Text == "")
            {
                EmptyMSG("Vehicle Type");
                txtVehicleType.Focus();
            }
            else if (txtPerDayRent.Text == "")
            {
                EmptyMSG("Per Day Rent");
                txtPerDayRent.Focus();
            }
            else if (txtPerWeekRent.Text == "")
            {
                EmptyMSG("Per Week Rent");
                txtPerWeekRent.Focus();
            }
            else if (txtPerMonthRent.Text == "")
            {
                EmptyMSG("Per Month Rent");
                txtPerMonthRent.Focus();
            }
            else if (txtMaxKMLimitRent.Text == "")
            {
                EmptyMSG("Max KM Limit");
                txtMaxKMLimitRent.Focus();
            }
            else if (txtExtraKMChargeForRent.Text == "")
            {
                EmptyMSG("Extra KM Charge");
                txtExtraKMChargeForRent.Focus();
            }
            else
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "UPDATE `db_ayuborentmanagementsystem`.`tb_dayhirepackages` SET `dhp_Name`='"+txtName.Text+ "',`dhp_Vehtype`='" + txtVehicleType.Text + "',`dhp_Perdayrent`='" + txtPerDayRent.Text + "',`dhp_Perweekrent`='" + txtPerWeekRent.Text + "',`dhp_Permonthrent`='" + txtPerMonthRent.Text + "',`dhp_DayKMLimit`='" + txtMaxDayKMLimit.Text + "',`dhp_WeekKMLimit`='" + txtMaxWeekKMLimit.Text + "',`dhp_MonthKMLimit`='" + txtMaxMonthKMLimit.Text + "',`dhp_ExtraKMCharge`='" + txtExtraKMCharge.Text + "',`dhp_ExtraHourCharge`='" + txtExtraHourCharge.Text + "' WHERE `dhp_Name`='" + txtName.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void LongHireUpdate()
        {
            if (txtName.Text == "")
            {
                EmptyMSG("Name");
                txtName.Focus();
            }
            else if (txtVehicleType.Text == "")
            {
                EmptyMSG("Vehicle Type");
                txtVehicleType.Focus();
            }

            else if (txtMaxKMLimitForHire.Text == "")
            {
                EmptyMSG("Max KM Limit");
                txtMaxDayKMLimit.Focus();
            }
            else if (txtMaxTimeLimit.Text == "")
            {
                EmptyMSG("Max Time Limit");
                txtMaxWeekKMLimit.Focus();
            }
            else if (txtExtraKMCharge.Text == "") //
            {
                EmptyMSG("Extra KM Charge");
                txtExtraKMCharge.Focus();
            }
            else if (txtExtraHourCharge.Text == "") //
            {
                EmptyMSG("Extra Hour Charge");
                txtExtraHourCharge.Focus();
            }
            else if (txtBasicCharge.Text == "") //
            {
                EmptyMSG("Basic Charge");
                txtExtraHourCharge.Focus();
            }
            else
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "UPDATE `db_ayuborentmanagementsystem`.`tb_longhirepackages` SET `lhp_Name`='"+txtName.Text+ "',`lhp_Vehtype`='" + txtVehicleType.Text + "',`lhp_extrakmCharge`='" + txtExtraKMCharge.Text + "',`lhp_extrahourcharge`='" + txtExtraHourCharge.Text + "',`lhp_overnightcharge`='" + txtOverNightCharge.Text + "',`lhp_MaxTimeLimit`='" + txtMaxTimeLimitLongHire.Text + "',`lhp_MaxKMLimit`='" + txtMaxKMLimitForHire.Text + "',`lhp_Basic`='" + txtBasicCharge.Text + "' WHERE `lhp_Name`='" + txtName.Text + "'";
                    //UPDATE `tb_longhirepackages` SET `lhp_Name`=[value-1],`lhp_Vehtype`=[value-2],`lhp_extrakmCharge`=[value-3],`lhp_extrahourcharge`=[value-4],`lhp_overnightcharge`=[value-5],`lhp_MaxTimeLimit`=[value-6],`lhp_MaxKMLimit`=[value-7],`lhp_Basic`=[value-8] WHERE `lhp_Name`=[value-1]
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Record Updated", "Success !!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbtnPerDay.Checked == true)
            {
                LoadRentData();
            }
            else if (rbtnPerWeek.Checked == true)
            {
                LoadDayHireData();
            }
            else if (rbtnPerMonth.Checked == true)
            {
                LoadLongHireData();
            }
            else
            {
                MessageBox.Show("Select Correct package category...","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                ClearAll();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rbtnPerDay.Checked == true)
            {
                RentDelete();
            }
            else if (rbtnPerWeek.Checked == true)
            {
                DayHireDelete();
            }
            else if (rbtnPerMonth.Checked == true)
            {
                LongHireDelete();
            }
            else
            {
                MessageBox.Show("Error....", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearAll();
            }
        }

        private void RentDelete()
        {
            if (MessageBox.Show("Do you want to delete record?", "Delete record !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "DELETE FROM `tb_rentpackages` WHERE `rp_Name`='" + txtName.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                    cmd.ExecuteNonQuery();
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

        private void DayHireDelete()
        {
            if (MessageBox.Show("Do you want to delete record?", "Delete record !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "DELETE FROM `tb_dayhirepackages` WHERE `dhp_Name`='" + txtName.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                    cmd.ExecuteNonQuery();
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

        private void LongHireDelete()
        {
            if (MessageBox.Show("Do you want to delete record?", "Delete record !!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                try
                {
                    cls_Table_Connection.open_connection();
                    string myCommand = "DELETE FROM `tb_longhirepackages` WHERE `lhp_Name`='" + txtName.Text + "'";
                    MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                    cmd.ExecuteNonQuery();
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
