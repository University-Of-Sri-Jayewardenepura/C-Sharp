// Example interaction:
// Enter your name: Bob
// Enter your age: 25
// Hello Bob, you are 25 years old.

using System;

namespace Intro.CSharpBasics
{
    class UserInput
    {
        static void Main()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string ageText = Console.ReadLine();

            // Convert string to int safely
            if (int.TryParse(ageText, out int age))
            {
                Console.WriteLine($"Hello {name}, you are {age} years old.");
            }
            else
            {
                Console.WriteLine("That wasn't a valid whole number for age.");
            }
        }
    }
}
