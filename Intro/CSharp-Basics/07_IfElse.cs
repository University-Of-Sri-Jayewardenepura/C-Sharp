// Expected output depends on input value

using System;

namespace Intro.CSharpBasics
{
    class IfElse
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            string raw = Console.ReadLine();
            if (!int.TryParse(raw, out int n))
            {
                Console.WriteLine("Not a valid integer.");
                return;
            }

            if (n > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (n < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }
        }
    }
}
