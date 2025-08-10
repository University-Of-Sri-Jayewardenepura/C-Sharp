using System;
using System.Linq;

namespace ConsoleApps.Strings
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a sentence:");
            string input = Console.ReadLine() ?? string.Empty;
            string trimmed = input.Trim();
            string upper = trimmed.ToUpperInvariant();
            string[] words = trimmed.Split(new[]{' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Original: '{input}'");
            Console.WriteLine($"Trimmed: '{trimmed}'");
            Console.WriteLine($"Upper: '{upper}'");
            Console.WriteLine($"Word count: {words.Length}");
            if (trimmed.Length > 0)
            {
                Console.WriteLine($"First char: {trimmed[0]}");
                Console.WriteLine($"Last  char: {trimmed[^1]}");
            }
            Console.WriteLine($"Index of first space: {trimmed.IndexOf(' ')}");
            Console.WriteLine($"Substring (first 5 or less): {(trimmed.Length >=5 ? trimmed.Substring(0,5) : trimmed)}");
            Console.WriteLine("Original still unchanged (immutability): " + input);
        }
    }
}
