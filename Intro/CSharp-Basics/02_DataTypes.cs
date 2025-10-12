// Expected output:
// byte: 255, short: 32000, int: 2000000000, long: 900000000000
// float: 3.14, double: 3.1415926535, decimal: 3.1415926535
// char: A, string: Hello, bool: True

using System;

namespace Intro.CSharpBasics
{
    class DataTypes
    {
        static void Main()
        {
            byte by = 255;         // 0..255
            short sh = 32000;      // ~ -32k..32k
            int i = 2_000_000_000; // underscores for readability
            long l = 900_000_000_000L; // suffix L for long literal

            float f = 3.14f;       // suffix f for float
            double d = 3.1415926535;
            decimal m = 3.1415926535m; // suffix m for decimal (higher precision for money)

            char c = 'A';
            string s = "Hello";
            bool b = true;

            Console.WriteLine($"byte: {by}, short: {sh}, int: {i}, long: {l}");
            Console.WriteLine($"float: {f}, double: {d}, decimal: {m}");
            Console.WriteLine($"char: {c}, string: {s}, bool: {b}");
        }
    }
}
