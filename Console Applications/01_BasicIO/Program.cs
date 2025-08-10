using System;

namespace ConsoleApps.BasicIO
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            int age;
            while (true)
            {
                Console.Write("Enter your age: ");
                string raw = Console.ReadLine();
                if (int.TryParse(raw, out age) && age >= 0 && age < 130)
                {
                    break;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Invalid age. Please enter a whole number between 0 and 129.\n");
                Console.ResetColor();
            }

            int currentYear = DateTime.Now.Year;
            int approximateBirthYear = currentYear - age;

            Console.WriteLine();
            Console.WriteLine($"Hello {name}, you are {age} years old. Approximate birth year: {approximateBirthYear}.");
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
