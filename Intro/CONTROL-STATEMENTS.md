# Control Statements in C#

Control statements in C# manage the flow of execution in a program. They are divided into three main categories:

1. **Selection Statements**
2. **Iteration Statements**
3. **Jump Statements**

## 1. Selection Statements

Selection statements allow a program to choose different paths of execution based on conditions.

### **if...else**

The `if...else` statement allows conditional execution of code blocks.

**Example:**

```csharp
int number = 10;

if (number > 5)
{
    Console.WriteLine("The number is greater than 5.");
}
else
{
    Console.WriteLine("The number is 5 or less.");
}
```

### **switch...case**

The `switch...case` statement allows selection among multiple options.

**Example:**

```csharp
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    default:
        Console.WriteLine("Another day");
        break;
}
```

## 2. Iteration Statements

Iteration statements allow a block of code to be executed repeatedly based on a condition.

### **while**

The `while` loop executes a block of code as long as the condition is true.

**Example:**

```csharp
int count = 1;

while (count <= 5)
{
    Console.WriteLine($"Count: {count}");
    count++;
}
```

### **do...while**

The `do...while` loop is similar to `while`, but it guarantees at least one execution before checking the condition.

**Example:**

```csharp
int count = 1;

do
{
    Console.WriteLine($"Count: {count}");
    count++;
} while (count <= 5);
```

### **for**

The `for` loop provides a compact way to iterate with initialization, condition checking, and iteration expression all in one line.

**Example:**

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Iteration: {i}");
}
```

#### **foreach**

The `foreach` loop in C# is used to iterate over elements in a collection (such as an array, list, or any enumerable object) without needing to manage the loop counter manually. It's particularly useful when you want to iterate through all elements in a collection without modifying them.

**Syntax:**

```csharp
foreach (var element in collection)
{
    // Code to execute for each element
}
```

**Example:**

```csharp
string[] fruits = { "Apple", "Banana", "Cherry", "Date" };

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
```

**Explanation:**

- In the example above, the `foreach` loop iterates over each string in the `fruits` array.
- The variable `fruit` takes on the value of each element in the array as the loop progresses.
- The `Console.WriteLine(fruit);` statement prints each fruit name on a new line.

**Output:**

```plaintext
Apple
Banana
Cherry
Date
```

**Use Cases:**

- **Iterating Through Collections:** `foreach` is perfect for iterating through elements in a collection, where you don't need to modify the elements.
- **Read-Only Access:** The loop variable in a `foreach` loop is read-only, ensuring that the collection elements aren't inadvertently modified.
- **Simplifying Code:** It reduces the complexity of managing loop counters and bounds checking.

## 3. Jump Statements

Jump statements transfer control to different parts of the program.

### **break**

The `break` statement exits the loop or switch statement.

**Example:**

```csharp
for (int i = 1; i <= 10; i++)
{
    if (i == 6)
    {
        break; // Exit the loop when i is 6
    }
    Console.WriteLine(i);
}
```

### **continue**

The `continue` statement skips the current iteration of the loop and moves to the next iteration.

**Example:**

```csharp
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        continue; // Skip even numbers
    }
    Console.WriteLine(i);
}
```

