# 📚 Library Management System (C# WinForms & ADO.NET)

## 📌 Project Description

This project is a layered library management system developed using C# Windows Forms.

The application uses an MSSQL database, and all database operations are manually handled using ADO.NET.

One of the key features of this project is that on first launch, it automatically:

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

- 📊 Add, update, delete books (CRUD operations)
- 👤 Member management
- 🔐 User and authorization system
- 📚 Borrow and return book operations
- 💰 Late return penalty calculation
- 🗄️ MSSQL database integration
- ⚙️ Automatic database and table creation
- 🔌 Dynamic connection handling

## 🛠️ Technologies Used

- C#
- Windows Forms
- MSSQL
- ADO.NET
- SQL (manual queries)

## 📋 Requirements

- Visual Studio 2022
- .NET Framework 4.7.2
- Microsoft SQL Server
- SQL Server Management Studio (optional)

## ⚙️ Database Initialization

When the application starts:

1. MSSQL connection is checked
2. If `KutuphaneDB` does not exist, it is automatically created
3. Required tables are generated:

   - Books
   - Members
   - Users
   - Loans
   - Transactions

4. The system becomes ready to use

## 💻 How to Run
Ensure MSSQL Server is installed
Clone the repository:
git clone <repo-link>
Open the project in Visual Studio
Verify database connection settings
Run the application
## 💡 Key Learnings

Through this project, I gained hands-on experience in:

Manual database management using ADO.NET
Layered architecture design and implementation
Writing and optimizing SQL queries
Developing real-world business logic scenarios
📄 Note

This project was developed during my education and internship period.

## 🧠 Developer Notes

This project was developed to strengthen my understanding of ADO.NET, MSSQL integration, and layered architecture principles.

During development, I focused on:

- Database connection management
- SQL query execution
- CRUD operations
- Structuring scalable multi-layer architecture
- Real-world business logic implementation

There are still areas for improvement, and I plan to continue refactoring and enhancing the project over time.

## 🔐 Configuration

Before running the project, update the database connection string according to your local MSSQL setup:

Example:

```txt
Data Source=YOUR_SERVER_NAME;
Initial Catalog=KutuphaneDB;
Integrated Security=True;

