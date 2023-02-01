using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AyuboCarRentManagementSystem
{
    public partial class Loging : Form
    {
        public Loging()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Empty Value.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Empty Value.", "Empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
            }
            else
            {
                try
                {
                    cls_Table_Connection.open_connection();

                    string CCN = "SELECT * FROM `tb_user`";
                    MySqlDataAdapter da = new MySqlDataAdapter(CCN, cls_Table_Connection.con);
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    DataRow[] returnrow = ds.Tables[0].Select("User_Name='" + txtUserName.Text + "'");  //Get data from user input for check
                    DataRow dr = returnrow[0];

                    if (txtUserName.Text == (dr["User_Name"].ToString()) && txtPassword.Text == (dr["User_Password"].ToString()))  //check validation
                    {
                        FrmMainMenu L = new FrmMainMenu();
                        L.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid User Name or Password !!!", "Invalid...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        txtUserName.Clear();
                        txtPassword.Clear();
                        txtUserName.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Rent Management System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
                finally
                {
                    cls_Table_Connection.close_connection();
                }
            }

        }

        private void lblChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmChangePassword chan = new FrmChangePassword();
            chan.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, Do you want to exit?","Exit",MessageBoxButtons.OKCancel,MessageBoxIcon.Information)==DialogResult.OK)
            {
                this.Close();
            }
            else
            {
                txtUserName.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Loging_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
