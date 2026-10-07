# Hospital Appointment System

A Windows desktop application for creating and viewing hospital appointments. The project was built with C#, Windows Forms, Entity Framework Core, and Microsoft SQL Server.

## Features

- Enter and validate patient information
- Select a medical specialty and doctor
- Choose an appointment date and time
- Prevent appointments from being created in the past
- Prevent duplicate appointment time slots
- Save appointments to SQL Server
- Display existing appointments in the application

## Technologies

- C#
- .NET 9
- Windows Forms
- Entity Framework Core 9
- Microsoft SQL Server

## Project Structure

```text
Hospital-Appointment-System/
├── Database/
│   └── HospitalProject.sql
├── Form1.cs
├── Form1.Designer.cs
├── Form1.resx
├── Program.cs
├── WinFormsApp1.csproj
├── .gitignore
└── README.md
```

## Database Setup

1. Install Microsoft SQL Server.
2. Open SQL Server Management Studio (SSMS) or another SQL Server client.
3. Run `Database/HospitalProject.sql`.
4. The script creates the `HospitalProject` database, the required tables, sample medical specialties, and sample doctors.

No sample patient records are included.

## Database Connection

By default, the application uses the following local connection:

```text
Server=localhost;Database=HospitalProject;Trusted_Connection=True;TrustServerCertificate=True
```

If your SQL Server uses a different server or instance name, set the `HOSPITAL_DB_CONNECTION` environment variable to your own connection string before starting the application.

Example for SQL Server Express:

```text
Server=.\\SQLEXPRESS;Database=HospitalProject;Trusted_Connection=True;TrustServerCertificate=True
```

## Running the Project

1. Clone or download this repository.
2. Open `WinFormsApp1.csproj` in Visual Studio.
3. Make sure the database has been created using `Database/HospitalProject.sql`.
4. Restore the NuGet packages if Visual Studio does not restore them automatically.
5. Run the application.

## Notes

The database setup script contains only sample doctor and specialty data. It does not include real patient information.
