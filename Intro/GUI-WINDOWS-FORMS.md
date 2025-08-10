# GUI & Windows Forms Fundamentals

## What is a GUI?
Graphical User Interface: windows, controls, events instead of pure text I/O.

## Windows Forms
- Desktop UI framework for .NET (classic / mature)
- Event-driven programming model

## Core Concepts
| Concept | Description |
|---------|-------------|
| Form | Top-level window (inherits `System.Windows.Forms.Form`) |
| Control | UI element (Button, TextBox, Label, DataGridView) |
| Event | Notification (Click, Load, TextChanged) |
| Event Handler | Method subscribed to an event |
| Designer | Visual surface to place & configure controls |

## Event Pattern
```csharp
private void buttonSave_Click(object sender, EventArgs e)
{
    // Validate, then act
}
```

## Common Controls
Label, TextBox, Button, ListBox, ComboBox, CheckBox, RadioButton, DataGridView, MenuStrip, StatusStrip, ToolStrip.

## Data Binding (Simple)
```csharp
listBoxStudents.DataSource = students; // where students is a List<Student>
```
For complex UIs prefer `BindingSource` intermediaries.

## Layout Tips
- Use TableLayoutPanel for grid-like arrangements
- Use FlowLayoutPanel for dynamic wrapping
- Anchor / Dock to handle window resizing

## Validation Pattern
1. Read input (TextBox.Text)
2. Try parse / check empty
3. Show `ErrorProvider` message or `MessageBox.Show` on failure
4. Proceed on success

## Threading Note
Long operations: run on background thread (Task.Run) then marshal back with `Invoke`.

## Comparing UI Options
| Technology | When to Use |
|------------|-------------|
| WinForms | Quick CRUD tools, legacy support |
| WPF | Rich styling / MVVM |
| MAUI | Cross-platform (mobile/desktop) |
| Blazor | Web / hybrid |

## Minimal Form Example
```csharp
public partial class MainForm : Form
{
    private readonly List<string> _items = new();

    public MainForm()
    {
        InitializeComponent();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(textBoxItem.Text))
        {
            _items.Add(textBoxItem.Text.Trim());
            listBoxItems.DataSource = null; // refresh
            listBoxItems.DataSource = _items;
            textBoxItem.Clear();
        }
    }
}
```

## Next Steps
- Add MenuStrip & status bar
- Persist data to file or database
- Introduce MVVM style separation (even in WinForms) for testability
