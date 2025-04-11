🚗 Prestige Motors - API
Welcome to the Prestige Motors API! This is the backend of a car rental and sales platform where users can browse vehicles, make bookings, and complete payments securely. Built with ASP.NET Core 8 and designed using a clean multi-layered architecture.

🧱 Project Architecture
This API follows a clean architecture, split into the following layers:

Domain Layer: Contains core business models and DTOs.

Logic Layer: Contains all business logic and services.

Infrastructure Layer: Handles database access and external integrations.

API Layer: Exposes RESTful endpoints to clients.

⚙️ Technologies Used
.NET 8 / ASP.NET Core Web API

Entity Framework Core

SQL Server

JWT Authentication

Google Authentication

AutoMapper

Dependency Injection

CORS Configuration

📁 Project Structure
bash
Copier
Modifier
PrestigeMotors/
│
├── PrestigeMotors.Domain/         # Models and DTOs
├── PrestigeMotors.Logic/          # Business logic and interfaces
├── PrestigeMotors.Infrastructure/ # Database, repositories
├── PrestigeMotors.API/            # Controllers, Program.cs, middleware
└── PrestigeMotors.Migration/      # Database migrations
🚀 Getting Started
Prerequisites
.NET SDK 8

SQL Server

Visual Studio / VS Code

Clone the Repository
bash
Copier
Modifier
git clone https://github.com/your-username/PrestigeMotors.git
cd PrestigeMotors
Configure the Database
Update your connection string in appsettings.json in the PrestigeMotors.API project:

json
Copier
Modifier
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=PrestigeMotorsDb;Trusted_Connection=True;"
}
Apply Migrations
bash
Copier
Modifier
cd PrestigeMotors.Migration
dotnet ef database update
Run the API
bash
Copier
Modifier
cd ../PrestigeMotors.API
dotnet run
Visit: https://localhost:5001/swagger to explore the API.

📦 Key Features
🔒 JWT and Google Authentication

📅 Car Booking System

📍 Car Location Mapping

🧾 QR Code Payment System (Planned)

🗃️ Clean DTO-Model Mapping via AutoMapper

🧪 API Endpoints
Use Swagger UI to interact with all endpoints. Examples include:

/api/auth/login

/api/auth/google-login

/api/cars

/api/bookings

/api/users

💡 Contribution
PRs are welcome! Please ensure code follows clean architecture principles and includes unit tests.

📃 License
This project is licensed under the MIT License.# PM
A car rental and sales web app built with React and ASP.NET Core.
