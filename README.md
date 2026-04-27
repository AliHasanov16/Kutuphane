# 📚 Kutuphane Management System (C# WinForms & ADO.NET)

## 📌 Project Description

This project is a layered library management system developed using C# Windows Forms.

The application works with an MSSQL database, and all database operations are handled manually using ADO.NET.

One of the key features of this project is that when it is first launched, it automatically:

- Creates the database
- Creates the required tables
- Prepares initial system data

## 🏗️ Architecture

The project is developed using a layered architecture:

- **DAL (Data Access Layer)** → Database operations
- **BLL (Business Logic Layer)** → Business rules
- **EL (Entity Layer)** → Data models
- **UI (Windows Forms)** → User interface

## 🚀 Features

- 📊 Add, update, delete books (CRUD)
- 👤 Member management
- 🔐 User and role system
- 📚 Borrow and return books
- 💰 Late return penalty calculation
- 🗄️ MSSQL database integration
- ⚙️ Automatic database and table creation
- 🔌 Dynamic connection management

## 🛠️ Technologies Used

- C#
- Windows Forms
- MSSQL
- ADO.NET
- SQL (manual queries)

## ⚙️ Database Initialization

When the application starts:

1. MSSQL connection is checked
2. If `KutuphaneDB` does not exist, it is created
3. Required tables are automatically created:
   - Books
   - Members
   - Users
   - Loans
   - Transactions
4. System becomes ready to use

## 🔐 Configuration

Before running the project, update the database connection string according to your local MSSQL setup:

```txt
Data Source=YOUR_SERVER_NAME;
Initial Catalog=KutuphaneDB;
Integrated Security=True;
