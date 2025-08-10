using System;

namespace ConsoleApps.Exceptions
{
    class NegativeDivisorException : Exception
    {
        public NegativeDivisorException(int value) : base($"Divisor cannot be negative: {value}") { }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Division Tool (q to quit)");
            while (true)
            {
                Console.Write("Dividend: ");
                string? dRaw = Console.ReadLine();
                if (dRaw == "q") break;
                Console.Write("Divisor : ");
                string? vRaw = Console.ReadLine();
                if (vRaw == "q") break;
                try
                {
                    int dividend = int.Parse(dRaw!);
                    int divisor = int.Parse(vRaw!);
                    if (divisor < 0) throw new NegativeDivisorException(divisor);
                    int result = dividend / divisor; // may throw DivideByZeroException
                    Console.WriteLine($"Result: {result}\n");
                }
                catch (NegativeDivisorException ex)
                {
                    Console.WriteLine("Custom Error: " + ex.Message + "\n");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero.\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Input must be whole numbers.\n");
                }
                finally
                {
                    // cleanup spot
                }
            }
        }
    }
}
