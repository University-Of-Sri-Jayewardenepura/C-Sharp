using System;

namespace MyNamespace
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Calculator class
            Calculator calc = new Calculator();

            // Get user input for two numbers and an operation
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Select an operation (+, -, *):");
            char operation = Char.Parse(Console.ReadLine().ToUpper());

            // Perform calculation based on user input
            int result = 0;
            switch (operation)
            {
                case '+':
                    result = calc.Add(num1, num2);
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
            }

            // Print the result
            Console.WriteLine($"The result is: {result}");
        }
    }
}