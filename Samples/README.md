# 🌟 Student Project Showcase & Reference Samples

Welcome to the **University of Sri Jayewardenepura C# Showcase Hub**! 

While the [`Intro/`](../Intro/) and [`Console Applications/`](../Console%20Applications/) directories teach foundational syntax and localized programming concepts, real-world software engineering requires mastering **multi-layered architecture, data persistence, design patterns, and user experience**.

This directory serves as a curated catalog of outstanding, production-grade applications built by our undergraduate software engineering and computer science students. It provides current students with reference architectures to inspect, run, and learn from during their coursework.

---

## 🏆 Featured Sample Projects

| Project | Category | Key Architectural Concepts | Tech Stack | Team & Batch | Repository |
| :--- | :--- | :--- | :--- | :--- | :--- |
| **[NexGenSales](./NexGenSales/README.md)** | Desktop Business Intelligence & ERP | MVVM, Repository Pattern, SQLite Migrations, Anomaly Detection, Executive PDF Reporting | .NET 10 WPF, ADO.NET, Dapper, LiveCharts2, QuestPDF, ClosedXML | **NexGenSales Team**<br>(Batch 2026) | [43UniProjects/nexgensales](https://github.com/43UniProjects/nexgensales) |

---

## 📐 Technical Excellence Criteria

Projects featured in this showcase are selected based on rigorous engineering benchmarks. When designing your university course project, use these criteria as your guiding North Star:

### 1. Architectural Cleanliness & Separation of Concerns
- **Design Pattern Adherence**: Clear separation between UI and business logic (e.g., **MVVM** for WPF/MAUI, **3-Tier** or **Clean Architecture** for enterprise apps).
- **Decoupled Data Access**: Use of the **Repository Pattern** or Service Layer to prevent UI views from executing direct database queries.
- **Dependency Inversion**: Code against interfaces and abstractions rather than hardcoded concrete implementations.

### 2. Robust Data Persistence & Schema Migrations
- **Safe Initialization**: Zero reliance on manual database setup; applications must auto-provision schemas on startup (e.g., using `PRAGMA user_version` migrations or EF Core migrations).
- **Data Integrity**: Enforced foreign keys, transactions for multi-step mutations, and parameterization to protect against SQL injection.
- **Resource Management**: Strict disposal of connection objects, file streams, and memory allocations via `using` statements.

### 3. Production-Ready Error Handling & Logging
- **Non-Crashing UX**: Global exception handling prevents silent termination and presents friendly, informative alerts to users.
- **Persistent Diagnostics**: File-based logging (with distinction between `Debug` and `Release` environments) to capture runtime errors and stack traces.

### 4. Git & Code Hygiene
- **Commit Quality**: Clean commit histories following Conventional Commits (e.g., `feat:`, `fix:`, `docs:`) and feature-branch workflows.
- **Repository Cleanliness**: Strict `.gitignore` configurations ensuring no build artifacts (`bin/`, `obj/`, `.vs/`), credentials, or temporary SQLite files are committed.

---

## 🚀 How to Explore a Featured Project

Each featured project has its own dedicated breakdown directory containing:
1. **System Architecture Overview**: How models, view models, and services interact.
2. **Key Code Lessons**: Specific files and design implementations worth studying.
3. **Setup & Execution Instructions**: Prerequisites, SDKs, and steps to run the application locally.
4. **Contributor Credits**: Recognizing the student engineers who authored the project.

👉 Start by exploring our first featured desktop application:  
**[NexGenSales Case Study & Architectural Guide](./NexGenSales/README.md)**

---

## 🤝 Submission Guidelines: How to Get Your Project Featured

Are you a student team at the University of Sri Jayewardenepura building an exemplary C# project? You can nominate your project for inclusion in the official university showcase!

### Eligibility Checklist
- [ ] Built using modern C# / .NET (.NET 8, 9, or 10).
- [ ] Clean repository: No `bin/`, `obj/`, `.suo`, `.user`, or sensitive API keys committed.
- [ ] Includes a comprehensive `README.md` with features, setup instructions, and architecture diagrams.
- [ ] Licensed under an open-source license (MIT recommended) for university educational reference.

### Submission Process
1. Ensure your project repository is hosted on GitHub and organized cleanly.
2. Open an Issue or Pull Request in this repository titled `[Showcase Nomination] ProjectName`.
3. Provide a brief summary of the problem solved, architectural patterns used, and team member details.
4. Once reviewed by the course maintainers, your project will be added to the showcase and linked across the university organization!
