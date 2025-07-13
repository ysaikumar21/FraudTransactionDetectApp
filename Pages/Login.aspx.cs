using FraudTransactionDetectApp.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FraudDetectionApp.Pages
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session.Clear(); // Clear any existing session
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string query = @"SELECT AdminId, UserName, IsAdmin 
                             FROM AdminUsers 
                             WHERE UserName = @Username AND Password = @Password";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Username", txtUsername.Text),
                new SqlParameter("@Password", txtPassword.Text)
            };

            DataTable dt = DBHelper.ExecuteSelect(query, parameters);

            if (dt.Rows.Count > 0)
            {
                Session["AdminId"] = dt.Rows[0]["AdminId"];
                Session["UserName"] = dt.Rows[0]["UserName"];
                Session["IsAdmin"] = dt.Rows[0]["IsAdmin"];

                Response.Redirect("AddTransaction.aspx");
            }
            else
            {
                lblStatus.Text = "❌ Invalid username or password.";
            }
        }
    }
}
