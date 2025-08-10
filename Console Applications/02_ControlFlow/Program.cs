using System;
using System.Globalization;

namespace ConsoleApps.ControlFlow
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.WriteLine("==== Mini Calculator ====");
                Console.WriteLine("1) Add  2) Subtract  3) Multiply  4) Divide  0) Exit");
                Console.Write("Select option: ");
                string choice = Console.ReadLine();

                if (choice == "0")
                {
                    Console.WriteLine("Goodbye.");
                    break;
                }

                if (!(choice == "1" || choice == "2" || choice == "3" || choice == "4"))
                {
                    Console.WriteLine("Invalid option.\n");
                    continue;
                }

                double a = ReadDouble("Enter first number: ");
                double b = ReadDouble("Enter second number: ");
                double result;

                switch (choice)
                {
                    case "1": result = a + b; break;
                    case "2": result = a - b; break;
                    case "3": result = a * b; break;
                    case "4":
                        if (b == 0)
                        {
                            Console.WriteLine("Cannot divide by zero.\n");
                            continue;
                        }
                        result = a / b; break;
                    default:
                        continue;
                }
                Console.WriteLine($"Result = {result}\n");
            }
        }
        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string raw = Console.ReadLine();
                if (double.TryParse(raw, NumberStyles.Float, CultureInfo.InvariantCulture, out double value))
                    return value;
                Console.WriteLine("Invalid number. Try again.");
            }
        }
    }
}
