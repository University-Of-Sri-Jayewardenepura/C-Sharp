using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApps.InMemoryCrud
{
    record Student(int Id, string Name);
    class Program
    {
        static readonly List<Student> _students = new();
        static void Main()
        {
            string? choice;
            do
            {
                Console.WriteLine("(C)reate  (L)ist  (S)earch  (U)pdate  (D)elete  (Q)uit");
                choice = Console.ReadLine()?.Trim().ToLowerInvariant();
                switch (choice)
                {
                    case "c": Create(); break;
                    case "l": List(); break;
                    case "s": Search(); break;
                    case "u": Update(); break;
                    case "d": Delete(); break;
                }
            } while (choice != "q");
        }
        static void Create()
        {
            int id = ReadInt("Id: ");
            Console.Write("Name: ");
            string name = Console.ReadLine() ?? "";
            if (_students.Any(s => s.Id == id)) { Console.WriteLine("Duplicate Id.\n"); return; }
            _students.Add(new Student(id, name));
            Console.WriteLine("Added.\n");
        }
        static void List()
        {
            if (_students.Count == 0) { Console.WriteLine("No students.\n"); return; }
            foreach (var s in _students) Console.WriteLine($"{s.Id}: {s.Name}");
            Console.WriteLine();
        }
        static void Search()
        {
            Console.Write("Name contains: ");
            string term = Console.ReadLine() ?? "";
            var matches = _students.Where(s => s.Name.Contains(term, StringComparison.OrdinalIgnoreCase)).ToList();
            if (matches.Count == 0) Console.WriteLine("None found.\n");
            else { foreach (var s in matches) Console.WriteLine($"{s.Id}: {s.Name}"); Console.WriteLine(); }
        }
        static void Update()
        {
            int id = ReadInt("Id to update: ");
            var idx = _students.FindIndex(s => s.Id == id);
            if (idx < 0) { Console.WriteLine("Not found.\n"); return; }
            Console.Write("New name: ");
            string name = Console.ReadLine() ?? "";
            _students[idx] = _students[idx] with { Name = name };
            Console.WriteLine("Updated.\n");
        }
        static void Delete()
        {
            int id = ReadInt("Id to delete: ");
            var removed = _students.RemoveAll(s => s.Id == id);
            Console.WriteLine(removed > 0 ? "Deleted.\n" : "Not found.\n");
        }
        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int v)) return v;
                Console.WriteLine("Invalid integer.");
            }
        }
    }
}
