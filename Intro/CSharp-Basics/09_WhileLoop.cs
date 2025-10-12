// Expected output:
// 1 2 3 4 5

using System;

namespace Intro.CSharpBasics
{
    class WhileLoop
    {
        static void Main()
        {
            int i = 1;
            while (i <= 5)
            {
                Console.Write(i + (i < 5 ? " " : "\n"));
                i++;
            }
        }
    }
}
