<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddTransaction.aspx.cs" Inherits="FraudDetectionApp.Pages.AddTransaction" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add New Transaction</title>
    <link href="../Styles/site.css" rel="stylesheet" />
    <style>
        .centered-btn {
    display: block;
    margin: 20px auto;
    padding: 10px 20px;
    font-size: 16px;
    background-color: #28a745;
    color: white;
    border: none;
    border-radius: 5px;
}

    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>➕ Add New Transaction</h2>

            <asp:Label runat="server" Text="Select User: " />
            <asp:DropDownList ID="ddlUsers" runat="server" />

            <br /><br />
            <asp:Label runat="server" Text="Amount: " />
            <asp:TextBox ID="txtAmount" runat="server" />

            <br /><br />
            <asp:Label runat="server" Text="Transaction Date: " />
            <asp:TextBox ID="txtDate" runat="server" TextMode="Date" />

            <br /><br />
            <asp:Label runat="server" Text="Location: " />
            <asp:TextBox ID="txtLocation" runat="server" />

            <br /><br />
            <asp:CheckBox ID="chkFraud" runat="server" Text="Is Fraud?" />

            <br /><br />
            <asp:Button ID="btnSubmit" runat="server" Text="Add Transaction" OnClick="btnSubmit_Click" />
            <br /><br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Green" />
        </div>
         <asp:Button ID="btnGoToView" runat="server" Text="View Transactions" OnClick="btnGoToView_Click" CssClass="centered-btn" />
    </form>
   

</body>
</html>
