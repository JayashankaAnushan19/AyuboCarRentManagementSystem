using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.IO;

namespace AyuboCarRentManagementSystem
{
    class cls_Table_Connection
    {
        //connect to databases
        public static MySqlConnection con = new MySqlConnection("Server=localhost;userid=root;password=;database=db_ayuborentmanagementsystem;port=3306");

        //Open Connection
        public static void open_connection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else
            {
            }
        }
        

        //Close Connection
        public static void close_connection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }

    } // end of class
}
