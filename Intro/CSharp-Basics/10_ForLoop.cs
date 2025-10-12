// Expected output:
// 0 2 4 6 8

using System;

namespace Intro.CSharpBasics
{
    class ForLoop
    {
        static void Main()
        {
            for (int i = 0; i < 10; i += 2)
            {
                Console.Write(i + (i < 8 ? " " : "\n"));
            }
        }
    }
}
