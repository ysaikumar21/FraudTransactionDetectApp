# 🚨 Fraud Detection & Transaction Monitoring System

A complete real-world web application built using **ASP.NET Web Forms**, **C#**, and **SQL Server** that simulates intelligent fraud detection logic, transaction analytics, and admin-based access control — **without Machine Learning**.

---

## 📌 Project Overview

This system allows an admin to:
- Securely log in
- Add and flag transactions
- Filter transactions by date range
- Visualize fraudulent transactions by month
- View dashboards and reports in real-time

---

## 🚀 Key Features

🔐 **Admin Login** using session authentication  
📝 **Add Transactions** (fraud or valid)  
📅 **Date Range Filter** for transaction history  
📊 **Fraud Dashboard** with chart (monthly view)  
📋 **GridView Highlighting** for fraud rows  
🧭 **Smooth page flow**: Login → Add → View → Dashboard  
📁 **SQL Integration** using ADO.NET with clean DB helper

---

## 🧠 Workflow

1. **Login** via `Login.aspx` using `AdminUsers` table
2. Redirect to `AddTransaction.aspx` to submit transactions
3. Navigate to `ViewTransactions.aspx` and filter by date
4. View all transactions and frauds in a table
5. Click **Visualize Fraud Report** to see `Dashboard.aspx` (monthly chart)

---

## 🧰 Tech Stack

| Layer        | Tech Used                 |
|--------------|---------------------------|
| Frontend     | ASP.NET Web Forms (.aspx) |
| Backend      | C#, ADO.NET                |
| Database     | SQL Server                |
| Visualization| ASP.NET Chart Control     |
| IDE          | Visual Studio 2022        |

---

## 🗃️ Database Tables

### 📌 `AdminUsers`

| Column    | Type     |
|-----------|----------|
| UserId    | int      |
| UserName  | varchar  |
| Email     | varchar  |
| Password  | varchar  |
| IsAdmin   | bit      |

```sql
-- Sample admin login
INSERT INTO AdminUsers (UserName, Email, Password, IsAdmin)
VALUES ('admin', 'admin@example.com', 'admin123', 1);
📌 Users
Column	Type
UserId	int
UserName	varchar
Email	varchar

📌 Transactions
Column	Type
TransactionId	int
UserId	int
Amount	decimal
TransactionsDATE	datetime
IsFraud	bit

📸 Screenshots (Add Yours Here)
Login Page
<img width="838" height="444" alt="Screenshot 2025-07-13 181232" src="https://github.com/user-attachments/assets/3cb78fee-5622-43bd-9f40-7e2d4c125145" />


Add Transaction Page
<img width="1029" height="669" alt="Screenshot 2025-07-13 181816" src="https://github.com/user-attachments/assets/94fd1e72-e7da-4220-844a-4e0752223cb0" />


Transactions Table (Fraud Highlighted)
![Uploading Screenshot 2025-07-13 181759.png…]()


Dashboard with Monthly Chart
<img width="1859" height="902" alt="Screenshot 2025-07-13 181328" src="https://github.com/user-attachments/assets/5bd23e20-a23d-4390-a9b2-9b7e98ccdc53" />


🧪 How to Run This Project
Clone the repo in Visual Studio 2022

Set up SQL Server and run table creation scripts

Update Web.config with your DB connection string


Login with:

Username: admin

Password: admin123

✨ What I Learned
✅ Page lifecycle & session handling in ASP.NET
✅ Building visual dashboards using native .NET tools
✅ Clean separation of layers (UI, DB, logic)
✅ Using SQL joins, filters, date formats
✅ Creating full-stack .NET projects from scratch

🔗 About Me
I'm Saikumar Yaramala, a passionate fresher in full-stack development and data analytics.
Looking for opportunities in:

.NET Development

SQL + Dashboard Reporting

Real-time App Building

Let's connect and collaborate on impactful tech! 💬

📌 Tags
aspnet webforms sqlserver dashboard fraud-detection dotnet-developer student-project admin-login data-analytics visualstudio


---

### ✅ How to Add This to Your GitHub Repo:

1. In Visual Studio or File Explorer:
   - Create a file named `README.md` inside the root folder of your project
2. Paste the content above
3. Go to **Git > Changes > Commit All and Push**

Let me know if you'd like:
- 📸 Image links added
- 📄 A PDF version of this README
- 🔧 GitHub repo banner/header

You're now GitHub and resume ready, Saikumar! 💪🔥
