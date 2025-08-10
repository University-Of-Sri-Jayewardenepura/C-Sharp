# LINQ Basics

Language Integrated Query: Consistent querying over in-memory objects, XML, EF contexts, etc.

## Namespaces
`using System.Linq;`

## Query Styles
Method Syntax (fluent) vs Query Expression (SQL-like).

```csharp
var scores = new[] { 78, 92, 66, 88 };
var high = scores.Where(s => s >= 80)
                 .OrderByDescending(s => s)
                 .Select(s => new { Score = s, Pass = s >= 70 });
```

Query Expression:
```csharp
var high2 = from s in scores
            where s >= 80
            orderby s descending
            select new { Score = s, Pass = s >= 70 };
```

## Key Operators
| Category | Examples |
|----------|----------|
| Filtering | Where |
| Projection | Select, SelectMany |
| Ordering | OrderBy, ThenBy, Reverse |
| Grouping | GroupBy |
| Joining | Join, GroupJoin |
| Quantifiers | Any, All, Contains |
| Aggregation | Count, Sum, Average, Min, Max, Aggregate |
| Element | First, FirstOrDefault, Single, ElementAt |
| Set | Distinct, Union, Intersect, Except |
| Generation | Range, Repeat, Empty |

## Deferred vs Immediate
Most operators are deferred (executed upon enumeration). Terminal operations: ToList(), ToArray(), Count(), First(), etc.

## Execution Pipeline
Source -> Where -> Select -> ToList ENUMERATES.

## Custom Projection Example
```csharp
var people = new List<Person>{ new("Ana", 22), new("Bill", 30) };
var summary = people.Select(p => new { p.Name, AgeGroup = p.Age < 25 ? "Junior" : "Adult" });
```

## Grouping Example
```csharp
var grouped = people.GroupBy(p => p.Age < 25 ? "Junior" : "Adult");
foreach (var g in grouped)
{
    Console.WriteLine($"{g.Key}: {g.Count()} persons");
}
```

## Pitfalls
- Multiple enumeration of `IEnumerable` (cache with ToList)
- Using First() when sequence may be empty
- OrderBy cost on large datasets

## When to Use
- Transform collections succinctly
- Filter / aggregate without manual loops
- Prepare data for UI or reports

## Next Steps
Explore LINQ to Objects vs LINQ to Entities (EF Core) and differences (deferred translation, supported method set).
