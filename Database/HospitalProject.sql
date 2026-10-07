-- Hospital Appointment System
-- Database setup script for Microsoft SQL Server
-- Reconstructed from the application's Entity Framework models.

IF DB_ID(N'HospitalProject') IS NULL
BEGIN
    CREATE DATABASE HospitalProject;
END;
GO

USE HospitalProject;
GO

-- Medical specialties
IF OBJECT_ID(N'dbo.Tbl_Expert', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Tbl_Expert
    (
        Expertid TINYINT NOT NULL PRIMARY KEY,
        ExpertName NVARCHAR(100) NOT NULL
    );
END;
GO

-- Doctors
IF OBJECT_ID(N'dbo.Tbl_Doctors', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Tbl_Doctors
    (
        Doctorid TINYINT NOT NULL PRIMARY KEY,
        DoctorName NVARCHAR(100) NOT NULL,
        DoctorLastName NVARCHAR(100) NOT NULL,
        DoctorExpert TINYINT NOT NULL,

        CONSTRAINT FK_Tbl_Doctors_Tbl_Expert
            FOREIGN KEY (DoctorExpert)
            REFERENCES dbo.Tbl_Expert(Expertid)
    );
END;
GO

-- Appointments
-- Column names and types are kept compatible with the current C# model.
IF OBJECT_ID(N'dbo.Tbl_Appointments', N'U') IS NULL
BEGIN
    CREATE TABLE dbo.Tbl_Appointments
    (
        AppointmentDate NVARCHAR(50) NOT NULL PRIMARY KEY,
        AppointmentDoctor NVARCHAR(200) NOT NULL,
        AppointmentExpert NVARCHAR(100) NOT NULL,
        PatientTC NVARCHAR(11) NOT NULL,
        PatientComplaint NVARCHAR(1000) NOT NULL,
        PatientName NVARCHAR(200) NOT NULL
    );
END;
GO

-- Sample specialties
IF NOT EXISTS (SELECT 1 FROM dbo.Tbl_Expert)
BEGIN
    INSERT INTO dbo.Tbl_Expert (Expertid, ExpertName)
    VALUES
        (1, N'Cardiology'),
        (2, N'Dermatology'),
        (3, N'Neurology'),
        (4, N'Orthopedics'),
        (5, N'Ophthalmology');
END;
GO

-- Sample doctors
IF NOT EXISTS (SELECT 1 FROM dbo.Tbl_Doctors)
BEGIN
    INSERT INTO dbo.Tbl_Doctors
        (Doctorid, DoctorName, DoctorLastName, DoctorExpert)
    VALUES
        (1, N'Emily', N'Carter', 1),
        (2, N'Daniel', N'Wilson', 2),
        (3, N'Sophia', N'Anderson', 3),
        (4, N'James', N'Taylor', 4),
        (5, N'Olivia', N'Martin', 5);
END;
GO

-- No sample patient or appointment records are inserted intentionally.
-- This avoids publishing fabricated or personal patient information.

SELECT * FROM dbo.Tbl_Expert;
SELECT * FROM dbo.Tbl_Doctors;
SELECT * FROM dbo.Tbl_Appointments;
GO
