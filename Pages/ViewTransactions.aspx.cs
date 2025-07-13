using FraudTransactionDetectApp.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FraudDetectionApp.Pages
{
    public partial class ViewTransactions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }
            if (!IsPostBack)
                LoadAllTransactions();
        }

        // Load all transactions initially
        private void LoadAllTransactions()
        {
            string query = @"
                SELECT u.UserName, u.Email, t.Amount, t.TransactionsDATE, t.Location, t.IsFraud
                FROM Users u
                INNER JOIN Transactions t ON u.UserId = t.UserId";

            DataTable dt = DBHelper.ExecuteSelect(query);
            GridTransactions.DataSource = dt;
            GridTransactions.DataBind();
        }

        // Filter transactions by selected date range
        protected void btnFilter_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT u.UserName, u.Email, t.Amount, t.TransactionsDATE, t.Location, t.IsFraud
                FROM Users u
                INNER JOIN Transactions t ON u.UserId = t.UserId
                WHERE t.TransactionsDATE BETWEEN @Start AND @End";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@Start", txtStartDate.Text),
                new SqlParameter("@End", txtEndDate.Text)
            };

            DataTable dt = DBHelper.ExecuteSelect(query, parameters);
            GridTransactions.DataSource = dt;
            GridTransactions.DataBind();
        }
        protected void btnViewDashboard_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dashboard.aspx");
        }

        // Highlight fraud rows in red
        protected void GridTransactions_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                bool isFraud = Convert.ToBoolean(DataBinder.Eval(e.Row.DataItem, "IsFraud"));
                if (isFraud)
                {
                    e.Row.BackColor = System.Drawing.Color.LightCoral;
                }
            }
            
        }
    }
}
