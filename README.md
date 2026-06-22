# Clinic Management System 

An Object-Oriented Programming (OOP) based desktop application developed in C# to streamline and automate daily operations within a medical clinic. The system features role-based access control and comprehensive modules for patient management, medical examinations, inventory tracking, and financial statistics.

##  Key Features

The application is structured around specific user roles to ensure data security and operational efficiency:

### 1. Receptionist Module
* **Patient Management:** Add, update, delete, and search patient records (`PatientService`).
* **Appointment Scheduling:** Register patients for medical examinations and assign specific clinic services (`RegisterExam`).
* **Billing & Payment:** View the payment waiting list, review prescription and service details, and confirm final payments (`PaymentService`).

### 2. Doctor Module
* **Waiting List:** Real-time access to the queue of patients waiting for an examination.
* **Diagnosis & Prescription:** Input medical diagnoses and prescribe medication (`DoctorService`).
* **Automated Stock Checking:** The system automatically validates prescription quantities against real-time inventory stock and deducts accordingly upon finalizing the examination.

### 3. Administrator / Management Module
* **Inventory Management:** Full CRUD operations for medicines and medicine categories (`MedicineService`, `CategoryService`).
* **Clinic Services:** Manage available clinic services (e.g., blood tests, X-rays) and their pricing (`ServiceManagement`).
* **Medical History:** Track and search comprehensive medical records and past prescriptions (`HistoryService`).
* **Financial Statistics:** Generate revenue and patient volume reports within specific date ranges (`StatisticService`).

##  Architecture & Technologies

This project follows a strict **3-Tier Architecture** to separate concerns and maintain clean code:
* **GUI (Graphical User Interface):** The presentation layer handling user interactions.
* **BLL (Business Logic Layer):** Contains all the core logic, services, and transaction handling.
* **DAL (Data Access Layer):** Manages database connections and queries using **Entity Framework Core**.
* **Entities:** Defines the database schemas and data models.

**Tech Stack:**
* **Language:** C#
* **Framework:** .NET / Windows Forms (or WPF)
* **ORM:** Microsoft Entity Framework Core
* **Database:** SQL Server
* **Design Pattern:** Repository/Service Pattern, 3-Tier Architecture

##  Project Structure

The solution (`ClinicManagement.slnx`) is divided into the following key projects:
* `/ClinicManagement` - Frontend UI components.
* `/BLL` - Business logic services (e.g., `PatientService.cs`, `DoctorService.cs`, `PaymentService.cs`).
* `/DAL` - Database context (`ClinicDbContext`) and migrations.
* `/Entities` - Core models (`MedicalRecord`, `Patient`, `Medicine`, `PrescriptionDetail`, etc.).

##  Installation & Setup

1.  Clone the repository:
    ```bash
    git clone [https://github.com/Cmplex7/Clinic-Management-App.git](https://github.com/Cmplex7/Clinic-Management-App.git)
    ```
2.  Open the solution file (`ClinicManagement.slnx`) in **Visual Studio**.
3.  Ensure you have **.NET SDK** and **Entity Framework Core** tools installed.
4.  Configure your SQL Server connection string within the `DAL` project (typically in `appsettings.json` or `ClinicDbContext.cs`).
5.  Run Entity Framework Migrations to generate the database:
    ```bash
    Update-Database
    ```
6.  Build and Run the project (F5).

##  Author
**ThanhDat (CmpleX7)**
* [GitHub](https://github.com/CmpleX7)
