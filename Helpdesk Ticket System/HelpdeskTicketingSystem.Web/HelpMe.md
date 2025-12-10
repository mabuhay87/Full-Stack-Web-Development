# Helpdesk Ticketing System (IT Support Portal)

A full-stack ASP.NET Core MVC web application built in Visual Studio 2022 that allows internal IT teams to manage support tickets submitted by employees.
Users can create, view, update, and delete tickets, while IT staff can track ticket statuses, priorities, and assignments.

This project demonstrates real-world enterprise development using C#, Entity Framework Core, SQL Server LocalDB, and Razor Views.

# Features
## Ticket Management
Create a new IT support ticket
Edit ticket details and update status
View ticket details in a clean UI
Delete tickets
Track timestamps (created & updated)

## Ticket Fields
# Each ticket includes:
Title
Description
Requested By
Assigned To
Priority (Low, Medium, High, Critical)
Status (New, In Progress, Resolved, Closed)
Created / Updated timestamps

## Fully Functional UI
Responsive Razor views
Table-based ticket listing
CRUD pages (Create, Edit, Details, Delete)
Custom CSS styling

## Tech Stack
# Layer	     Technology
Frontend	 ASP.NET Core MVC + Razor Views
Backend	     C# · ASP.NET Core 8
Database	 SQL Server LocalDB(I have SSMS in my machine.)
ORM	         Entity Framework Core
IDE	         Visual Studio 2022(This is the version I have in my machine.)

# Getting Started
## Clone or Download the Project
Open your Visual Studio version and open Project file .sln

## Update the Database Connection String
In appsettings.json, set up LocalDB:
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=HelpdeskTicketingSystemDb;Trusted_Connection=True;"
}

## Apply Migrations
Open Package Manager Console in Visual Studio:
Note: You need to run these commands one at a time. 
*Add-Migration InitialCreate - creates the migration file for the Ticket table.
*Update-Database – actually creates the HelpdeskTicketingSystemDb database and the Tickets table.
After run: Check your SSMS database and table.

## Run the App
Press F5

## What You Can Do
Submit a new ticket
Track IT requests
View/change ticket status
Log who requested and who is assigned
Keep a clean audit trail of changes
