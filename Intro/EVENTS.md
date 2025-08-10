# Events & Delegates

## Delegates
Type-safe function pointers.
```csharp
public delegate void ProgressHandler(int percent);
```

## Events
Publisher exposes an event based on a delegate; subscribers attach handlers.

```csharp
public class Downloader
{
    public event ProgressHandler? ProgressChanged;

    public async Task RunAsync()
    {
        for (int i = 1; i <= 10; i++)
        {
            await Task.Delay(100);
            ProgressChanged?.Invoke(i * 10);
        }
    }
}
```

Subscriber:
```csharp
var d = new Downloader();
d.ProgressChanged += p => Console.WriteLine($"Progress: {p}%");
await d.RunAsync();
```

## EventHandler Pattern
Standard signature: `(object? sender, EventArgs e)` or generic `EventHandler<TEventArgs>`.

```csharp
public event EventHandler<UserEventArgs>? UserCreated;
```

## Custom Args
```csharp
public sealed class UserEventArgs : EventArgs
{
    public required string UserName { get; init; }
    public DateTime CreatedAt { get; init; } = DateTime.UtcNow;
}
```

## Unsubscribing
Important to avoid memory leaks (long-lived publishers).
`publisher.SomeEvent -= Handler;`

## Multicast
Events can have multiple subscribers; invocation list runs sequentially.

## Async Considerations
Wrap awaits carefully; fire-and-forget tasks may need try/catch logging.

## When to Use
- UI interaction (button clicks)
- Progress and status updates
- Domain notifications (e.g., OrderPlaced)

## Alternatives
- Observer pattern classes
- Reactive Extensions (IObservable/IObserver)
- Mediator libraries (e.g., MediatR) for larger systems
