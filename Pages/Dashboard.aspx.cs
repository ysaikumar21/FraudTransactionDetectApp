using FraudTransactionDetectApp.Helpers;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FraudTransactionDetectApp.Pages
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }
            if (!IsPostBack)
                lblWelcome.Text = "Welcome, " + Session["UserName"];
            if (!IsPostBack)
                LoadFraudChart();

        }
        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Login.aspx");
        }

        private void LoadFraudChart()
        {
            string query = @"
                SELECT FORMAT(TransactionsDATE, 'yyyy-MM') AS Month, COUNT(*) AS FraudCount
                FROM Transactions
                WHERE IsFraud = 1
                GROUP BY FORMAT(TransactionsDATE, 'yyyy-MM')
                ORDER BY Month";

            DataTable dt = DBHelper.ExecuteSelect(query);

            chartFraud.Series["Frauds"].Points.DataBind(dt.DefaultView, "Month", "FraudCount", null);
            chartFraud.Series["Frauds"].IsValueShownAsLabel = true;
        }

    }
}