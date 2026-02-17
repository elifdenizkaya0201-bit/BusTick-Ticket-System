
# BustickWeb – CMPE232 Project

This project was developed for the **CMPE232 – Database Systems** course. 
 
It is a simple web-based bus ticket system that demonstrates how a relational database can be integrated with a web application.

The system includes basic administrative functionalities, such as creating and managing trips, and focuses primarily on proper database design, relationships, and CRUD operations.

---

## Libraries and Technologies Used

### Backend
- **.NET 8**
- **ASP.NET Core**
- **Blazor Server**
- **Entity Framework Core**
- **Microsoft.EntityFrameworkCore.SqlServer**

### Database
- **Microsoft SQL Server**
- **SQL Server Management Studio (SSMS)**

### Frontend
- **Blazor Components**

---

## How to Run the Application

### Requirements
Before running the project, make sure you have:
- .NET 8 SDK installed
- SQL Server installed
- Visual Studio 2022 with ASP.NET workload

---

### Database Setup
1. Open **SQL Server Management Studio (SSMS)**.
2. Create a new database named: BusTick
3. Run the provided SQL scripts to create the tables, schemas, and relationships.
4. Ensure that the database is running before starting the application.

---

### Connection String Configuration
The database connection is defined in the `appsettings.json` file.

```json
"ConnectionStrings": {
"DefaultConnection": "Server=.;Database=BusTick;Trusted_Connection=True;TrustServerCertificate=True;"
}
If your SQL Server instance name is different, update the Server value accordingly.

### Running the Project

Open the solution file (.sln) in Visual Studio.

Set BustickWeb as the startup project.

Press F5 or click Run.

The application will open automatically in your browser.

### Project Overview

The application includes basic admin functionalities such as creating, editing, and deleting trips.

Foreign key relationships are enforced to maintain data integrity.

Dropdown menus are used instead of manual ID input to improve usability.
