# 🌾 Agriculture Presentation

A modern, scalable agricultural management system built with professional N-Layered architecture using .NET technologies. This comprehensive platform enables efficient farm operations management, data analytics, and decision-making for agricultural enterprises.

## 📋 Table of Contents

- [Project Overview](#project-overview)
- [Key Features](#key-features)
- [Technology Stack](#technology-stack)
- [Project Architecture](#project-architecture)
- [Installation](#installation)
- [Usage](#usage)
- [API Endpoints](#api-endpoints)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## 🎯 Project Overview

Agriculture Presentation is a comprehensive web application designed to streamline agricultural operations, data management, and analytics. Built with modern .NET technologies and following industry best practices, it provides farm managers and agricultural businesses with powerful tools to optimize their operations.

### Key Objectives

- Digitalize agricultural management processes
- Enable data-driven decision making for farm operations
- Streamline resource allocation and monitoring
- Improve operational efficiency and productivity
- Provide comprehensive reporting and analytics

## ✨ Key Features

- ✅ **N-Layered Architecture**: Entity, Business, and Data Access layers for clean separation of concerns
- ✅ **Database Operations**: Robust CRUD operations and complex data queries
- ✅ **Business Logic Management**: Comprehensive validation and processing rules
- ✅ **Extensible Design**: Easy to extend and maintain codebase
- ✅ **Data Analytics**: Advanced reporting and insights
- ✅ **Role-Based Access Control**: Secure user authentication and authorization
- ✅ **Responsive Interface**: Mobile-friendly user experience

## 🛠️ Technology Stack

| Technology | Version | Purpose |
|-----------|---------|---------|
| **.NET** | 8.0+ | Core Framework |
| **C#** | Modern | Primary Language |
| **SQL Server** | 2019+ | Database |
| **Visual Studio** | 2022+ | IDE |
| **Entity Framework** | Core | ORM |
| **Bootstrap** | 5.0+ | UI Framework |

## 🏗️ Project Architecture

The project follows an **N-Layered Architecture** pattern, ensuring clean separation of concerns and maintainability:

```
AgriculturePresentation/
├── AgriculturePresentation/           # Presentation Layer
│   ├── Controllers/
│   ├── Views/
│   ├── wwwroot/
│   │   ├── css/
│   │   ├── js/
│   │   └── images/
│   └── AgriculturePresentation.csproj
│
├── EntityLayer/                        # Entity Models Layer
│   ├── Models/
│   ├── Entities/
│   └── EntityLayer.csproj
│
├── BussinessLayer/                     # Business Logic Layer
│   ├── Services/
│   ├── Managers/
│   ├── Validators/
│   └── BussinessLayer.csproj
│
├── DataAccessLayer/                    # Data Access Layer
│   ├── Context/
│   ├── Repositories/
│   ├── Migrations/
│   └── DataAccessLayer.csproj
│
└── AgriculturePresentation.sln         # Solution File
```

### Layer Descriptions

#### 🎨 **Presentation Layer**
- User interface and interaction handling
- MVC controllers and views
- Request routing and response formatting
- Session and state management
- Bootstrap-based responsive design

#### 🏢 **Business Layer**
- Core business logic implementation
- Data validation and processing rules
- Service orchestration
- Business rule enforcement
- Data transformation and calculations

#### 💾 **Data Access Layer**
- Database operations and CRUD functionality
- Entity Framework DbContext configuration
- Repository pattern implementation
- Database migrations management
- Query optimization and data retrieval

#### 📦 **Entity Layer**
- Data model definitions
- Entity class structures
- Relationships and constraints
- Data annotations and validations
- Shared models across layers

## 🚀 Installation

### Prerequisites

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) or higher
- [Visual Studio 2022](https://visualstudio.microsoft.com/downloads/) or Visual Studio Code
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) (SQL Server Express is sufficient)
- [Git](https://git-scm.com/)

### Step-by-Step Installation

1. **Clone the Repository**
```bash
git clone https://github.com/keskinyasin/AgriculturePresentation.git
cd AgriculturePresentation
```

2. **Restore NuGet Packages**
```bash
dotnet restore
```

3. **Open the Project**
```bash
# Using Visual Studio
start AgriculturePresentation.sln

# Or using CLI
dotnet build
```

4. **Configure Database Connection**
- Update the connection string in `appsettings.json`
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER;Database=AgricultureDB;Trusted_Connection=true;"
}
```

5. **Apply Database Migrations**
```bash
dotnet ef database update --project DataAccessLayer
```

6. **Run the Application**
```bash
cd AgriculturePresentation
dotnet run
```

The application will be available at `https://localhost:5001`

## 💻 Usage

### Building the Project

**Build Solution:**
```bash
dotnet build
```

**Build Release Configuration:**
```bash
dotnet build --configuration Release
```

### Running the Application

**Start Development Server:**
```bash
dotnet run
```

**Run with Specific Port:**
```bash
dotnet run --urls "https://localhost:7000"
```

### Running Tests

```bash
dotnet test
```

### Database Commands

**Create Migration:**
```bash
dotnet ef migrations add MigrationName --project DataAccessLayer
```

**Update Database:**
```bash
dotnet ef database update --project DataAccessLayer
```

**Remove Last Migration:**
```bash
dotnet ef migrations remove --project DataAccessLayer
```

## 🔄 Development Workflow

1. **Create Feature Branch**
```bash
git checkout -b feature/new-feature-name
```

2. **Make Changes and Commit**
```bash
git add .
git commit -m "Add new feature: description"
```

3. **Push to Remote**
```bash
git push origin feature/new-feature-name
```

4. **Create Pull Request**
- Go to GitHub and create a PR with clear description

5. **Code Review and Merge**
- Address feedback and merge to main branch

## 📚 API Endpoints

Core API endpoints documentation:

### Agricultural Data
```
GET  /api/crops           - List all crops
POST /api/crops           - Create new crop record
GET  /api/crops/{id}      - Get crop details
PUT  /api/crops/{id}      - Update crop information
DELETE /api/crops/{id}    - Delete crop record
```

### Farm Management
```
GET  /api/farms           - List all farms
POST /api/farms           - Create new farm
GET  /api/farms/{id}      - Get farm details
PUT  /api/farms/{id}      - Update farm information
```

### Reports
```
GET  /api/reports/summary     - Get farm summary report
GET  /api/reports/yield       - Get yield analysis report
GET  /api/reports/weather     - Get weather impact report
```

## 🐛 Bug Reporting

Found a bug? Please open an issue in the [Issues](https://github.com/keskinyasin/AgriculturePresentation/issues) section with:

- Clear description of the bug
- Steps to reproduce
- Expected vs actual behavior
- Screenshots (if applicable)
- Your environment details

## 🤝 Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

### Contribution Guidelines

- Follow C# coding conventions
- Write clean, readable code
- Add comments for complex logic
- Update documentation as needed
- Include tests for new features
- Ensure all tests pass before submitting PR

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 👤 Author

**Keşkin Yasin**
- GitHub: [@keskinyasin](https://github.com/keskinyasin)
- Repository: [AgriculturePresentation](https://github.com/keskinyasin/AgriculturePresentation)

## 📞 Support & Contact

For questions, support, or feedback:
- Open an issue in the [Issues](https://github.com/keskinyasin/AgriculturePresentation/issues) section
- Contact via GitHub profile
- Email inquiries welcome

## 🌟 Project Highlights

- ✅ Professional N-Layered architecture
- ✅ Enterprise-grade database design
- ✅ Modern C# and .NET 8.0 implementation
- ✅ Clean code principles
- ✅ Extensible and maintainable structure
- ✅ Comprehensive documentation

---

⭐ If you find this project helpful, please consider giving it a star!

**Version**: 1.0  
**Last Updated**: 2024  
**Status**: Active Development
