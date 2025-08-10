Here are the topics and subtopics of the module, presented as text in a mind map format:

*   **Module Introduction**
    *   **Learning Outcomes**
        *   Understanding and practical application of pure **Visual Programming Language (VPL)** concepts.
        *   Understanding of the **.NET framework architecture** and executing a **C# console program** using Visual Studio IDE.
        *   Practicing the development of a complete **GUI-based application** using C# basics, and **Event-driven Programming**.
        *   Developing test programs for **debugging** and revising existing code.

*   **Introduction to Pure Visual Programming**
    *   **What is Visual Programming?**
        *   Definition: Any programming language allowing users to specify a program in a Two- (or more)-dimensional way by manipulating program elements graphically rather than textually.
        *   Main Goals of Using VPL: Make programming more accessible to novices, support programmers at three different programming levels, component-based programming, cater for rapid application development (RAD).
    *   **Basics in a Language**
        *   **Syntax**: Rules defining combinations of symbols, wordings, and characters correctly structured for a language.
        *   **Semantics**: Study of literal meaning at levels of words, phrases, sentences, or larger units of discourse.
        *   **Pragmatics**: Study of how context contributes to meaning.
    *   **Applications/Tools of Visual Programming** (under various areas)
        *   **Educational**: Scratch, Ardublock, AgentCubes, Bubble, AgentSheets.
        *   **Multimedia**: OpenMusic, Blender, Chameleon, AudioMulch, Dynamo.
        *   **Video Gaming**: Blender Game Engine, Clickteam Fusion 2.5, CryEngine (with FlowGraph), GameSalad, SnowDrop.
        *   **Simulation**: Flowcode, DRAKON, Analytica, Orange, EICASLAB.
        *   **Data Warehousing/Business Intelligence**: Ab Initio, IBM Cognos Business Intelligence, Automator, Alteryx Designer.

*   **From the Previous Lesson (Component-Based Architecture)**
    *   **Component-Based vs. Object-Oriented Programming**
        *   Component-Based: Development focused on modules/components, interchangeable code modules, don't require familiarity with inner workings, involved with Rapid Application Development (RAD), ideal for large-scale systems.
        *   Object-Oriented: Development focused on objects, developments depend on parent objects (inheritance), need to know inherited methods/data types/behaviors, considerable time to define objects from ground up, well-suited for complex hierarchies and relationships.

*   **The .NET Framework**
    *   **What is .NET?**
        *   Definition: Free, open-source, cross-platform framework for building modern apps and powerful cloud services.
        *   A developer platform for building and running applications on Windows.
        *   Facilitates tools, libraries, and programming languages for different application types.
        *   Cross-platform independence: .NET codes can execute on Windows, Linux, macOS, Android.
    *   **.NET Framework Architecture**
        *   **Major Components**: Common Intermediate Language (CIL), Common Language Runtime (CLR), Machine Code.
    *   **Benefits of using .NET Framework**: Works with wide variety of programming languages, version compatibility, portability, speed, memory management, reliability, easy deployment, large class library.

*   **Visual Studio IDE**
    *   **What is an IDE?**
    *   **Key Features**: Single IDE for all .NET applications, integrated compilation and debugging, collaborative features (Git-first workflow, real-time collaboration, integrated code reviews), supports applications based on different languages, customizable environment.

*   **Evolution of C#**
    *   **Specific Features in C#**: Multi-paradigm Programming language, garbage collection, nullable types, exception handling, lambda expressions, Language Integrated Query (LINQ).

*   **Introduction to C# (Programming)**
    *   **What is C#?**
        *   Modern, object-oriented programming language developed by Microsoft, part of .NET framework, used for Windows apps, web apps, games.
        *   Why learn C#: Widely used in enterprise, strong integration with Windows and .NET, excellent support/documentation, versatile (desktop, web, mobile, game development).
    *   **Basics in C#**
        *   **Terms used in C#**: Namespace (containers for related classes), Assembly (compiler-generated file after successful compilation, DLL or exe).
        *   **C# Coding Structure** (Example).
    *   **Basic Syntax & Structure**
        *   **Identifiers**: Names for classes, interfaces, structs, delegates, enums, members, variables, namespaces; series of Unicode characters; start with letter or underscore; no spaces/symbols; case sensitive; not a C# keyword (unless prefixed with @).
        *   **Naming Conventions (Best Practices)**: Pascal casing for classes, structs, methods, properties, constant fields; interfaces prefixed with 'I' (Pascal case); camel case for method arguments, private fields (prefixed with underscore), local variables; meaningful names.
        *   **Keywords**: Reserved words predefined to the C# compiler, special meaning, cannot be used as identifiers.
    *   **Data Types and Variables**
        *   **Value Type: Predefined Data Type (Common)**: `int`, `float`, `double`, `char`, `string`, `bool`.
        *   **Value Type: User Defined Data Type**: Structures (primitive type to create single variable related data of various types), Enumerations (collection of constants).
        *   **What is a Variable? Literal?**: Variable is a name for storage area, type determines size/layout; Literal is a fixed value for a predefined variable, cannot be modified.
        *   **Declaring and Initializing Variables**: Syntax `data_type variable_name = value;`.
        *   **Type Conversion**: Implicit (automatic, e.g., `char` to `int`), Explicit (manual casting, e.g., `double` to `int`).
        *   **Built-in Methods for Type Conversion**: ToBoolean, ToByte, ToChar, ToDecimal, ToDouble, ToInt32, ToInt64, ToUInt16, ToString, ToType.
        *   **Variable Scope**: Lifetime in a program; Class level, Method level, Block level.
    *   **Input and Output (Console)**
        *   C# Console Input (`Console.ReadLine()`).
        *   C# Console Output (`Console.WriteLine()`, `Console.Write()`).
        *   **Escape Characters in C#**: `\'`, `\"`, `\\`, `\n`, `\r`, `\t`, `\0`, `\b`, `@` (Verbatim String).
    *   **Operators in C#**
        *   Groups: Arithmetic, Assignment, Comparison, Logical, Bitwise.
        *   Operator Precedence.
    *   **Some Key Points**
        *   **Comments**: Used to understand code, ignored by compiler; Single line (`//`), Multi line (`/* ... */`), XML comments (`///`).
        *   **Multiple Main Methods**: One class usually has main method as entry point; Prevention via `csc filename.cs /main:classname`.
        *   **Compile Time Errors**: Occur when syntax rules are violated, detected by compiler.

*   **Control Statements**
    *   **Selection/Branching Statements**: `if-else` statement, `switch-case` statement.
    *   **Iteration/Repetition Statements**: `for` loop, `while` loop, `do while` loop, `foreach` loop.

*   **Strings**
    *   Reference data type, stores sequence of character objects/text.
    *   Object of `System.String` class, performs operations using predefined methods.
    *   `string` and `String` are same.
    *   **Declaration & Initialization**: Using `string` keyword or creating `System.String` object.
    *   **String Methods**: `Clone()`, `Compare()`, `Concat()`, `ToString()`, `Trim()`, `ToUpper()`, `IndexOf()`, `Substring()`, `Join()`.

*   **Arrays**
    *   Fixed-size collection of elements, stores multiple values in single variable, all elements same data type.
    *   **Defining and Initializing Arrays**: `string[] country = new string;` or `string[] country = {"Sri Lanka", ...};`.
    *   Accessing Array Elements.
    *   One Dimensional vs. Two Dimensional.
    *   **Array Methods**: `Clone()`, `Copy()`, `Empty<T>()`, `Finalize()`, `Sort()`, `Reverse()`, `IndexOf()`.
    *   **Array Class vs. ArrayList**: `Array` is base class for operations; `ArrayList` is a resizable collection for any data type.

*   **Methods (Functions)**
    *   Block of code with signature, executes statements.
    *   Main parts: Access modifier, Return type, Parameters, Function name.
    *   **Mathematical Functions**: `Math.Abs()`, `Math.floor()`, `Math.ceiling()`, `Math.DivRem()`, `Math.Min()`, `Math.Max()`, `Math.Pow()`, `Math.Round()`, `Math.Sqrt()`.
    *   **Random Numbers**: Used for generating random numbers (`Random rand = new Random(); rand.Next()`).
    *   **User Defined Functions**: 4 types (no arguments/no return, no argument/return, arguments/no return, arguments/return).

*   **Object Orientation (OO)**
    *   **What is a class?**: User-defined template or blueprint of an object.
    *   **What is an object?**: Logical unit representing real-world entities.
    *   **Core Concepts of OO**
        *   **Encapsulation**: Binding data and methods under a single unit, data protection, accessed via accessors/mutators.
        *   **Inheritance**: One class acquiring properties from another (parent-child relationship), improves reusability.
        *   **Polymorphism**: "Many forms", occurs with inherited classes, achieved via method overloading/overriding, high reusability, ease of debugging.
        *   **Abstraction**: Presenting essential details only, uses abstract classes and modifiers (`abstract` keyword).

*   **Graphical User Interface (GUI)**
    *   **What is GUI?**: User interface allowing interaction with devices through graphical icons, built using GUI controls (components/widgets).
    *   **Why use GUIs?**: Enhance efficiency and ease of use (usability).
    *   Pros and Cons.

*   **Windows Forms**
    *   Used in C# for creating/designing GUIs.
    *   `System.Windows.Forms` namespace includes controls.
    *   The `Form` class: Top-level window, contains sub-controls, inherits from `Form` class, interacts via properties and delegates.
    *   **Creating a Windows Form**: Steps in Visual Studio IDE (File > New > Project, select Windows Form App (.NET Framework)).
    *   **Key IDE Components**: Windows Forms Designer (rapid development, add controls), Solution Explorer (displays project items), Properties (display properties for selected objects), Toolbox (drag and drop controls).
    *   **GUI Controls**: Buttons, Labels, Textbox, Checkbox, Radio Button, Group Box, Numeric Up/Down, Progress bar, DateTimePicker, Listbox, Combo box, DomainUpDown, ListView.

*   **Creative GUI Designing with Event Handling**
    *   **Windows Form Properties**.
    *   **What is Event Handling?**
        *   Mechanism where application responds to events/actions (user interactions like clicks, key presses, mouse movements, or system-generated events).
        *   All GUI controls have associated events.
        *   **Why use Event Handling**: User interaction, application logic, state management, validation/error handling, customization/extensibility, build event-driven programming model.
    *   **Common Events in Windows Forms**: Click, MouseEnter, MouseLeave, KeyPress, Load.
    *   **Examples**: Button Click (`MessageBox.Show()`), Mouse Hover (`label1.Text`), Form Load.
    *   **Retrieving Integer Values from Textbox**: String to Integer/Float/Double conversion using `int.Parse()`, `float.Parse()`, `double.Parse()` or `Convert.ToInt32()` etc..

*   **Introduction to Databases**
    *   **What is a Database?**: Organized collection of structured/unstructured data, accessed electronically via Database Management System (DBMS).
    *   **Types of Databases**: Relational, Distributed, Cloud, NoSQL, Object-oriented, Graph.
    *   **Terminology**: Database, Tables, Columns, Rows.
    *   **Data Types Used in Databases**.
    *   **Keys in Databases**: Primary key, Foreign key, Unique key, Candidate key, Super key, Composite key, Alternative key.
    *   **SQL Commands**
        *   **Data Definition Language (DDL)**: CREATE, ALTER, DROP.
        *   **Data Manipulation Language (DML)**: INSERT, SELECT, UPDATE, DELETE.
    *   **MS SQL Server**: Proprietary DBMS, C#/C/C++ languages, Microsoft Corporation developer.
    *   **MySQL Server**: Open-source relational DBMS, Java/PHP/Python/C++/Ruby/Visual Basic/R languages, Oracle Corporation developer.
    *   **Comparison in Servers**: MSSQL vs. MySQL.
    *   **Creating a Sample DB with SSMS**: Steps (Connect to server, New Database, Name DB, Add Tables, Add Name/Columns).

*   **Database Connection and CRUD Operations**
    *   **Database Connection**
        *   **Parameters**: Name, Username, Password, Host, Port.
        *   **Namespace for DB Connectivity**: `System.Data.SqlClient`.
        *   **Key Classes**: `SqlConnection`, `SqlDataAdapter`, `SqlException`, `SqlTransaction`.
        *   **Steps for Connecting Database into Windows Form**: Copying server name, selecting DB, getting connection string.
    *   **DB Connectivity with CRUD Operations**
        *   **What is CRUD?**: Four basic operations a software application performs.
            *   **CREATE**: Creating/inserting new records.
            *   **READ**: Retrieving existing records.
            *   **UPDATE**: Updating/modifying records.
            *   **DELETE**: Deleting records.
        *   **Examples of CRUD operations** (Coding View).

*   **Menus, Crystal Reports Generation and MDI Forms**
    *   **What are Menus?**: Used for navigation in Windows forms, `MenuStrip` control provides functionality.
    *   **Main Types of Menus**: Main Menu vs. Context Menu.
    *   **What is Crystal Report?**: Embedded Report Design tool, free, functional, saves time, easy/powerful for report creation/integration/delivery.
    *   **Key Benefits of Using Crystal Reports**.
    *   **Steps of Creating Crystal Reports**: Adding Namespaces (`CrystalDecisions.CrystalReports.Engine`, `CrystalDecisions.Shared`, `CrystalDecisions.ReportSource`).
    *   **Adding Crystal Reports into an Application** (Visual steps).
    *   **Multiple Document Interface (MDI)**
        *   Used to display multiple child windows inside a program.
        *   Contrasted to Single Document Interface (SDI).
        *   MDI application consists of a window menu item for switching between windows/documents.
        *   Examples: Visual Studio IDE (MDI) vs. Notepad (SDI).
    *   **MDI Forms with Menus**.
    *   **Connecting Form from the Main Form**: Using `ToolStripMenuItem` to open new forms as MDI children (`f1.MdiParent = this;`).