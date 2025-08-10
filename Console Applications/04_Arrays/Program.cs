using System;

namespace ConsoleApps.Arrays
{
    class Program
    {
        static void Main()
        {
            const int size = 5;
            int[] scores = new int[size];
            for (int i = 0; i < size; i++)
            {
                scores[i] = ReadInt($"Enter score {i+1}/{size}: ");
            }
            int sum = 0; foreach (var s in scores) sum += s;
            double avg = sum / (double)size;
            int max = int.MinValue, min = int.MaxValue;
            foreach (var s in scores) { if (s > max) max = s; if (s < min) min = s; }
            Console.WriteLine($"Average: {avg:F2}, Min: {min}, Max: {max}");
            int[] clone = (int[])scores.Clone();
            Array.Sort(clone);
            Console.WriteLine("Ascending: " + string.Join(", ", clone));
            Array.Reverse(clone);
            Console.WriteLine("Descending: " + string.Join(", ", clone));
            int search = ReadInt("Search for a score: ");
            int idx = Array.IndexOf(scores, search);
            Console.WriteLine(idx >= 0 ? $"Found at index {idx}" : "Not found");
            int[,] grades = new int[2,3] { {80,90,100}, {70,85,95} };
            Console.WriteLine("2D grades:");
            for (int r = 0; r < grades.GetLength(0); r++)
            {
                for (int c = 0; c < grades.GetLength(1); c++)
                {
                    Console.Write(grades[r,c] + "\t");
                }
                Console.WriteLine();
            }
        }
        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                if (int.TryParse(Console.ReadLine(), out int value)) return value;
                Console.WriteLine("Invalid integer. Try again.");
            }
        }
    }
}
