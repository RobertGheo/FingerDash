using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FingerDash
{
    // object that handle DB connection 
    // open and close DB connection

    public class DbConnection
    {

        public static SqlConnection dbConn = new SqlConnection();
        public static SqlCommand dbComm = new SqlCommand();
        public static SqlDataAdapter dbAdapter = new SqlDataAdapter();
        //public static SqlDataReader dbReader;


        public static string insertData;  //insert data 
        public static string accessData;  //select data
        public static int insertUserID;

        public static string getDbConnection()
        {
            //Here is for inserting database login credential for server
            string dbConnAddress = "Server=tcp:server-finger-dash.database.windows.net,1433;Initial Catalog=DBFingerDash;Persist Security Info=False;User ID=RobertBradu;Password=FingerDash5;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            return dbConnAddress;

        }

        public static void openDbConnection()
        {
            try
            {
                if (dbConn.State == ConnectionState.Closed)
                {
                    dbConn.ConnectionString = getDbConnection();
                    dbConn.Open();
                    // testing message open connection
                    MessageBox.Show("Connection Open!!!");
                    // 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("System failed to open the database connection!!!" + ex.Message);
            }
        }

        public static void closeDbConnection()
        {
            try
            {
                if (dbConn.State == ConnectionState.Open)
                {
                    dbConn.Close();
                    // testing message close connection
                    MessageBox.Show("Connection Close!!!");
                    //
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("System did not close the database connection!!!" + ex.Message);
            }
        }
        // public static int insertUserID;
        public static void insertTimeCardNo(string action)
        {

        }
    }
}
