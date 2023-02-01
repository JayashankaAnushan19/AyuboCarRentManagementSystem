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
    public partial class FrmPayment : Form
    {

        public FrmPayment()
        {
            InitializeComponent();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void rbtnReserved_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dateRented.ResetText();
            dateReturned.ResetText();
            timeRented.ResetText();
            timeReturned.ResetText();
            rbtnReserved.Checked = false;
            rbtnNew.Checked = false;
            rbtnRent.Checked = false;
            rbtnDayHire.Checked = false;
            btnLongHire.Checked = false;
            gboxPackageType.Enabled = true;
            cboxDriver.Checked = false;
            cboxDriver.Enabled = true;
            txtCustomerNIC.Clear();
            txtStartKMReading.Text = "0";
            txtEndKMReading.Text = "0";
            txtReservationID.Clear();
            cmbDriverID.Enabled = false;
            textBox3.Clear();
            txtBalance.Clear();
            
        }

        private void rbtnNew_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gboxPackageType_Enter(object sender, EventArgs e)
        {

        }

        private void FrmPayment_Load(object sender, EventArgs e)
        {
            timeRented.ShowUpDown = true;
            timeReturned.ShowUpDown = true;
            LoadDrivers();
            cmbDriverID.Enabled = false;
            rbtnNew.Checked = true;
            txtReservationID.Enabled = false;
            btnShow.Enabled = false;
        }

        private void rbtnNew_Click(object sender, EventArgs e)
        {
            txtReservationID.Enabled = false;
            btnShow.Enabled = false;
            gboxPackageType.Enabled = true;
            cboxVehicleType.Enabled = true;
            txtCustomerNIC.Enabled = true;

        }

        private void rbtnReserved_Click(object sender, EventArgs e)
        {
            txtReservationID.Enabled = true;
            btnShow.Enabled = true;
            cboxVehicleType.Enabled = false;
            txtCustomerNIC.Enabled = false;

        }

        private void rbtnRent_Click(object sender, EventArgs e)
        {
            cmbPackage.Items.Clear();
            dateRented.Enabled = true;
            dateReturned.Enabled = true;
            timeRented.Enabled = false;
            timeReturned.Enabled = false;
            txtStartKMReading.Enabled = false;
            txtEndKMReading.Enabled = false;
            cboxDriver.Checked = false;
            cboxDriver.Enabled = true;

            try
            {
                cmbPackage.Text="";
                cmbPackage.Items.Clear();
                string query = "SELECT `rp_Name` FROM `tb_rentpackages` ";
                MySqlCommand Mycom = new MySqlCommand(query, cls_Table_Connection.con);
                MySqlDataReader Myreader;
                cls_Table_Connection.open_connection();
                Myreader = Mycom.ExecuteReader();
                if (Myreader.HasRows)
                {
                    while (Myreader.Read())
                    {
                        string collection = Myreader.GetString(0).ToString();
                        cmbPackage.Items.Add(collection);
                    }
                }

            }
            catch
            {

            }
            finally
            {
                cls_Table_Connection.close_connection();
            }

        }

        private void rbtnRent_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbtnDayHire_Click(object sender, EventArgs e)
        {
            cmbPackage.Items.Clear();
            cboxDriver.Checked = true;
            cboxDriver.Enabled = false;
            dateRented.Enabled = true;
            dateReturned.Enabled = true;
            timeRented.Enabled = true;
            timeReturned.Enabled = true;
            txtStartKMReading.Enabled = true;
            txtEndKMReading.Enabled = true;
            cmbDriverID.Enabled = true;

            try
            {
                cmbPackage.Text="";
                cmbPackage.Items.Clear();
                string query = "SELECT `dhp_Name` FROM `tb_dayhirepackages`";
                MySqlCommand Mycom = new MySqlCommand(query, cls_Table_Connection.con);
                MySqlDataReader Myreader;
                cls_Table_Connection.open_connection();
                Myreader = Mycom.ExecuteReader();
                if (Myreader.HasRows)
                {
                    while (Myreader.Read())
                    {
                        string collection = Myreader.GetString(0).ToString();
                        cmbPackage.Items.Add(collection);
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

        private void btnLongHire_Click(object sender, EventArgs e)
        {
            cmbPackage.Items.Clear();
            cboxDriver.Checked = true;
            cboxDriver.Enabled = false;
            timeRented.Enabled = false;
            timeReturned.Enabled = false;
            dateRented.Enabled = true;
            dateReturned.Enabled = true;
            txtStartKMReading.Enabled = true;
            txtEndKMReading.Enabled = true;
            cmbDriverID.Enabled = true;

            try
            {
                cmbPackage.Text="";
                cmbPackage.Items.Clear();
                string query = "SELECT `lhp_Name` FROM `tb_longhirepackages`";
                MySqlCommand Mycom = new MySqlCommand(query, cls_Table_Connection.con);
                MySqlDataReader Myreader;
                cls_Table_Connection.open_connection();
                Myreader = Mycom.ExecuteReader();
                if (Myreader.HasRows)
                {
                    while (Myreader.Read())
                    {
                        string collection = Myreader.GetString(0).ToString();
                        cmbPackage.Items.Add(collection);
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

        private void gboxPay_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rbtnRent.Checked == true)
            {
                RentCalculate();
            }
            else if(rbtnDayHire.Checked==true)
            {
                DayHireCalculate();
            }
            else if (btnLongHire.Checked == true)
            {
                LongHireCalculate();
            }

        }

        private void DateRangeCalculete()  //Code Done
        {
            if (Convert.ToDateTime(dateReturned.Text) >= Convert.ToDateTime(dateRented.Text))
            {
                DateTime rdate = DateTime.Parse(dateRented.Text);
                DateTime rtdate = DateTime.Parse(dateReturned.Text);
                TimeSpan totdate = rtdate - rdate;
                string TT = totdate.Days.ToString();
                
            }
            else
            {
                MessageBox.Show("Wrong Date input...", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TimeRangeCalcutale() //Code done
        {
            if (Convert.ToDateTime(timeReturned.Text) >= Convert.ToDateTime(timeRented.Text))
            {
                DateTime tRent = dateRented.Value.Date + timeRented.Value.TimeOfDay;
                DateTime tReturn = dateReturned.Value.Date + timeReturned.Value.TimeOfDay;
                TimeSpan totaltime = tReturn - tRent;
                int tottime = (int)totaltime.TotalHours;
                decimal Totalltime = Convert.ToInt32(tottime);
                MessageBox.Show(Convert.ToString(Totalltime), "Total time");
            }
            else
            {
                MessageBox.Show("Wrong Time input...", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KMRangeCalculate() //Code done
        {
            if (txtStartKMReading.Text == "")
            {
                MessageBox.Show("Enter Start KM Reading...", "Enter...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStartKMReading.Focus();
            }
            else if (txtEndKMReading.Text == "")
            {
                MessageBox.Show("Enter End KM Reading...", "Enter...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtEndKMReading.Focus();
            }
            else if (Convert.ToInt64(txtStartKMReading.Text) > Convert.ToInt64(txtEndKMReading.Text))
            {
                MessageBox.Show("Invalid KM Readings..", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtStartKMReading.Clear();
                txtEndKMReading.Clear();
                txtStartKMReading.Focus();
            }
            else
            {
                int KMTotal = Convert.ToInt32(txtEndKMReading.Text) - Convert.ToInt32(txtStartKMReading.Text);
                MessageBox.Show(Convert.ToString(KMTotal), "Total KM");
                return;
            }
        }

        private void RentCalculate()
        {

            try
            {
                if (Convert.ToDateTime(dateReturned.Text) >= Convert.ToDateTime(dateRented.Text))
                {
                    DateTime rdate = DateTime.Parse(dateRented.Text);
                    DateTime rtdate = DateTime.Parse(dateReturned.Text);
                    TimeSpan totdate = rtdate - rdate;
                    string TT = totdate.Days.ToString();

                    cls_Table_Connection.open_connection();

                    string sql = "SELECT * FROM `tb_rentpackages`";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, cls_Table_Connection.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataRow[] returnrow = ds.Tables[0].Select("rp_Name='" + cmbPackage.Text + "'");
                    DataRow dr = returnrow[0];
                    string DDRent = (dr["rp_PerDayRent"].ToString());
                    string WWRent = (dr["rp_PerWeekRent"].ToString());
                    string MMRent = (dr["rp_PerMonthRent"].ToString());

                    int TotalDays = Convert.ToInt32(TT);

                    int t1, t2, t3, t4;
                    decimal tm;
                    decimal tot = 0;
                    decimal MRent = Convert.ToInt32(MMRent);
                    decimal WRent = Convert.ToInt32(WWRent);
                    decimal DRent = Convert.ToInt32(DDRent);

                    if (cboxDriver.Checked == true)
                    {
                        string sqls = "SELECT * FROM `tb_driver`;";
                        MySqlDataAdapter das = new MySqlDataAdapter(sqls, cls_Table_Connection.con);
                        DataSet dss = new DataSet();
                        das.Fill(dss);
                        DataRow[] returnrows = dss.Tables[0].Select("`d_NIC`='" + cmbDriverID.Text + "'");
                        DataRow drs = returnrows[0];
                        string DriRent = (drs["d_PerDayRent"].ToString());
                        int rDriver = Convert.ToInt32(DriRent);
                        int DriverRent = rDriver;
                        txtTemp.Text = DriverRent.ToString();
                    }
                    else
                    {
                        txtTemp.Text = "0";
                    }

                    if (TotalDays >= 30)
                    {
                        if (TotalDays % 30 == 0)
                        {
                            tm = TotalDays / 30;
                            tot += (MRent * tm);
                            tot += (Convert.ToInt32(txtTemp.Text)*Convert.ToInt32(TotalDays));
                            lblTotalShow.Text =  tot.ToString();
                            tot = 0;
                        }
                        else
                        {
                            t1 = TotalDays / 30;
                            tot = MRent * t1;
                            t2 = TotalDays - (t1 * 30);
                            if (t2 >= 7)
                            {
                                if (t2 % 7 == 0)
                                {
                                    tm = TotalDays / 7;
                                    tot = tot + (WRent * tm);
                                    tot += (Convert.ToInt32(txtTemp.Text) * Convert.ToInt32(TotalDays));
                                    lblTotalShow.Text =  tot.ToString();
                                    tot = 0;
                                }
                                else
                                {
                                    t3 = t2 / 7;
                                    t4 = t2 - (t3 * 7);
                                    tot = tot + (WRent * t3);
                                    tot = tot + (DRent * t4);
                                    tot += (Convert.ToInt32(txtTemp.Text) * Convert.ToInt32(TotalDays));
                                    lblTotalShow.Text =  tot.ToString();
                                    tot = 0;
                                }
                            }
                            else
                            {
                                tot = tot + (DRent * t2);
                                tot += (Convert.ToInt32(txtTemp.Text) * Convert.ToInt32(TotalDays));
                                lblTotalShow.Text =  tot.ToString();
                                tot = 0;
                            }
                        }
                    }
                    else
                    {
                        if (TotalDays % 7 == 0)
                        {
                            tm = TotalDays / 7;
                            tot = tot + (WRent);
                            tot += (Convert.ToInt32(txtTemp.Text) * Convert.ToInt32(TotalDays));
                            lblTotalShow.Text =  tot.ToString();
                            tot = 0;
                        }
                        else
                        {
                            t3 = TotalDays / 7;
                            t4 = TotalDays - (t3 * 7);
                            tot = tot + (WRent * t3);
                            tot = tot + (DRent * t4);
                            tot += (Convert.ToInt32(txtTemp.Text) * Convert.ToInt32(TotalDays));
                            lblTotalShow.Text =  tot.ToString();
                            tot = 0;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Wrong  Date Range", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !!! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DayHireCalculate()
        {
            try
            {
                string sql = "SELECT * FROM `tb_dayhirepackages`";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cls_Table_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("dhp_Name='" + cmbPackage.Text + "'");
                DataRow dr = returnrow[0];
                string MKMLimit = (dr["dhp_MaxKMLimit"].ToString());
                string MTimeLimit = (dr["dhp_MaxTime"].ToString());
                string Basic = (dr["dhp_BasicCharge"].ToString());
                string ExKMCharge = (dr["dhp_ExtraKMCharge"].ToString());
                string WaitingCharge = (dr["dhp_ExtraHourCharge"].ToString());

                decimal MaxTime = Convert.ToInt32(MTimeLimit);
                decimal MaxKM = Convert.ToInt32(MKMLimit);
                decimal ExtraKMCharge = Convert.ToInt32(ExKMCharge);
                decimal WaitingCharged = Convert.ToInt32(WaitingCharge);
                decimal BasicCharge = Convert.ToInt32(Basic);

                int tot = Convert.ToInt32(BasicCharge);
                int ETC = 0;
                int EC = 0, TEKMC = 0;
                if (Convert.ToDateTime(timeReturned.Text) >= Convert.ToDateTime(timeRented.Text))
                {
                    DateTime tRent = dateRented.Value.Date + timeRented.Value.TimeOfDay;
                    DateTime tReturn = dateReturned.Value.Date + timeReturned.Value.TimeOfDay;
                    TimeSpan totaltime = tReturn - tRent;
                    int tottime = (int)totaltime.TotalHours;
                    int Totalltime = Convert.ToInt32(tottime);


                    if (txtStartKMReading.Text == "")
                    {
                        MessageBox.Show("Enter Start KM Reading...", "Enter...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtStartKMReading.Focus();
                    }
                    else if (txtEndKMReading.Text == "")
                    {
                        MessageBox.Show("Enter End KM Reading...", "Enter...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtEndKMReading.Focus();
                    }
                    else if (Convert.ToInt64(txtStartKMReading.Text) > Convert.ToInt64(txtEndKMReading.Text))
                    {
                        MessageBox.Show("Invalid KM Readings..", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtStartKMReading.Clear();
                        txtEndKMReading.Clear();
                        txtStartKMReading.Focus();
                        Console.Read();
                    }
                    int KMTotal = Convert.ToInt32(txtEndKMReading.Text) - Convert.ToInt32(txtStartKMReading.Text);
                    int t1;

                    if (Convert.ToInt32(Totalltime) > Convert.ToInt32(MaxTime))

                    {
                        t1 = (Convert.ToInt32(Totalltime)- Convert.ToInt32(MaxTime)) * Convert.ToInt32(WaitingCharged);
                        ETC = t1;
                        EC += ETC;
                        lblWaitingChargeShow.Text = t1.ToString();
                        if (Convert.ToInt32(KMTotal) > Convert.ToInt32(MaxKM))
                        {
                            TEKMC = (Convert.ToInt32(KMTotal) - Convert.ToInt32(MaxKM)) * Convert.ToInt32(ExtraKMCharge);
                            EC += TEKMC;
                            tot += EC;
                            lblTotalShow.Text = tot.ToString();
                            lblExtraKMChargeShow.Text = TEKMC.ToString();
                            lblWaitingChargeShow.Text = t1.ToString();
                            lblBasicChargeShow.Text = BasicCharge.ToString();
                        }
                        else
                        {
                            tot += EC;
                            lblTotalShow.Text = tot.ToString();
                            lblExtraKMChargeShow.Text = "";
                            lblWaitingChargeShow.Text = "";
                            lblBasicChargeShow.Text = BasicCharge.ToString();
                        }
                    }
                    else
                    {
                        if (Convert.ToInt32(KMTotal) > Convert.ToInt32(MaxKM))
                        {
                            TEKMC = (Convert.ToInt32(KMTotal) - Convert.ToInt32(MaxKM)) * Convert.ToInt32(ExtraKMCharge);
                            EC += TEKMC;
                            tot += EC;
                            lblTotalShow.Text = tot.ToString();
                            lblExtraKMChargeShow.Text = TEKMC.ToString();
                            lblWaitingChargeShow.Text = "";
                            lblBasicChargeShow.Text = BasicCharge.ToString();
                        }
                        else
                        {
                            tot += EC;
                            lblTotalShow.Text = tot.ToString();
                            lblExtraKMChargeShow.Text = "";
                            lblWaitingChargeShow.Text = "";
                            lblBasicChargeShow.Text = BasicCharge.ToString();
                        }
                    }
                 }
                else
                {
                    MessageBox.Show("Wrong Time input...", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error !!! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void LongHireCalculate()
        {
            try
            {
                cls_Table_Connection.open_connection();
                string sql = "SELECT * FROM `tb_longhirepackages`;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cls_Table_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("lhp_Name='" + cmbPackage.Text + "'");
                DataRow dr = returnrow[0];

                string MaxKMLimit = (dr["lhp_MaxKMLimit"].ToString());
                string MaxTimeLimit = (dr["lhp_MaxTimeLimit"].ToString());
                string ExtraKMCharge = (dr["lhp_extrakmCharge"].ToString());
                string OvernightCharge = (dr["lhp_overnightcharge"].ToString());
                string Basic = (dr["lhp_Basic"].ToString());

                decimal MaxKMLimitt = Convert.ToInt32(MaxKMLimit);
                decimal MaxTimeLimitt = Convert.ToInt32(MaxTimeLimit);
                decimal ExtraKMCharget = Convert.ToInt32(ExtraKMCharge);
                decimal OvernightCharget = Convert.ToInt32(OvernightCharge);
                decimal Basict = Convert.ToInt32(Basic);

                int tot = Convert.ToInt32(Basict);

                DateTime tRent = dateRented.Value.Date;
                DateTime tReturn = dateReturned.Value.Date;
                TimeSpan totaltime = tReturn - tRent;
                int totday = (int)totaltime.TotalDays;
                int TotalDays = Convert.ToInt32(totday);

                int KMTotal;
                KMTotal = Convert.ToInt32(txtEndKMReading.Text) - Convert.ToInt32(txtStartKMReading.Text);

            //  Add driver charge
            if (cmbDriverID.Text !="")
            {
                try {
                    cls_Table_Connection.open_connection();
                    string sqlDr = "SELECT * FROM `tb_driver`;";
                    MySqlDataAdapter daDr = new MySqlDataAdapter(sqlDr, cls_Table_Connection.con);
                    DataSet dsDr = new DataSet();
                    daDr.Fill(dsDr);
                    DataRow[] returnrowDr = dsDr.Tables[0].Select("`d_NIC`='" + cmbDriverID.Text + "'");
                    DataRow drDr = returnrowDr[0];

                    string DriverChar = (drDr["`d_PerDayRent`"].ToString());
                    txtTemp.Text = DriverChar.ToString();
                }
                catch(Exception)
                {
                    MessageBox.Show("Driver ID is incorrect !","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                finally
                {
                    cls_Table_Connection.close_connection();
                }
            }
            else
            {
                txtTemp.Text ="0";
            }

                if (Convert.ToInt32(KMTotal) > Convert.ToInt32(MaxKMLimitt))
                {
                    int EKMCharge = ((Convert.ToInt32(KMTotal) - Convert.ToInt32(MaxKMLimitt)) * Convert.ToInt32(ExtraKMCharget));
                    tot += Convert.ToInt32(txtTemp.Text);
                    tot += EKMCharge;
                lblExtraKMChargeShow.Text = EKMCharge.ToString();

                    if (Convert.ToInt32(TotalDays) > 2)
                    {
                        int ONcharge = (Convert.ToInt32(TotalDays) - 1) * Convert.ToInt32(OvernightCharget);
                        tot += ONcharge;
                        lblTotalShow.Text = tot.ToString();
                        lblBasicChargeShow.Text = Basict.ToString();
                    lblOverNightChargeShow.Text = ONcharge.ToString();
                }
                    else
                    {
                        lblTotalShow.Text = tot.ToString();
                    lblBasicChargeShow.Text = Basict.ToString();
                }
                }
                else if (Convert.ToInt32(TotalDays) > 2)
                {
                    int ONcharge = (Convert.ToInt32(TotalDays) - 1) * Convert.ToInt32(OvernightCharget);
                    tot += Convert.ToInt32(txtTemp.Text);
                    tot += ONcharge;
                    lblTotalShow.Text = tot.ToString();
                lblBasicChargeShow.Text = Basict.ToString();
            }
                else
                {
                    lblTotalShow.Text = tot.ToString();
                lblBasicChargeShow.Text = Basict.ToString();
            }
                     }
        
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error !!! " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       
                    }
                    finally
                    {
                        cls_Table_Connection.close_connection();
                    }
        }

        private void GetVehicleTypesToCbox()
        {
            try
            {
                if (rbtnRent.Checked == true)
                {
                    try
                    {
                        cboxVehicleType.Text = "";
                        cboxVehicleType.Items.Clear();
                        string query = "SELECT `rp_VehType` FROM `tb_rentpackages` WHERE `rp_Name`='"+cmbPackage.Text+"'";
                        MySqlCommand Mycom = new MySqlCommand(query, cls_Table_Connection.con);
                        MySqlDataReader Myreader;
                        cls_Table_Connection.open_connection();
                        Myreader = Mycom.ExecuteReader();
                        if (Myreader.HasRows)
                        {
                            while (Myreader.Read())
                            {
                                string vehicletype = Myreader.GetString(0).ToString();
                                cboxVehicleType.Items.Add(vehicletype);
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
                else if (rbtnDayHire.Checked == true)
                {
                    try
                    {
                        cboxVehicleType.Text = "";
                        cboxVehicleType.Items.Clear();
                        string query = "SELECT `dhp_Vehtype` FROM `tb_dayhirepackages` WHERE `dhp_Name`='" + cmbPackage.Text + "'";
                        MySqlCommand Mycom = new MySqlCommand(query, cls_Table_Connection.con);
                        MySqlDataReader Myreader;
                        cls_Table_Connection.open_connection();
                        Myreader = Mycom.ExecuteReader();
                        if (Myreader.HasRows)
                        {
                            while (Myreader.Read())
                            {
                                string vehicletype = Myreader.GetString(0).ToString();
                                cboxVehicleType.Items.Add(vehicletype);
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
                else if (btnLongHire.Checked == true)
                {
                    try
                    {
                        cboxVehicleType.Text = "";
                        cboxVehicleType.Items.Clear();
                        string query = "SELECT `lhp_Vehtype` FROM `tb_longhirepackages` WHERE `lhp_Name`='" + cmbPackage.Text + "'";
                        MySqlCommand Mycom = new MySqlCommand(query, cls_Table_Connection.con);
                        MySqlDataReader Myreader;
                        cls_Table_Connection.open_connection();
                        Myreader = Mycom.ExecuteReader();
                        if (Myreader.HasRows)
                        {
                            while (Myreader.Read())
                            {
                                string vehicletype = Myreader.GetString(0).ToString();
                                cboxVehicleType.Items.Add(vehicletype);
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
                else
                { }
            }
            catch 
            {
                

            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtReservationID.Text == "")
            {
                MessageBox.Show("Insert Reservation ID ...", "Empty Value", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    cls_Table_Connection.open_connection();

                    string sql = "SELECT * FROM `tb_reservation`;";
                    MySqlDataAdapter da = new MySqlDataAdapter(sql, cls_Table_Connection.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataRow[] returnrow = ds.Tables[0].Select("r_ID='" + txtReservationID.Text + "'");
                    DataRow dr = returnrow[0];
                    txtCustomerNIC.Text = (dr["r_CusNIC"].ToString());
                    string PaCat = (dr["r_PackageID"].ToString());
                    cboxVehicleType.Text = (dr["r_VeicleType"].ToString());
                    string DriverSatus = (dr["r_DriverStatus"].ToString());
                    if (PaCat == "Rent")
                    {
                        rbtnRent.Checked = true;
                    }
                    else if (PaCat == "Day Hire")
                    {
                        rbtnDayHire.Checked = true;
                    }
                    else if (PaCat == "Long Hire")
                    {
                        btnLongHire.Checked = true;
                    }
                    else if (DriverSatus == "With Driver")
                    {
                        cboxDriver.Checked = true;
                    }
                    else if (DriverSatus == "Without Driver")
                    {
                        cboxDriver.Checked = false;
                    }

                    string sql1 = "SELECT * FROM `db_ayuborentmanagementsystem`.`tb_customer`;";
                    MySqlDataAdapter da1 = new MySqlDataAdapter(sql1, cls_Table_Connection.con);
                    DataSet ds1 = new DataSet();
                    da1.Fill(ds1);
                    DataRow[] returnrow1 = ds1.Tables[0].Select("c_NIC='" + txtCustomerNIC.Text + "'");
                    DataRow dr1 = returnrow1[0];
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Insert correct Reservation ID ...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    cls_Table_Connection.close_connection();
                }
            }
            
        }

        private void cboxDriver_CheckedChanged(object sender, EventArgs e)
        { }

        private void cmbDriverID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM `tb_driver`;";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cls_Table_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("d_NIC='" + cmbDriverID.Text + "'");
                DataRow dr = returnrow[0];
                lblDriNameShow.Text = (dr["d_Name"].ToString());
                
            }
            catch
            {
                lblDriNameShow.Text = "";
                
            }
        }

        private void LoadDrivers()
        {
            try
            {
                string query = "SELECT `d_NIC` FROM `tb_driver`";
                MySqlCommand Mycom = new MySqlCommand(query, cls_Table_Connection.con);
                MySqlDataReader Myreader;
                cls_Table_Connection.open_connection();
                Myreader = Mycom.ExecuteReader();
                if (Myreader.HasRows)
                {
                    while (Myreader.Read())
                    {
                        string Driver = Myreader.GetString(0).ToString();
                        cmbDriverID.Items.Add(Driver);
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

        private void cboxDriver_Click(object sender, EventArgs e)
        {
            if(cboxDriver.Checked != true)
            {
                cmbDriverID.Enabled = false;
            }
            else
            {
                cmbDriverID.Enabled = true;
            }
        }

        private void cmbPackage_TextChanged(object sender, EventArgs e)
        {
            GetVehicleTypesToCbox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeRangeCalcutale();
        }

        private void txtCustomerNIC_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM `tb_customer`";
                MySqlDataAdapter da = new MySqlDataAdapter(sql, cls_Table_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("c_NIC='" + txtCustomerNIC.Text + "'");
                DataRow dr = returnrow[0];
                lblCustomerNameShow.Text = (dr["c_Name"].ToString());

            }
            catch 
            {
                lblCustomerNameShow.Text="";
                txtCustomerNIC.Focus();
            }

        }

        private void txtCustomerNIC_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            try
            {
                int a = Convert.ToInt32(lblTotalShow.Text);

                int b = Convert.ToInt32(textBox3.Text); //textBox3.Text=Cash

                int c = b - a;

                txtBalance.Text = Convert.ToString(c);
            }
            catch (Exception)
            {

            }


        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {}

        private void txtTemp_Click(object sender, EventArgs e)
        {

        }

        private void cmbDriverID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //  Add driver charge
            if (cmbDriverID.Text != "")
            {
                cls_Table_Connection.open_connection();
                string sqlDr = "SELECT * FROM `tb_driver`;";
                MySqlDataAdapter daDr = new MySqlDataAdapter(sqlDr, cls_Table_Connection.con);
                DataSet dsDr = new DataSet();
                daDr.Fill(dsDr);
                DataRow[] returnrowDr = dsDr.Tables[0].Select("`d_NIC`='" + cmbDriverID.Text + "'");
                DataRow drDr = returnrowDr[0];

                string DriverChar = (drDr["`d_PerDayRent`"].ToString());
                txtTemp.Text = DriverChar.ToString();
            }
            else
            {
                txtTemp.Text = "0";
            }
            }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (lblCustomerNameShow.Text == "")
            {
                MessageBox.Show("Customer field empty or incorrect..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (lblTotalShow.Text=="")
                {
                    MessageBox.Show("Enter valid values or Calculate for payment","Invalid",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else if (textBox3.Text == "")
                {
                    MessageBox.Show("Enter Cash...", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Thank for your payment ...   " + "Cash : Rs." + textBox3.Text + "   " + "Total : Rs." + lblTotalShow.Text + "   " + "Balance : Rs." + txtBalance.Text, "Payment ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dateRented.ResetText();
                    dateReturned.ResetText();
                    timeRented.ResetText();
                    timeReturned.ResetText();
                    rbtnReserved.Checked = false;
                    rbtnNew.Checked = false;
                    rbtnRent.Checked = false;
                    rbtnDayHire.Checked = false;
                    btnLongHire.Checked = false;
                    gboxPackageType.Enabled = true;
                    cboxDriver.Checked = false;
                    cboxDriver.Enabled = true;
                    txtCustomerNIC.Clear();
                    txtStartKMReading.Text = "0";
                    txtEndKMReading.Text = "0";
                    txtReservationID.Clear();
                    cmbDriverID.Enabled = false;
                }
            }
        }
    }
    }



