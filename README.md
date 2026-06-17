# Gym Membership Manager

A desktop application for managing the day-to-day operations of a gym — members, trainers, payments, and attendance — built with **C# WinForms** on **.NET 10** and backed by **SQL Server** through raw **ADO.NET**.

The solution follows a clean two-project layout that separates business logic and data access from the user interface.

---

## Project Information

**Project Title:** Gym Membership Manager

### Group Members

| Role | Name | Roll No. |
|------|------|----------|
| Group Leader | Maryam Naz | F23BDOCS1M01086 |
| Member | Iqra Naz | F23BDOCS1M01074 |
| Member | Tuba Habib | F23BDOCS1M01066 |

---

## Features

- **Dashboard** — at-a-glance summary cards (total members, active members, total trainers, paid / pending / overdue payments, total attendance) plus charts for payment status and membership plan distribution, rendered with WinForms DataVisualization.
- **Members** — full create, read, update, delete (CRUD) management of gym members, with search and filtering by membership plan and status.
- **Trainers** — CRUD management of trainers, with search across name, phone, email, and specialization.
- **Payments** — record and track membership payments, linking each payment to a member and (optionally) a trainer, with filtering by payment status.
- **Attendance** — log member check-ins (date, time, notes) and view attendance history, with search across member and date.
- **Status bar counts** — the main window's status strip shows a live count of total members and trainers, refreshed as you navigate.
- **Reusable pickers** — `MemberPicker` and `TrainerPicker` dialogs let you select an existing member or trainer when creating related records.

---

## Architecture

The solution is split into two projects:

### `App.Core` (class library, `net10.0`)
Holds all business logic and data access. It has no UI dependency.

- **Models** — `GymMember`, `Trainer`, `MembershipPayment`, `Attendance`. Each model generates its own prefixed ID using a short GUID (`GM-` for members, `T-` for trainers, `P-` for payments, `ATT-` for attendance).
- **Contracts** — service interfaces (`IGymMemberService`, `ITrainerService`, `IPaymentService`, `IAttendanceService`) that define the CRUD and search operations for each entity.
- **Services** — ADO.NET implementations (`DBGymMemberService`, `DBTrainerService`, `DBPaymentService`, `DBAttendanceService`) that talk to SQL Server using `Microsoft.Data.SqlClient`, parameterized queries, async/await, and `SqlDataReader`.
- **Utilities** — enums for `MembershipPlanEnum` (Basic, Standard, Premium, VIP, Student, Corporate, Monthly, Annual), `MemberStatusEnum` (Active, Inactive, Suspended), and `PaymentStatusEnum` (Paid, Pending, Overdue).

### `App.WindowsApp` (Windows Forms app, `net10.0-windows`)
The presentation layer.

- **Forms** — `MainForm` is the application shell; it loads the connection string, instantiates the services, hosts the navigable views, and keeps the status-bar counts up to date. Entity-specific dialogs (`GymMemberForm`, `TrainerForm`, `PaymentForm`, `AttendanceForm`) handle add/edit, with `FormModeEnums` distinguishing create vs. edit mode.
- **Views** — `UserControl` panels swapped into the main window: `DashboardView`, `GymMembersView`, `TrainersView`, `PaymentsView`, `AttendanceView`.

Services are constructed once in `MainForm` with the shared connection string and injected into each view, keeping data access centralized.

---

## Technology Stack

| Layer | Technology |
|-------|------------|
| Language | C# |
| Runtime | .NET 10 |
| UI | Windows Forms (WinForms) |
| Charts | WinForms.DataVisualization 1.10.2 |
| Data access | ADO.NET via Microsoft.Data.SqlClient 7.0.1 |
| Database | SQL Server |
| Config | System.Configuration.ConfigurationManager 9.0.4 |

---

## Database

The application connects to a SQL Server database named **`GymDB`**. The connection string lives in `App.WindowsApp/App.config`:

```xml
<connectionStrings>
  <add name="GymDB"
       connectionString="Server=localhost;Database=GymDB;Trusted_Connection=True;TrustServerCertificate=True;"
       providerName="Microsoft.Data.SqlClient" />
</connectionStrings>
```

### Schema

The app expects four tables. Based on the queries used by the services, the schema is:

```sql
CREATE TABLE GymMember (
    Id        VARCHAR(20)   PRIMARY KEY,
    Name      NVARCHAR(100) NOT NULL,
    Phone     NVARCHAR(30),
    Email     NVARCHAR(100),
    Address   NVARCHAR(200),
    [Plan]    NVARCHAR(20),
    [Status]  NVARCHAR(20),
    JoinDate  DATETIME
);

CREATE TABLE Trainer (
    Id             VARCHAR(20)   PRIMARY KEY,
    Name           NVARCHAR(100) NOT NULL,
    Phone          NVARCHAR(30),
    Email          NVARCHAR(100),
    Specialization NVARCHAR(100)
);

CREATE TABLE MembershipPayment (
    Id          VARCHAR(20) PRIMARY KEY,
    MemberId    VARCHAR(20),
    MemberName  NVARCHAR(100),
    TrainerId   VARCHAR(20),
    TrainerName NVARCHAR(100),
    PaymentDate DATETIME NULL,
    DueDate     DATETIME NULL,
    [Status]    NVARCHAR(20)
);

CREATE TABLE Attendance (
    Id          VARCHAR(20) PRIMARY KEY,
    MemberId    VARCHAR(20),
    MemberName  NVARCHAR(100),
    CheckInDate DATETIME,
    CheckInTime TIME,
    Notes       NVARCHAR(200)
);
```

> Note: `Plan` and `Status` are reserved-style keywords in SQL Server, so they are wrapped in square brackets (`[Plan]`, `[Status]`) throughout the queries.

---

## Getting Started

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download)
- SQL Server (Express or higher) running locally
- Visual Studio 2022 (v17+) or any editor with the .NET CLI

### Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/maryam2004-code/Gym_Membership_Manager.git
   cd Gym_Membership_Manager
   ```

2. **Create the database**
   - Create a database named `GymDB` in SQL Server.
   - Run the schema script above to create the four tables.

3. **Check the connection string**
   - Open `App.WindowsApp/App.config` and adjust the `Server=` value if your SQL Server instance isn't `localhost` (for example, `Server=localhost\SQLEXPRESS`).

4. **Build and run**
   ```bash
   dotnet build
   dotnet run --project App.WindowsApp
   ```
   Or open `Gym_Membership_Manager.sln` in Visual Studio and press **F5**.

---

## Project Structure

```
Gym_Membership_Manager/
├── Gym_Membership_Manager.sln
├── App.Core/                       # Business logic & data access (no UI)
│   ├── Models/                     # GymMember, Trainer, MembershipPayment, Attendance
│   ├── Contracts/                  # Service interfaces
│   ├── Services/                   # ADO.NET service implementations
│   └── Utilities/                  # Enums (Plan, Status, PaymentStatus)
└── App.WindowsApp/                 # WinForms UI
    ├── Program.cs                  # Entry point
    ├── App.config                  # Connection string
    ├── Forms/                      # MainForm + add/edit dialogs + pickers
    └── Views/                      # Dashboard, Members, Trainers, Payments, Attendance
```

---

## Notes

- All database access uses **parameterized queries**, guarding against SQL injection.
- Data access methods are **asynchronous** (`async`/`await`) to keep the UI responsive.
- IDs are generated client-side as short, prefixed GUIDs, so no identity columns are required.
- The UI keeps a single cached instance of each view in `MainForm` and refreshes the dashboard whenever it is shown again.