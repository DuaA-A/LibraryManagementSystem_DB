<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>
    <header>
        <h1>Library Management System</h1>
        <p>A database project for managing library operations</p>
    </header>
    <main>
        <h2>Project Overview</h2>
        <p>This project is a Library Management System, designed and developed as part of a database coursework. It covers the entire process, starting from conceptual and logical design (ERD) to the physical schema and implementation in C#.</p>
        <h2>Key Features</h2>
        <ul>
            <li>User roles: Admin and Student Dashboards</li>
            <li>Book management: Add, update, and delete book records</li>
            <li>Admin sign-up and authentication</li>
            <li>Student book borrowing functionality</li>
            <li>Interactive forms built using Windows Forms (WinForms)</li>
            <li>Database schema implementation in SQL Server</li>
        </ul>
        <h2>Project Workflow</h2>
        <ol>
            <li>Designed the logical and physical ERD using database design tools.</li>
            <li>Created the database schema in SQL Server.</li>
            <li>Developed the front-end application using C# and WinForms.</li>
            <li>Integrated the application with the SQL Server database for CRUD operations.</li>
        </ol>
        <h2>Files in the Repository</h2>
        <ul>
            <li><code>AddBook.cs</code>, <code>AddBook.Designer.cs</code>, <code>AddBook.resx</code>: Handles the form and logic for adding books.</li>
            <li><code>AdminDashboard.cs</code>, <code>AdminDashboard.Designer.cs</code>, <code>AdminDashboard.resx</code>: Admin dashboard implementation.</li>
            <li><code>AdminSignUp.cs</code>, <code>AdminSignUp.Designer.cs</code>, <code>AdminSignUp.resx</code>: Admin sign-up form and logic.</li>
            <li><code>Form1.cs</code>, <code>Form1.Designer.cs</code>, <code>Form1.resx</code>: Main application form.</li>
            <li><code>LibraryManagementSystem.csproj</code>: Project configuration file.</li>
            <li><code>StudentDashboard.cs</code>, <code>StudentDashboard.Designer.cs</code>, <code>StudentDashboard.resx</code>: Student dashboard implementation.</li>
            <li><code>App.config</code>: Configuration file for database connection strings.</li>
            <li><code>Program.cs</code>: Entry point of the project.</li>
        </ul>
        <h2>Database Schema</h2>
        <p>The database schema includes tables for:</p>
        <ul>
            <li><code>Books</code>: Contains book details such as title, author, and availability status.</li>
            <li><code>Users</code>: Stores user information for both admins and students.</li>
            <li><code>Transactions</code>: Tracks book borrowing and return activities.</li>
        </ul>
        <h2>How to Run the Project</h2>
        <ol>
            <li>Clone the repository to your local machine.</li>
            <li>Open the project in Visual Studio.</li>
            <li>Ensure the <code>App.config</code> file has the correct connection string for your SQL Server.</li>
            <li>Compile and run the project.</li>
        </ol>
        <h2>License</h2>
        <p>This project is open-source. You can use and modify it as needed.</p>
    </main>
    <footer>
        <p>&copy; 2025 Library Management System Project</p>
    </footer>
</body>
</html>
