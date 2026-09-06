# 🚀 Featured Case Study: NexGenSales

> **Category**: Desktop ERP & Business Intelligence  
> **Target Framework**: .NET 10 (Windows Presentation Foundation - WPF)  
> **Source Repository**: [github.com/43UniProjects/nexgensales](https://github.com/43UniProjects/nexgensales)  
> **University Team**: [NexGenSales Team](https://github.com/orgs/University-Of-Sri-Jayewardenepura/teams/nexgensales) (University of Sri Jayewardenepura)

---

## 👥 Student Engineering Team

This project was engineered by an undergraduate junior developer team from the University of Sri Jayewardenepura:

| Contributor | GitHub Profile | Role / Highlights |
| :--- | :--- | :--- |
| **Malith Banuka Subasinghe** | [@banuka20431](https://github.com/banuka20431) | Core Architecture, MVVM & ViewModels, Documentation |
| **Minuraka Iroshan** | [@minurakairoshan](https://github.com/minurakairoshan) | Data Access Layer, SQLite Migrations, Database Repositories |
| **Janindu Malshan** | [@ImJanindu](https://github.com/ImJanindu) | Business Logic, Analytics Engine, Anomaly Detection |
| **Akila Harshana** | [@akilaharshana61](https://github.com/akilaharshana61) | UI / XAML Views, UserComponents, LiveCharts2 Integration |
| **Rashmika Shehan** | [@rashmikashehan0929](https://github.com/rashmikashehan0929) | Reporting Services, QuestPDF Generator, Excel Export |

---

## 📖 Executive Summary

**NexGenSales** is a standalone, local-first desktop application designed for small-to-medium enterprise sales tracking, expense analysis, and predictive business intelligence. It processes multi-batch Excel data files, normalizes operational metrics, computes statistical anomalies, and generates boardroom-ready executive PDF reports—all without requiring an external database server.

For students studying C#, NexGenSales serves as an exemplary showcase of **clean separation of concerns**, **high-performance local data access**, and **modern WPF application design**.

---

## 🏛️ Architectural Breakdown

```text
nexgensales/
├── App.xaml / App.xaml.cs    # Application bootstrap, DI container, global exception handling
├── nexgensales.csproj        # .NET 10 WPF configuration & NuGet dependencies
├── Assets/                   # Static icons and image resources
├── Core/                     # Shared utilities, interfaces, and base classes
├── Models/                   # Domain entities (SalesRecord, ExpensesRecord, DTOs)
│   └── Enums/                # Strongly-typed mapping enumerations
├── ViewModels/               # Presentation state, observable properties & commands (MVVM)
├── Views/                    # Pure XAML user interfaces and windows
├── UserComponents/           # Reusable controls (Cards, Navigation, KPI Tiles)
└── Services/                 # Business logic, analytics, and file processing
    ├── DatabaseMigrationService.cs  # SQLite version-controlled migrations
    ├── ExportService.cs             # QuestPDF & Excel generation
    └── Data/
        ├── Repository/       # Concrete SQLite repository implementations
        └── Mapper/           # High-speed data mappers
```

---

## 💡 Key Architectural Lessons for Students

### 1. The MVVM (Model-View-ViewModel) Pattern
Unlike beginner Windows Forms applications where UI buttons directly contain database queries (`btnSubmit_Click`), NexGenSales strictly implements **MVVM**:
- **Views** contain pure XAML declarations with zero business logic in the code-behind.
- **ViewModels** manage application state and expose commands to the View using data binding.
- **Models** represent pure data entities independent of any presentation layer.

### 2. High-Performance Data Access (Raw SQL vs ORM)
Rather than relying on heavy ORMs like Entity Framework Core, the team utilized **ADO.NET (`Microsoft.Data.Sqlite`) paired with `Dapper`**:
- **Why?** For desktop analytics with large time-series datasets, raw SQL combined with optimized row mappers delivers near-zero memory overhead and maximum throughput.
- **Repository Pattern**: All database interactions are encapsulated behind repositories (e.g., `SalesRepository`, `ExpensesRepository`), allowing the analytics service to remain completely database-agnostic.

### 3. Automated Database Migrations via SQLite `PRAGMA user_version`
A common pitfall in student projects is requiring users to manually run a SQL script to create tables before opening the app.
- NexGenSales solves this with `DatabaseMigrationService.cs`.
- On application launch, it inspects SQLite's internal `PRAGMA user_version`.
- If the schema version is outdated, it automatically executes incremental migration scripts, guaranteeing the database is always in a valid state.

### 4. Statistical Anomaly Detection & Business Intelligence
Instead of basic CRUD queries, the application implements real-world BI algorithms:
- **Anomaly Detection**: Flags suspicious expense spikes using a dynamic standard deviation threshold (`Average + 1.5 * StdDev`).
- **Discount Optimization**: Evaluates transaction velocity across discount brackets to calculate the true **Average Profit per Transaction**.
- **Item Velocity Analysis**: Dynamically categorizes inventory into fast-moving vs. dead stock.

### 5. Fluent Document Generation with QuestPDF
Rather than exporting basic `.txt` files or relying on legacy Crystal Reports, the project uses **QuestPDF**:
- Employs a declarative C# fluent API to layout headers, dynamic charts, line-item tables, and pagination.
- Produces crisp, vectorized executive PDF summaries.

### 6. Environment-Aware Storage Architecture
The project uses compiler directives (`#if DEBUG`) to switch runtime paths:
- **Debug Mode**: Database (`Database/app.db`) and logs (`Logs/console.log`) are generated directly inside the project root for rapid inspection during development.
- **Release Mode**: Database and log files are redirected to the safe, standard Windows AppData directory (`%LOCALAPPDATA%\NexGenSales\Logs`).

---

## 🛠️ How to Clone and Run the Project

Students are encouraged to clone the repository to test the application and examine its source code:

### Prerequisites
- [.NET 10 SDK](https://dotnet.microsoft.com/download) (or .NET 8/9 with WPF workload enabled).
- Windows OS (WPF applications require the Windows Desktop runtime).
- Visual Studio 2022 / JetBrains Rider / VS Code with C# Dev Kit.

### Quickstart
```bash
# 1. Clone the student repository
git clone https://github.com/43UniProjects/nexgensales.git

# 2. Navigate to the project directory
cd nexgensales

# 3. Restore dependencies and run
dotnet restore
dotnet build
dotnet run
```

---

## 🔗 Related Links
- **Source Code**: [43UniProjects/nexgensales](https://github.com/43UniProjects/nexgensales)
- **Organization Team**: [@University-Of-Sri-Jayewardenepura/teams/nexgensales](https://github.com/orgs/University-Of-Sri-Jayewardenepura/teams/nexgensales)
- **Course Syllabus & Hub**: [Back to C# Learning Hub](../../README.md)
