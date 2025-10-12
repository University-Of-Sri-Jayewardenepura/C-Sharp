// Expected output:
// Length=11, Upper=HELLO WORLD
// Contains "WORLD"? True
// First name: Ada, Last name: Lovelace

using System;

namespace Intro.CSharpBasics
{
    class StringsDemo
    {
        static void Main()
        {
            string text = "Hello World";
            Console.WriteLine($"Length={text.Length}, Upper={text.ToUpper()}");
            Console.WriteLine($"Contains \"WORLD\"? {text.ToUpper().Contains("WORLD")}");

            // Split and interpolation
            string fullName = "Ada Lovelace";
            string[] parts = fullName.Split(' ');
            string first = parts[0];
            string last = parts[1];
            Console.WriteLine($"First name: {first}, Last name: {last}");
        }
    }
}
