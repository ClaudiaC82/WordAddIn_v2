using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace MailerUtilities
{
    public static class MailerLogger
    {
        static SqlConnection con;
        private static void connection(string connection_string)
        {
            string constr = connection_string;
            con = new SqlConnection(constr);
            con.Open();
        }
        //public void SendExcepToDB(Exception exdb, string connection_string)
        //{
        //    connection(connection_string);
        //    SqlCommand com = new SqlCommand("sp_Log", con);
        //    com.CommandType = CommandType.StoredProcedure;
        //    com.Parameters.AddWithValue("@LogMsg", exdb.Message.ToString());
        //    com.Parameters.AddWithValue("@LogType", 1);
        //    com.ExecuteNonQuery();
        //    con.Close();
        //}
        public static void SendLogToDB(int type, string message) 
        /*
         * type=1 : ERROR; 
         * type=2 : DEBUG
         */
        {
            //ConfigReader.Configuration configurazione = ConfigReader.PersistableObject.Load<ConfigReader.Configuration>(@"config.xml");
            ConfigReader.Configuration configurazione = new ConfigReader.Configuration();
            configurazione.connection_string = "Data Source=.\\SQLEXPRESS;Initial Catalog=wordAddIn;User id=consap1 ; Password=consap ;";
            connection(configurazione.connection_string);
            SqlCommand com = new SqlCommand("sp_Log", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@LogMsg", message);
            com.Parameters.AddWithValue("@LogType", type);
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
