# .NET Framework & Platform Overview

## What is .NET?
A free, open-source (core/modern), cross-platform developer platform for building web, desktop, mobile, cloud, gaming, IoT apps.

## High-Level Architecture
1. Source Code (C#, F#, VB)
2. Compilation → CIL (Common Intermediate Language) + Metadata
3. CLR (Common Language Runtime) JIT compiles CIL to native Machine Code at runtime
4. Framework Class Library (FCL) / BCL supplies base types & APIs

## Major Components
| Component | Role |
|-----------|------|
| CIL | Platform‑agnostic IL produced by compiler |
| CLR | Execution engine: JIT, GC, security, exceptions |
| BCL/FCL | Base types (System.*), IO, collections, LINQ, networking |
| Assemblies | Deployment units (.dll / .exe) with metadata |

## Benefits
- Multi-language (C#, F#, VB) interoperability
- Managed memory (Garbage Collection)
- Type safety & security
- Cross-platform (with .NET 6/7/8+)
- Large ecosystem & tooling (Visual Studio, VS Code, JetBrains Rider)

## Common Application Types
| Type | Tech |
|------|-----|
| Console | C# + SDK templates |
| Desktop GUI | WinForms, WPF, MAUI |
| Web | ASP.NET Core (MVC, Minimal APIs, Blazor) |
| Mobile | .NET MAUI (Android, iOS) |
| Cloud / Serverless | Azure Functions, Containers |
| Data / ML | EF Core, ML.NET |

## Versioning Note
Classic ".NET Framework" (Windows only, 4.x) vs modern ".NET" (Core lineage unified). Prefer latest LTS for new work.
