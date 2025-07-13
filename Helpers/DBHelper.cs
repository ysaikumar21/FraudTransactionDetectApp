using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FraudTransactionDetectApp.Helpers
{
    public class DBHelper : Controller
    {
        // Return a SQL Connection object
        public static SqlConnection GetConnection()
        {
            string connStr = ConfigurationManager.ConnectionStrings["FraudDBConnection"].ConnectionString;
            return new SqlConnection(connStr);
        }

        // Execute a SELECT query and return a DataTable
        public static DataTable ExecuteSelect(string query, SqlParameter[] parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            return dt;
        }

        // Execute INSERT, UPDATE, DELETE commands
        public static int ExecuteCommand(string query, SqlParameter[] parameters = null)
        {
            int result = 0;
            using (SqlConnection conn = GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    conn.Open();
                    result = cmd.ExecuteNonQuery();
                }
            }
            return result;
        }
    }
}