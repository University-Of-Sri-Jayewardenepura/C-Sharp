# Menus, Reports & MDI

## Menus
Use `MenuStrip` in WinForms to provide top-level navigation.

Typical Items: File (New, Open, Save, Exit), Edit (Copy, Paste), View (Toggle Panels), Help (About).

Wiring Events:
```csharp
private void exitToolStripMenuItem_Click(object sender, EventArgs e)
{
    Close();
}
```

## Reports (Conceptual)
- Summaries / aggregated views of data
- Can be generated manually (string building, DataGridView export) or via reporting tools (e.g., RDLC, Crystal Reports)

### Simple Text Report Pattern
```csharp
var report = new StringBuilder();
report.AppendLine("STUDENT SUMMARY");
foreach (var s in students)
    report.AppendLine($"{s.Id}\t{s.Name}\t{s.Average:0.0}");
File.WriteAllText("students_report.txt", report.ToString());
```

## MDI (Multiple Document Interface)
Parent window hosts multiple child forms inside a single container.

Steps:
1. Set parent form `IsMdiContainer = true`
2. Create child: `child.MdiParent = this; child.Show();`

Pros: Centralized menus/toolbars; Cons: Outdated UX vs. tabbed interfaces.

## Status & Tool Strips
- `StatusStrip` for state messages
- `ToolStrip` for quick actions (icons)

## Keyboard Shortcuts
Assign via `ShortcutKeys` property (e.g., Ctrl+S for Save menu item).

## Printing / Export Basics
- DataGridView -> CSV (loop rows/cells)
- Report text -> PDF (via library) or print dialog

## Next Steps
Introduce a sample WinForms app: Menu (File->Export), Child windows for Editors, Report generation.
