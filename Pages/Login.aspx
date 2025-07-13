<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FraudDetectionApp.Pages.Login" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>Admin Login - Fraud Detection</title>
    <link href="../Styles/site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>🔐 Admin Login</h2>

            <asp:Label Text="Username:" runat="server" />
            <asp:TextBox ID="txtUsername" runat="server" />

            <br /><br />

            <asp:Label Text="Password:" runat="server" />
            <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" />

            <br /><br />

            <asp:Button ID="btnLogin" Text="Login" runat="server" OnClick="btnLogin_Click" />
            <br /><br />

            <asp:Label ID="lblStatus" runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
