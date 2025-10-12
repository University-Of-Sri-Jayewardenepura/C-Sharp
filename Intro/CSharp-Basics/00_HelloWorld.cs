// Expected output:
// Hello, C#!
// This is my first C# program.
// 2 + 3 = 5
// Goodbye!

using System;

// Single-line comment: Explains a line or a small idea.
/*
 Multi-line comment: Use for longer notes, instructions,
 or temporarily disabling code blocks.
*/

// Namespaces group related code and avoid name collisions
namespace Intro.CSharpBasics
{
    // A class is a blueprint that can contain data and behavior
    class HelloWorld
    {
        // The entry point: the program starts executing here
        static void Main()
        {
            // Write a line to the console
            Console.WriteLine("Hello, C#!");
            Console.WriteLine("This is my first C# program.");

            // Variables hold data. 'int' stores whole numbers
            int a = 2;
            int b = 3;
            int sum = a + b; // + is the addition operator
            Console.WriteLine($"{a} + {b} = {sum}"); // string interpolation

            Console.WriteLine("Goodbye!");
        }
    }
}
