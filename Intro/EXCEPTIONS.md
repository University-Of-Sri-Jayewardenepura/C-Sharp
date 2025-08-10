# Exceptions & Error Handling in C#

## What is an Exception?
An object representing an error / unexpected condition during program execution. Thrown (raised) and can be caught to recover or fail gracefully.

## Common Built-in Exceptions
| Type | Scenario |
|------|----------|
| ArgumentException | Bad argument value |
| ArgumentNullException | Null passed to non-null parameter |
| InvalidOperationException | Object not in valid state |
| DivideByZeroException | Division by zero (integral) |
| FormatException | Parsing invalid text |
| IndexOutOfRangeException | Index outside bounds |
| NullReferenceException | Dereferencing null reference |

## Try / Catch / Finally Pattern
```csharp
try
{
    var x = int.Parse(input);
    Console.WriteLine(10 / x);
}
catch (FormatException ex)
{
    Console.WriteLine($"Invalid number: {ex.Message}");
}
catch (DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero.");
}
finally
{
    Console.WriteLine("Always runs (cleanup). ");
}
```

## Throwing Exceptions
```csharp
if (amount < 0) throw new ArgumentOutOfRangeException(nameof(amount));
```

## Custom Exception
```csharp
public class NegativeDivisorException : Exception
{
    public NegativeDivisorException(int v) : base($"Divisor cannot be negative: {v}") {}
}
```

## Best Practices
- Fail fast for invalid arguments (throw early)
- Use specific exception types
- Avoid swallowing (empty catch) blocks
- Reserve exceptions for exceptional control flow (not normal branching)
- Add context message data when rethrowing

## Mapping to Sample
See `Console Applications/07_Exceptions` for applied patterns.
