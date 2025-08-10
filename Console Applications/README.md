# C# Console Applications

Structured, scenario-based console samples aligned with theory in `../Intro`.

## Index
| # | Folder | Topic | Summary |
|---|--------|-------|---------|
| 01 | [01_BasicIO](./01_BasicIO/) | Basic IO & Variables | Read/write console, validation |
| 02 | [02_ControlFlow](./02_ControlFlow/) | Control Flow | if, switch, loops, break/continue |
| 03 | [03_Strings](./03_Strings/) | Strings | Common APIs & immutability |
| 04 | [04_Arrays](./04_Arrays/) | Arrays | 1D & 2D arrays, sorting |
| 05 | [05_Methods](./05_Methods/) | Methods | Signatures, overloading, Math, Random |
| 06 | [06_OOP](./06_OOP/) | OOP Basics | Classes, inheritance, polymorphism |
| 07 | [07_Exceptions](./07_Exceptions/) | Exceptions | try/catch/finally, custom exception |
| 08 | [08_InMemoryCRUD](./08_InMemoryCRUD/) | CRUD | In-memory repository pattern |

## How to Run (macOS / Linux / Windows with .NET SDK)
1. Navigate into a folder (e.g. `01_BasicIO`).
2. If you convert to a project later, use `dotnet new console` and move `Program.cs` in.
3. For single-file quick run (C# 9+ script style not used here), compile:

```
csc Program.cs && mono Program.exe
```

(Or create a proper SDK project for modern workflow.)

## Linking Theory
See Intro docs:
- [Intro](../Intro/INTRO.md)
- [Control Statements](../Intro/CONTROL-STATEMENTS.md)
- [Strings](../Intro/STRINGS.md)
- [Arrays](../Intro/ARRAYS.md)
- [Methods](../Intro/METHODS.md)
- [OOP](../Intro/OOP.md)