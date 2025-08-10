using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// Combined example: collections, LINQ, file I/O, methods, simple error handling
namespace MoreExamples
{
    public record Student(int Id, string Name, List<int> Scores)
    {
        public double Average => Scores.Count == 0 ? 0 : Scores.Average();
    }

    public static class StudentRepository
    {
        private static readonly List<Student> _students = new();
        private static int _nextId = 1;

        public static IReadOnlyList<Student> All => _students;

        public static Student Add(string name, IEnumerable<int> scores)
        {
            var list = scores.ToList();
            var student = new Student(_nextId++, name, list);
            _students.Add(student);
            return student;
        }

        public static bool Remove(int id) => _students.RemoveAll(s => s.Id == id) > 0;

        public static Student? Find(int id) => _students.FirstOrDefault(s => s.Id == id);

        public static void SeedDemo()
        {
            if (_students.Count == 0)
            {
                Add("Ana", new[] { 85, 90, 92 });
                Add("Ben", new[] { 70, 75, 80 });
                Add("Cara", new[] { 95, 88, 91 });
            }
        }

        public static void Save(string path)
        {
            using var writer = new StreamWriter(path);
            foreach (var s in _students)
            {
                writer.WriteLine($"{s.Id}|{s.Name}|{string.Join(',', s.Scores)}");
            }
        }

        public static void Load(string path)
        {
            _students.Clear();
            _nextId = 1;
            if (!File.Exists(path)) return;
            foreach (var line in File.ReadAllLines(path))
            {
                var parts = line.Split('|');
                if (parts.Length < 3) continue;
                var id = int.Parse(parts[0]);
                var name = parts[1];
                var scores = parts[2].Split(',', StringSplitOptions.RemoveEmptyEntries)
                                      .Select(int.Parse)
                                      .ToList();
                _students.Add(new Student(id, name, scores));
                _nextId = Math.Max(_nextId, id + 1);
            }
        }
    }

    public static class StudentScoresApp
    {
        private const string DataFile = "students.data";

        public static void Run()
        {
            StudentRepository.Load(DataFile);
            StudentRepository.SeedDemo();
            while (true)
            {
                Console.WriteLine("\nSTUDENT SCORE MANAGER");
                Console.WriteLine("1. List Students");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Remove Student");
                Console.WriteLine("4. Top Performers (Avg >= 85)");
                Console.WriteLine("5. Save & Exit");
                Console.Write("Select: ");
                var choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": List(); break;
                    case "2": Add(); break;
                    case "3": Remove(); break;
                    case "4": Top(); break;
                    case "5": SaveAndExit(); return;
                    default: Console.WriteLine("Invalid"); break;
                }
            }
        }

        private static void List()
        {
            if (StudentRepository.All.Count == 0)
            {
                Console.WriteLine("No students.");
                return;
            }
            foreach (var s in StudentRepository.All.OrderByDescending(s => s.Average))
            {
                Console.WriteLine($"{s.Id,2} {s.Name,-10} Avg: {s.Average,5:0.0} Scores: {string.Join(',', s.Scores)}");
            }
        }

        private static void Add()
        {
            Console.Write("Name: ");
            var name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name)) { Console.WriteLine("Name required"); return; }
            Console.Write("Scores (comma separated): ");
            var raw = Console.ReadLine() ?? string.Empty;
            var scores = new List<int>();
            foreach (var token in raw.Split(',', StringSplitOptions.RemoveEmptyEntries))
            {
                if (int.TryParse(token.Trim(), out int sc) && sc >= 0 && sc <= 100)
                    scores.Add(sc);
            }
            StudentRepository.Add(name.Trim(), scores);
            Console.WriteLine("Added.");
        }

        private static void Remove()
        {
            Console.Write("Id to remove: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine(StudentRepository.Remove(id) ? "Removed" : "Not found");
            }
        }

        private static void Top()
        {
            var top = StudentRepository.All.Where(s => s.Average >= 85)
                                           .OrderByDescending(s => s.Average)
                                           .ToList();
            if (top.Count == 0) { Console.WriteLine("None found"); return; }
            foreach (var s in top)
                Console.WriteLine($"{s.Name} -> {s.Average:0.0}");
        }

        private static void SaveAndExit()
        {
            StudentRepository.Save(DataFile);
            Console.WriteLine("Saved. Bye!");
        }
    }
}
