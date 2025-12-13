# Operations & Analytics Dashboard 

A full-stack ASP.NET Core MVC web application built in Visual Studio 2022 that combines operational CRUD functionality with real-time analytics and reporting.

This project simulates an internal business dashboard used by operations teams to track orders, revenue, and performance trends, while providing management-friendly KPIs and visual insights.

# Features
## Operations Management (CRUD)
1. Create, view, edit, and delete orders
2. Track:
     - Order date
     - Customer name
     - Product name
     - Quantity & unit price
     - Order status (Pending, Processing, Shipped, Delivered, Cancelled)
3. Automatically calculated order totals

## Analytics Dashboard
1. Total orders
2. Total revenue
3. Orders in the last 7 days
4. Revenue in the last 7 days
5. Revenue by day (last 7 days) bar chart
6. Recent orders table

## Real-World Dashboard UX
1. Metric cards (KPI tiles)
2. Chart visualization using Chart.js
3. Responsive grid layout
4. Clean, modern internal-tool styling

## Tech Stack
| Layer  | Technology |
|-----------|--------|
| Frontend | ASP.NET Core MVC + Razor Views |
| Backend | C# · ASP.NET Core 8 |
| Database | SQL Server LocalDB(I have SSMS in my machine.) |
| ORM | Entity Framework Core |
| Charts | Chart.js |
| IDE | Visual Studio 2022(This is the version I have in my machine.) |


# Getting Started
## Unzip the file somewhere on your machine.
Open Visual Studio 2022(or your version) → File → Open → Project/Solution → select HelpdeskTicketingSystem.sln.
# In Package Manager Console, run:
- Add-Migration InitialCreate - creates the migration file for the Ticket table.
- Update-Database – actually creates the HelpdeskTicketingSystemDb database and the Tickets table.
- After run: Check your SSMS database and table.
- Hit F5 (or Run).

## Update the Database Connection String
In appsettings.json, set up LocalDB:
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=HelpdeskTicketingSystemDb;Trusted_Connection=True;"
}


