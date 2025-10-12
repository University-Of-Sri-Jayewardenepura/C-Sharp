// Expected output for input of 2:
// Two

using System;

namespace Intro.CSharpBasics
{
    class SwitchDemo
    {
        static void Main()
        {
            Console.Write("Enter 1, 2, or 3: ");
            string raw = Console.ReadLine();
            if (!int.TryParse(raw, out int n))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            switch (n)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                default:
                    Console.WriteLine("Other");
                    break;
            }
        }
    }
}
