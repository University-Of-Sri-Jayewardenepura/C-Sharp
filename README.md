# C# Visual Application Programming Learning Hub

A structured learning repository combining theory (Intro) and hands-on Console & Windows Forms examples.

## 📚 Theory (Intro)
Foundational markdown lessons (all inside `Intro/`).

- [Overview & Evolution](./Intro/README.md)
- [Visual Programming Concepts](./Intro/VISUAL-PROGRAMMING.md)
- [The .NET Framework / Platform](./Intro/DOTNET-FRAMEWORK.md)
- [Visual Studio IDE Essentials](./Intro/VISUAL-STUDIO-IDE.md)
- [Control Statements](./Intro/CONTROL-STATEMENTS.md)
- [Strings](./Intro/STRINGS.md)
- [Arrays](./Intro/ARRAYS.md)
- [Methods](./Intro/METHODS.md)
- [Object-Oriented Programming](./Intro/OOP.md)
- [Events & Delegates](./Intro/EVENTS.md)
- [Exceptions](./Intro/EXCEPTIONS.md)
- [Databases & CRUD Overview](./Intro/DATABASES.md)
- [GUI & Windows Forms Fundamentals](./Intro/GUI-WINDOWS-FORMS.md)
- [Menus, Reports & MDI](./Intro/MENUS-REPORTS-MDI.md)
- [LINQ Basics](./Intro/LINQ.md)

<details>
  <summary><strong>Intro to C# — By Example (Beginner)</strong></summary>

  - 00 — Hello World + Program Structure: [00_HelloWorld.cs](./Intro/CSharp-Basics/00_HelloWorld.cs)
  - 01 — Variables: [01_Variables.cs](./Intro/CSharp-Basics/01_Variables.cs)
  - 02 — Data Types: [02_DataTypes.cs](./Intro/CSharp-Basics/02_DataTypes.cs)
  - 03 — User Input: [03_UserInput.cs](./Intro/CSharp-Basics/03_UserInput.cs)
  - 04 — Operators & Math: [04_OperatorsMath.cs](./Intro/CSharp-Basics/04_OperatorsMath.cs)
  - 05 — Strings: [05_Strings.cs](./Intro/CSharp-Basics/05_Strings.cs)
  - 06 — Booleans: [06_Booleans.cs](./Intro/CSharp-Basics/06_Booleans.cs)
  - 07 — if..else: [07_IfElse.cs](./Intro/CSharp-Basics/07_IfElse.cs)
  - 08 — switch: [08_Switch.cs](./Intro/CSharp-Basics/08_Switch.cs)
  - 09 — while loop: [09_WhileLoop.cs](./Intro/CSharp-Basics/09_WhileLoop.cs)
  - 10 — for loop: [10_ForLoop.cs](./Intro/CSharp-Basics/10_ForLoop.cs)
  - 11 — break & continue: [11_BreakContinue.cs](./Intro/CSharp-Basics/11_BreakContinue.cs)
  - 12 — arrays: [12_Arrays.cs](./Intro/CSharp-Basics/12_Arrays.cs)

  See overview: [C# Basics — README](./Intro/CSharp-Basics/README.md)
</details>

## 💻 Console Application Samples
Scenario-based examples mapped to theory:

| # | Folder | Topic | Quick Description |
|---|--------|-------|-------------------|
| 01 | [Console Applications/01_BasicIO](./Console%20Applications/01_BasicIO/) | Basic IO & Variables | ReadLine, validation, interpolation |
| 02 | [Console Applications/02_ControlFlow](./Console%20Applications/02_ControlFlow/) | Control Flow | Menu, loops, switch |
| 03 | [Console Applications/03_Strings](./Console%20Applications/03_Strings/) | Strings | Analysis utilities |
| 04 | [Console Applications/04_Arrays](./Console%20Applications/04_Arrays/) | Arrays | Stats, sorting, 2D matrix |
| 05 | [Console Applications/05_Methods](./Console%20Applications/05_Methods/) | Methods | Overloads, Random, Math |
| 06 | [Console Applications/06_OOP](./Console%20Applications/06_OOP/) | OOP | Inheritance & polymorphism |
| 07 | [Console Applications/07_Exceptions](./Console%20Applications/07_Exceptions/) | Exceptions | Robust division tool |
| 08 | [Console Applications/08_InMemoryCRUD](./Console%20Applications/08_InMemoryCRUD/) | CRUD | List-based student manager |

### � Combined / Larger Console Examples
| Example | Path | Concepts |
|---------|------|----------|
| Calculator | [MoreExamples/Calculator.cs](./Console%20Applications/MoreExamples/Calculator.cs) | IO, Methods, Control Flow |
| StudentScores | [MoreExamples/StudentScores.cs](./Console%20Applications/MoreExamples/StudentScores.cs) | Collections, LINQ, File IO, CRUD |

## 🖼 Windows Forms (Coming Soon)
Planned examples to be added under `Form Applications/`:
- Basic Form + Events (Button / TextBox validation)
- Calculator GUI (mirrors console version)
- CRUD with DataGridView (in-memory then DB)
- MDI Parent with Menus
- Crystal Report placeholder / conceptual notes

## 🌟 Student Samples
Curated real-world student projects and architecture showcases: see [`Samples/`](./Samples/).

## 🗂 Suggested Progress Path
1. Read Intro overview & syntax basics.
2. Run BasicIO and experiment with inputs.
3. Study control flow & expand calculator.
4. Dive into Strings and Arrays examples.
5. Learn Methods then refactor earlier code.
6. Explore OOP; model simple domain.
7. Add error handling (Exceptions sample).
8. Build CRUD; prepare for persistence / DB.
9. Transition to GUI (Forms) once fundamentals are solid.
10. Study the [Student Project Showcase](./Samples/README.md) to see how large-scale C# applications are architected.

## 🧪 How to Run Samples
For quick compile (no .csproj yet) ensure you have .NET SDK & Mono for execution without project files, or convert each folder into a project:

```
# Example (inside a sample folder)
dotnet new console -n SampleTemp
mv Program.cs SampleTemp/Program.cs
cd SampleTemp
dotnet run
```

Or using csc + mono on macOS:
```
csc Program.cs && mono Program.exe
```

## 🤝 Contributing
- Keep theory in `Intro/`
- Keep console examples in `Console Applications/`
- Keep forms examples in `Form Applications/`
- Submit full-stack / architecture showcase applications to `Samples/` (see [Submission Guidelines](./Samples/README.md#submission-guidelines-how-to-get-your-project-featured))
- Each new example: its own folder + README + `Program.cs`

## ✅ Roadmap
- [x] Exceptions theory page
- [x] Database basics markdown
- [x] GUI / WinForms basics markdown
- [x] Events & Delegates markdown
- [x] Menus & MDI markdown
- [x] LINQ basics markdown
- [x] Combined examples folder
- [x] Student project showcase & architecture samples catalog
- [ ] Persist CRUD to file/JSON sample
- [ ] Database connectivity sample (ADO.NET + SQLite)
- [ ] WinForms basic form sample
- [ ] WinForms CRUD with DataGridView
- [ ] MDI + Menus + simple report export
- [ ] LINQ + EF Core sample (future)

Happy Learning!


