<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Dashboard.aspx.cs" Inherits="FraudTransactionDetectApp.Pages.Dashboard" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fraud Detection Dashboard</title>
    <link href="../Styles/site.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <asp:Label ID="lblWelcome" runat="server" />

            <h2>📊 Monthly Fraud Transactions</h2>
            <asp:Chart ID="chartFraud" runat="server" Width="900px" Height="400px">
                <Series>
                    <asp:Series Name="Frauds" ChartType="Line" XValueMember="Month" YValueMembers="FraudCount" />
                </Series>
                <ChartAreas>
                    <asp:ChartArea Name="ChartArea1" />
                </ChartAreas>
            </asp:Chart>
        </div>
        <asp:Button ID="btnLogout" runat="server" Text="Logout" OnClick="btnLogout_Click" />

    </form>
</body>
</html>
