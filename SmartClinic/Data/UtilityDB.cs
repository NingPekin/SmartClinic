using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Configuration;

namespace SmartClinic.Data
{
    public class UtilityDB
    {
        //haven't set up connection string in web config
        public static SqlConnection GetConn()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["myDatabase"].ToString();
            return conn;

        }
        public static void ConnectDB()
        {
            SqlConnection conn = GetConn();
            conn.Open();
 
        }
    }
}