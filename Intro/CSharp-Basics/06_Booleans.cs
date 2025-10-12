// Expected output:
// a && b = False
// a || b = True
// !a = False

using System;

namespace Intro.CSharpBasics
{
    class Booleans
    {
        static void Main()
        {
            bool a = true;
            bool b = false;

            Console.WriteLine($"a && b = {a && b}"); // AND
            Console.WriteLine($"a || b = {a || b}"); // OR
            Console.WriteLine($"!a = {!a}");         // NOT
        }
    }
}
