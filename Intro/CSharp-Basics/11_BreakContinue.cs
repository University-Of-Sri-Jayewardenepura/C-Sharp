// Expected output:
// 1 2 4 5

using System;

namespace Intro.CSharpBasics
{
    class BreakContinue
    {
        static void Main()
        {
            for (int i = 1; i <= 5; i++)
            {
                if (i == 3) { continue; } // skip 3
                Console.Write(i + (i < 5 ? " " : "\n"));
            }

            // Another example: break
            int n = 1;
            while (true)
            {
                if (n > 5) break; // exit the loop
                n++;
            }
        }
    }
}
