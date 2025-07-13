<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewTransactions.aspx.cs" Inherits="FraudDetectionApp.Pages.ViewTransactions" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>View Transactions</title>
    <link href="../Styles/site.css" rel="stylesheet" />
    <style>
    .centered-btn {
        display: block;
        margin: 30px auto;
        padding: 10px 25px;
        font-size: 16px;
        background-color: #007bff;
        color: white;
        border: none;
        border-radius: 6px;
        cursor: pointer;
    }

    .centered-btn:hover {
        background-color: #0056b3;
    }
</style>

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>🔎 View Transactions</h2>

            <div class="filter">
                <asp:Label ID="lblStart" runat="server" Text="Start Date: " />
                <asp:TextBox ID="txtStartDate" runat="server" TextMode="Date" />

                <asp:Label ID="lblEnd" runat="server" Text="End Date: " />
                <asp:TextBox ID="txtEndDate" runat="server" TextMode="Date" />

                <asp:Button ID="btnFilter" runat="server" Text="Filter" OnClick="btnFilter_Click" />
            </div>

            <asp:GridView ID="GridTransactions" runat="server" AutoGenerateColumns="False" CssClass="grid" OnRowDataBound="GridTransactions_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="UserName" HeaderText="UserName" />
                    <asp:BoundField DataField="Email" HeaderText="Email" />
                    <asp:BoundField DataField="Amount" HeaderText="Amount" />
                    <asp:BoundField DataField="TransactionsDATE" HeaderText="Date" DataFormatString="{0:yyyy-MM-dd}" />
                    <asp:BoundField DataField="Location" HeaderText="Location" />
                    <asp:BoundField DataField="IsFraud" HeaderText="Fraud" />
                </Columns>
            </asp:GridView>
        </div>
        <br /><br />
            <asp:Button ID="btnViewDashboard" runat="server" Text="📊 Visualize Fraud Report" OnClick="btnViewDashboard_Click" CssClass="centered-btn" />

    </form>
</body>
</html>
