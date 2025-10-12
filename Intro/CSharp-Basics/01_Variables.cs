// Expected output (example):
// Name: Alice, Age: 30
// Pi Approx: 3.14, IsStudent: True
// After age++: 31

using System;

namespace Intro.CSharpBasics
{
    class Variables
    {
        static void Main()
        {
            string name = "Alice"; // text
            int age = 30;           // whole number
            double pi = 3.14;       // decimal (double precision)
            bool isStudent = true;  // true/false

            Console.WriteLine($"Name: {name}, Age: {age}");
            Console.WriteLine($"Pi Approx: {pi}, IsStudent: {isStudent}");

            age++; // increment by 1
            Console.WriteLine($"After age++: {age}");
        }
    }
}
