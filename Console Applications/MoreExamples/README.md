# Additional Combined Console Examples

This folder groups larger, integrated examples combining multiple concepts.

| Example | Description | Concepts Covered |
|---------|-------------|------------------|
| Calculator (`Calculator.cs`) | Basic arithmetic operations with input validation | Variables, Control Flow, Methods |
| StudentScores (`StudentScores.cs`) | Manage list of scores: add, average, highest, persistence to file | Lists, Loops, Methods, File IO, LINQ |

## How to Run (Quick)
Compile either file as a standalone entry point by wrapping its logic with a temporary `Main`, or create a small `Program.cs` that calls into the example (e.g., `StudentScoresApp.Run();`).

Example temporary runner:
```
using MoreExamples;
StudentScoresApp.Run();
```

Then compile:
```
csc -langversion:latest -out:StudentScores.exe StudentScores.cs Runner.cs
./StudentScores.exe
```

Each example includes extension ideas for practice.

### Extension Ideas
- Calculator: Add modulus, exponent, expression parsing.
- StudentScores: Export CSV, compute median & mode, integrate sorting options, add update score feature, switch persistence to JSON.
