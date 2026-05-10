# Premium Event & Venue Management System

A professional desktop database management system developed using **C# WinForms**, **Microsoft SQL Server**, and **ADO.NET**.

This project was developed as part of a university **Database Systems Project**.

---

# Features

## Dashboard

* System overview dashboard
* Real-time statistics cards
* Quick action shortcuts
* SQL Server connection status

## Venue Management

* Add new venues
* Update venue information
* Delete venues
* Search venues
* Display venue data in DataGridView

## Patron Management

* Add patrons/customers
* Manage patron information
* Store multiple phone numbers
* Search and update patron records

## Gathering Management

* Create and manage gatherings/events
* Assign venues to gatherings
* Manage event status and schedules

## Ticket Category Management

* Create ticket categories
* Manage prices and seat allocations
* Connect categories to gatherings

## Purchase Management

* Sell entry passes/tickets
* Store purchase information
* Manage payment methods

## Technical Staff Management

* Add technical staff members
* Assign supervisors
* Manage staff contact information

## Reports

* Revenue reports
* Venue usage reports
* Attendance reports
* Staff reports
* SQL JOIN queries

---

# Technologies Used

* C#
* Windows Forms (WinForms)
* Microsoft SQL Server
* ADO.NET
* PowerDesigner
* ERDPlus
* Visual Studio

---

# Database Features

* Conceptual ERD
* Physical ERD
* SQL DDL Script
* Primary Keys
* Foreign Keys
* Composite Keys
* Multivalued Attributes
* Relationship Tables
* SQL Constraints
* JOIN Queries

---

# Project Structure

```text
PremiumEventVenueManagementSystemApp/
│
├── Forms/
│   ├── DashboardForm
│   ├── VenueForm
│   ├── PatronForm
│   ├── GatheringForm
│   ├── TicketCategoryForm
│   ├── PurchaseForm
│   ├── TechnicalStaffForm
│   └── ReportsForm
│
├── Database/
│   └── Database.cs
│
├── SQL/
│   └── database.sql
│
├── Documentation/
│   ├── Conceptual ERD
│   ├── Physical ERD
│   └── Project PDF
│
└── README.md
```

---

# How to Run the Project

## 1. Restore Database

* Open SQL Server Management Studio
* Run the provided DDL SQL file

## 2. Open the Project

* Open the solution in Visual Studio

## 3. Configure Connection String

Inside:

```csharp
Database.cs
```

Update:

```csharp
Data Source=YOUR_SERVER_NAME;
Initial Catalog=PremiumEventVenueManagementSystem;
Integrated Security=True;
```

## 4. Run the Application

Press:

```text
F5
```

OR

```text
Start Debugging
```

---

# Notes

* The project uses ADO.NET only.
* No ORM or Entity Framework was used.
* All SQL queries are written manually.
* Parameterized SQL queries are used for security.

---

# Developed By

Ahmed Tolba
Tarik samy
Database Systems Project
Second Year — Second Term

---

# License

This project is developed for educational purposes.
