# Helpdesk Ticketing System (IT Support Portal)

A full-stack ASP.NET Core MVC web application built in Visual Studio 2022 that allows internal IT teams to manage support tickets submitted by employees.
Users can create, view, update, and delete tickets, while IT staff can track ticket statuses, priorities, and assignments.

This project demonstrates real-world enterprise development using C#, Entity Framework Core, SQL Server LocalDB, and Razor Views.

# Features
## Ticket Management
- Create a new IT support ticket
- Edit ticket details and update status
- View ticket details in a clean UI
- Delete tickets
- Track timestamps (created & updated)

## Ticket Fields
# Each ticket includes:
- Title
- Description
- Requested By
- Assigned To
- Priority (Low, Medium, High, Critical)
- Status (New, In Progress, Resolved, Closed)
- Created / Updated timestamps

## Fully Functional UI
- Responsive Razor views
- Table-based ticket listing
- CRUD pages (Create, Edit, Details, Delete)
- Custom CSS styling

## Tech Stack
| Layer  | Technology |
|-----------|--------|
| Frontend | ASP.NET Core MVC + Razor Views |
| Backend | C# · ASP.NET Core 8 |
| Database | SQL Server LocalDB(I have SSMS in my machine.) |
| ORM | Entity Framework Core |
| IDE | Visual Studio 2022(This is the version I have in my machine.) |

# Getting Started
## Unzip the file somewhere on your machine.
- Open Visual Studio 2022(or your version) → File → Open → Project/Solution → select HelpdeskTicketingSystem.sln.
- Make sure your .sln project file is inside the unzip folder for this project to work.
- I have to zip this large project so I can easily upload this to github.

## In Package Manager Console, run:
- Add-Migration InitialCreate - creates the migration file for the Ticket table.
- Update-Database – actually creates the HelpdeskTicketingSystemDb database and the Tickets table.
- After run: Check your SSMS database and table.
- Hit F5 (or Run).

## Update the Database Connection String
In appsettings.json, set up LocalDB:
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=HelpdeskTicketingSystemDb;Trusted_Connection=True;"
}

## What You Can Do
1. Submit a new ticket
2. Track IT requests
3. View/change ticket status
4. Log who requested and who is assigned
5. Keep a clean audit trail of changes


