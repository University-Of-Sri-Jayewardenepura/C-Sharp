using System;

namespace ConsoleApps.Methods
{
    static class MathUtil
    {
        public static int Add(int a, int b) => a + b;
        public static int Add(int a, int b, int c) => a + b + c; // overload
        public static void PrintTitle(string title)
        {
            Console.WriteLine(new string('=', title.Length));
            Console.WriteLine(title);
            Console.WriteLine(new string('=', title.Length));
        }
        public static int RandomInRange(int minInclusive, int maxExclusive) => _rand.Next(minInclusive, maxExclusive);
        public static double Power(double b, double exp) => Math.Pow(b, exp);
        private static readonly Random _rand = new Random();
    }

    class Program
    {
        static void Main()
        {
            MathUtil.PrintTitle("Method Demo");
            Console.WriteLine($"5 + 7 = {MathUtil.Add(5,7)}");
            Console.WriteLine($"5 + 7 + 10 = {MathUtil.Add(5,7,10)}");
            Console.WriteLine($"Random [1,10): {MathUtil.RandomInRange(1,10)}");
            Console.WriteLine($"2^8 = {MathUtil.Power(2,8)}");
        }
    }
}
