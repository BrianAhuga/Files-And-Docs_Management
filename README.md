# Files & Documents Management System

A web-based **file and document management application** built with **ASP.NET Core MVC and .NET 8**, designed to provide a simple and structured way to upload, manage, and organize digital documents.

The application uses **Entity Framework Core** and **SQL Server** for persistent data management and follows the Model-View-Controller architecture provided by ASP.NET Core.

## Overview

The **Files & Documents Management System** demonstrates how a web application can handle document management through a centralized interface.

The project provides a foundation for managing digital documents while demonstrating practical concepts such as file uploads, database persistence, MVC architecture, Entity Framework Core, and server-side application development.

## Features

* Upload documents and files
* Store document metadata
* View uploaded documents
* Manage existing documents
* Document management interface
* SQL Server database integration
* Entity Framework Core
* Database migrations
* ASP.NET Core MVC architecture
* Server-side validation
* Structured document storage

## Technology Stack

| Technology                  | Purpose                               |
| --------------------------- | ------------------------------------- |
| **C#**                      | Primary programming language          |
| **.NET 8**                  | Application framework                 |
| **ASP.NET Core MVC**        | Web application architecture          |
| **Entity Framework Core 8** | Database access and ORM               |
| **SQL Server**              | Database                              |
| **Razor Views**             | Server-rendered user interface        |
| **HTML / CSS / JavaScript** | Frontend presentation and interaction |

The project targets **.NET 8** and uses Entity Framework Core 8 with SQL Server.

## Architecture

The application follows the standard ASP.NET Core MVC architecture:

```text id="x1v3b7"
Files-And-Docs_Management
│
├── Controllers
│   ├── DocumentController.cs
│   └── HomeController.cs
│
├── Data
│
├── Migrations
│
├── Models
│   ├── Document.cs
│   └── ErrorViewModel.cs
│
├── Properties
│
├── Views
│
├── wwwroot
│
├── DocumentsAndFilesUploadDB
│
├── Program.cs
├── appsettings.json
└── DocumentUploader_MVCCore.csproj
```

The project separates controllers, models, database access, migrations, views, and static assets into dedicated application layers.

## Document Management

The application's document functionality is centered around the `DocumentController`, which provides the main entry point for document-related operations.

The `Document` model represents the information associated with managed documents.

The system can be extended to support additional document metadata such as:

* Document name
* File name
* File type
* File size
* Upload date
* Description
* Document category
* Storage location

## Database

The application uses **Microsoft SQL Server** together with **Entity Framework Core 8**.

Entity Framework Core is responsible for database communication and object-relational mapping, while migrations are included in the repository for managing database schema changes.

## Getting Started

### Prerequisites

Make sure you have the following installed:

* [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
* Microsoft SQL Server
* Visual Studio 2022 or Visual Studio Code
* Git

### Clone the Repository

```bash id="8i0z3p"
git clone https://github.com/BrianAhuga/Files-And-Docs_Management.git
```

Navigate into the project:

```bash id="z7g8lq"
cd Files-And-Docs_Management
```

### Restore Dependencies

```bash id="k6m2v8"
dotnet restore
```

## Configure the Database

Update the database connection string in `appsettings.json` with your SQL Server configuration.

Example:

```json id="8r7w5f"
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=DocumentsAndFilesUploadDB;Trusted_Connection=True;TrustServerCertificate=True;"
  }
}
```

Replace `YOUR_SERVER` with your SQL Server instance.

> **Security Note:** Never commit production database credentials or other sensitive configuration values to source control.

## Apply Database Migrations

The repository contains Entity Framework Core migrations for creating and updating the database schema.

Run:

```bash id="m6y3x2"
dotnet ef database update
```

If the Entity Framework CLI is not installed:

```bash id="d1s4f6"
dotnet tool install --global dotnet-ef
```

## Run the Application

Start the application with:

```bash id="0t4x7n"
dotnet run
```

Alternatively, open:

```text
DocumentUploader_MVCCore.sln
```

in Visual Studio and run the application from there.

## Learning Objectives

This project demonstrates practical implementation of:

* ASP.NET Core MVC
* .NET 8
* Entity Framework Core
* SQL Server
* Database migrations
* File upload handling
* Document management
* MVC architecture
* Razor Views
* Model binding
* Server-side validation
* Database persistence

## Security Considerations

File management applications require careful security controls when deployed in production.

Potential production safeguards include:

* File type validation
* File size restrictions
* Malware scanning
* Secure file naming
* Path traversal protection
* Authentication and authorization
* Role-based document access
* Secure file storage
* Access logging
* HTTPS enforcement
* Protection against unauthorized downloads
* Cloud-based object storage

Uploaded files should never be trusted solely based on their filename or extension.

## Future Improvements

Potential enhancements include:

* User authentication
* Role-based authorization
* Document categories
* Document search
* Document filtering
* File previews
* Document versioning
* Document download functionality
* Document sharing
* Access permissions
* Folder management
* Drag-and-drop uploads
* File size and type validation
* Cloud storage integration
* Document activity logs
* Audit trails
* Bulk document operations
* Pagination
* REST API integration

## Project Goals

The primary goal of this project is to demonstrate how **ASP.NET Core MVC can be used to build a practical document management application** while integrating database persistence through Entity Framework Core and SQL Server.

The architecture also provides a foundation that can be extended into a larger enterprise document management platform.

## Author

**Brian Ahuga**

Software Engineer specializing in scalable software systems, backend services, enterprise web applications, and full-stack development.

GitHub: [BrianAhuga](https://github.com/BrianAhuga)

## License

This project is intended for learning, experimentation, and portfolio demonstration.
