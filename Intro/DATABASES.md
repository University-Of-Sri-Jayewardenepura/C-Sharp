# Databases & CRUD Overview

## What is a Database?
Structured (or semi/unstructured) data store accessed through a DBMS.

## Types
- Relational (SQL Server, MySQL, PostgreSQL)
- NoSQL (Document, Key-Value, Column, Graph)
- Cloud Managed (Azure SQL, AWS RDS)
- Distributed / Sharded

## Core Terminology
| Term | Meaning |
|------|---------|
| Table | Structured set of rows |
| Column | Named attribute / field |
| Row | Record instance |
| Primary Key | Unique identifier per row |
| Foreign Key | Referential link to PK in another table |
| Index | Lookup structure for fast search |

## Keys Overview
Primary, Foreign, Unique, Candidate, Composite, Super, Alternate.

## SQL Command Groups
| Group | Purpose | Examples |
|-------|---------|----------|
| DDL | Define schema | CREATE, ALTER, DROP |
| DML | Manipulate data | INSERT, SELECT, UPDATE, DELETE |
| DCL | Permissions | GRANT, REVOKE |
| TCL | Transactions | COMMIT, ROLLBACK |

## CRUD Mapping
| Operation | SQL | C# (Pseudo) |
|-----------|-----|-------------|
| Create | INSERT | context.Add(entity) |
| Read | SELECT | context.Entities.Where(...) |
| Update | UPDATE | modify entity then Save |
| Delete | DELETE | context.Remove(entity) |

## ADO.NET Essentials
Namespace: `System.Data.SqlClient` (legacy) / `Microsoft.Data.SqlClient` (newer).

Typical Pattern:
```csharp
using var conn = new SqlConnection(connectionString);
await conn.OpenAsync();
using var cmd = new SqlCommand("SELECT Id, Name FROM Students", conn);
using var reader = await cmd.ExecuteReaderAsync();
while (await reader.ReadAsync())
{
    int id = reader.GetInt32(0);
    string name = reader.GetString(1);
}
```

## Sample Connection String
```
Server=localhost;Database=School;Trusted_Connection=True;TrustServerCertificate=True;
```

## Learning Path
1. Understand CRUD conceptually (see in-memory sample)
2. Translate operations to SQL
3. Use ADO.NET / ORM (e.g., EF Core) for real persistence

## Next Steps
Add EF Core sample & WinForms grid binding (future roadmap).
