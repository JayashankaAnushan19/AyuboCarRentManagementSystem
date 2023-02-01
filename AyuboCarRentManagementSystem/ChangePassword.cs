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
    public partial class FrmChangePassword : Form
    {
        public FrmChangePassword()
        {
            InitializeComponent();
            txtOldPassword.UseSystemPasswordChar = true;
            txtOldPassword.UseSystemPasswordChar = true;
            txtNewPassword.UseSystemPasswordChar = true;
            txtRetypePassword.UseSystemPasswordChar = true;
        }

        private void btnChange_Click(object sender, EventArgs e)
        {


            if (txtNewPassword.Text != txtRetypePassword.Text)
            {
                MessageBox.Show("Didn't match confirm password !!!", "Invalid...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRetypePassword.Clear();
                txtRetypePassword.Focus(); 

            }
            else if(txtNewPassword.Text=="" && txtUserName.Text=="" && txtRetypePassword.Text=="" && txtOldPassword.Text=="")
            {
                MessageBox.Show("Empty value, Please check again!!", "Empty",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                cls_Table_Connection.open_connection();

                string CCN = "SELECT * FROM `tb_user`";
                MySqlDataAdapter da = new MySqlDataAdapter(CCN, cls_Table_Connection.con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                DataRow[] returnrow = ds.Tables[0].Select("User_Name='" + txtUserName.Text + "'");  //Get data from user input for check
                DataRow dr = returnrow[0];

                if (txtUserName.Text == (dr["User_Name"].ToString()) && txtOldPassword.Text == (dr["User_Password"].ToString()))  //check validation
                {
                    try
                    {
                        cls_Table_Connection.open_connection();
                        string myCommand = "UPDATE `tb_user` SET `User_Password`='" + txtNewPassword.Text + "' WHERE `User_Name`='" + txtUserName.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(myCommand, cls_Table_Connection.con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Change Succesful !!!      Now you can log with new password.", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearAll();
                        this.Close();
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
                else
                {
                    MessageBox.Show("Invalid User name or Password... ", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
        }

        private void ClearAll()
        {
            txtOldPassword.Clear();
            txtNewPassword.Clear();
            txtRetypePassword.Clear();
            txtUserName.Clear();
        }
        private void ReLog()
        {
            if(MessageBox.Show("Please Log Again !!","Log",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
            {
                Loging log = new Loging();
                log.Show();
                this.Hide();
            }
            else
            {
                this.Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtOldPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtOldPassword.UseSystemPasswordChar = true;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                txtNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
