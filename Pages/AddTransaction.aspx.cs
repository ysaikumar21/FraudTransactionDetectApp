using FraudTransactionDetectApp.Helpers;
using System;
using System.Data;
using System.Data.SqlClient;

namespace FraudDetectionApp.Pages
{
    public partial class AddTransaction : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["AdminId"] == null)
            {
                Response.Redirect("Login.aspx");
                return;
            }
            if (!IsPostBack)
                LoadUsers();
        }
        protected void btnGoToView_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewTransactions.aspx");
        }


        private void LoadUsers()
        {
            string query = "SELECT UserId, UserName FROM Users";
            DataTable dt = DBHelper.ExecuteSelect(query);
            ddlUsers.DataSource = dt;
            ddlUsers.DataTextField = "UserName";
            ddlUsers.DataValueField = "UserId";
            ddlUsers.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO Transactions (UserId, Amount, TransactionsDATE, Location, IsFraud)
                             VALUES (@UserId, @Amount, @Date, @Location, @IsFraud)";

            SqlParameter[] parameters = new SqlParameter[]
            {
                new SqlParameter("@UserId", ddlUsers.SelectedValue),
                new SqlParameter("@Amount", txtAmount.Text),
                new SqlParameter("@Date", txtDate.Text),
                new SqlParameter("@Location", txtLocation.Text),
                new SqlParameter("@IsFraud", chkFraud.Checked)
            };

            int rows = DBHelper.ExecuteCommand(query, parameters);
            if (rows > 0)
            {
                lblMessage.Text = "Transaction added successfully!";
                ClearForm();
            }
        }

        private void ClearForm()
        {
            txtAmount.Text = "";
            txtDate.Text = "";
            txtLocation.Text = "";
            chkFraud.Checked = false;
        }
    }
}
