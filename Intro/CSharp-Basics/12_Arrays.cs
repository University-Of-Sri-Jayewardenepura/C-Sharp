// Expected output:
// First=10, Last=50, Length=5
// Sum=150

using System;

namespace Intro.CSharpBasics
{
    class ArraysDemo
    {
        static void Main()
        {
            int[] numbers = { 10, 20, 30, 40, 50 };

            Console.WriteLine($"First={numbers[0]}, Last={numbers[numbers.Length - 1]}, Length={numbers.Length}");

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine($"Sum={sum}");
        }
    }
}
