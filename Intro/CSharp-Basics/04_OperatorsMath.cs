// Expected output:
// add=7, sub=1, mul=12, div=3, mod=1
// pow=81, sqrt=3, abs=5

using System;

namespace Intro.CSharpBasics
{
    class OperatorsMath
    {
        static void Main()
        {
            int x = 4, y = 3;
            int add = x + y;
            int sub = x - y;
            int mul = x * y;
            int div = x / y; // integer division
            int mod = x % y; // remainder

            Console.WriteLine($"add={add}, sub={sub}, mul={mul}, div={div}, mod={mod}");

            double pow = Math.Pow(3, 4);  // 3^4
            double sqrt = Math.Sqrt(9);
            int abs = Math.Abs(-5);

            Console.WriteLine($"pow={pow}, sqrt={sqrt}, abs={abs}");
        }
    }
}
