# C# Methods 

## Introduction

**Have you heard about functions in C#?** In C#, functions and methods are often used interchangeably. Both refer to a block of code that performs a specific task. This code block is defined by a signature and contains statements that are executed sequentially.

## Main Components of a Function/Method

A function/method in C# consists of the following main parts:

1. **Access Modifier**: Defines the visibility of the function, such as `public`, `private`, `protected`, etc.
2. **Return Type**: Specifies the type of value that the function returns. If the function does not return a value, the return type is `void`.
3. **Function Name**: The name of the function, which is used to call it.
4. **Parameters**: A list of parameters (if any) that the function takes as input.
5. **Body**: The block of code that executes the function's statements.

## Mathematical Functions

C# provides several built-in mathematical functions that are part of the `Math` class:

- **Math.Abs()**: Returns the absolute value of a given number.

  ```csharp
  int number = -5;
  int absoluteValue = Math.Abs(number);
  Console.WriteLine(absoluteValue); // Output: 5
  ```

- **Math.Floor()** & **Math.Ceiling()**: Return the floor (largest integer less than or equal to the number) and ceiling (smallest integer greater than or equal to the number) of a specified number.

  ```csharp
  double number = 7.8;
  Console.WriteLine(Math.Floor(number)); // Output: 7
  Console.WriteLine(Math.Ceiling(number)); // Output: 8
  ```

- **Math.DivRem(dividend, divisor, out remainder)**: Returns the quotient of the division and stores the remainder in the out parameter.

  ```csharp
  int dividend = 10;
  int divisor = 3;
  int remainder;
  int quotient = Math.DivRem(dividend, divisor, out remainder);
  Console.WriteLine($"Quotient: {quotient}, Remainder: {remainder}"); // Output: Quotient: 3, Remainder: 1
  ```

- **Math.Min()** & **Math.Max()**: Return the smallest and largest values among the given arguments.

  ```csharp
  int a = 5, b = 10;
  Console.WriteLine(Math.Min(a, b)); // Output: 5
  Console.WriteLine(Math.Max(a, b)); // Output: 10
  ```

- **Math.Pow(base, exponent)**: Returns the result of raising a number to a specified power.

  ```csharp
  double result = Math.Pow(2, 3);
  Console.WriteLine(result); // Output: 8
  ```

- **Math.Round()**: Rounds a number to the nearest integer or to a specified number of decimal places.

  ```csharp
  double number = 5.678;
  Console.WriteLine(Math.Round(number)); // Output: 6
  ```

- **Math.Sqrt()**: Returns the square root of the given number.

  ```csharp
  double number = 16;
  Console.WriteLine(Math.Sqrt(number)); // Output: 4
  ```

## Generating Random Numbers

In C#, the `Random` class is used to generate random numbers. Here's an example:

```csharp
Random rand = new Random();
Console.WriteLine("Random number between 1 and 10: " + rand.Next(1, 11));
Console.ReadKey();
```

## User-Defined Functions

C# allows you to define your own functions. Below are examples of the four main types of user-defined functions:

1. **Function with No Arguments and No Return Value**:

   ```csharp
   public void PrintMessage()
   {
       Console.WriteLine("Hello, World!");
   }
   ```

   Usage:

   ```csharp
   PrintMessage(); // Output: Hello, World!
   ```

2. **Function with No Arguments and a Return Value**:

   ```csharp
   public int GetRandomNumber()
   {
       Random rand = new Random();
       return rand.Next(1, 101);
   }
   ```

   Usage:

   ```csharp
   int number = GetRandomNumber();
   Console.WriteLine("Random Number: " + number);
   ```

3. **Function with Arguments and No Return Value**:

   ```csharp
   public void PrintSum(int a, int b)
   {
       int sum = a + b;
       Console.WriteLine("Sum: " + sum);
   }
   ```

   Usage:

   ```csharp
   PrintSum(5, 10); // Output: Sum: 15
   ```

4. **Function with Arguments and a Return Value**:

   ```csharp
   public int Multiply(int a, int b)
   {
       return a * b;
   }
   ```

   Usage:

   ```csharp
   int result = Multiply(4, 5);
   Console.WriteLine("Product: " + result); // Output: Product: 20
   ```
