# 🚌 BusTick - Bus Ticketing Automation (Database-First)

This is a bus reservation system I developed for my **CMPE 232 Database Systems** course. In this project, I followed a **Database-First** approach, meaning I designed and built the entire database in SQL Server before writing any application code.

## How I Built the Database

<img width="1644" height="1620" alt="EntityDesignerDiagram" src="https://github.com/user-attachments/assets/b38d9317-0ce1-49f4-b1b0-3bc49db25f12" />

I focused heavily on the relational design to ensure the schema follows **BCNF** standards. I scripted everything in the database manually:

* **Tables & Logic:** I created the tables with strict `CHECK` constraints (for example, ensuring arrival time is always after departure time) and managed all Primary/Foreign Key relationships myself.
* **Performance with Indices:** To speed up trip searches, I added strategic indices on columns like `DepartureTime`.
* **Automation with Triggers:** I wrote several triggers to handle background tasks, such as `TRG_UpdateSeatStatus` for managing seat availability.
* **Simplifying with Views:** I created SQL Views like `v_PassengerTickets` to pull complex data more efficiently.
* **Data Testing:** I generated and inserted a comprehensive set of mock data to test real-world scenarios.

## Tech Stack
* **Database:** MS SQL Server
* **Backend:** ASP.NET Core with Entity Framework (Database-First)
* **Frontend:** Blazor / Razor Pages

## How to Run the Application
### Requirements
* .NET 8 SDK
* SQL Server & SSMS
* Visual Studio 2022

### Database Setup
1. Open **SQL Server Management Studio (SSMS)**.
2. Create a new database named `BusTick`.
3. Run the provided SQL scripts (found in the project files) to create tables, triggers, and views.

### Running the Project
1. Open the `.sln` file in Visual Studio.
2. Update the connection string in `appsettings.json` if necessary.
3. Set `BustickWeb` as the startup project and press **F5**.
