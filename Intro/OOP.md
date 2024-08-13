# Object-Oriented Programming (OOP) in C#

## Encapsulation

### Definition

**Encapsulation** is one of the fundamental principles of Object-Oriented Programming (OOP). It refers to the bundling of data (fields) and methods (functions) that operate on the data into a single unit, or class. Encapsulation also restricts direct access to some of an object’s components, which is a means of preventing unintended interference and misuse.

### Example: Encapsulation in C#

Below is an example of how encapsulation is implemented in C# using a class named `Employee`. 

```csharp
public class Employee
{
    private string employeeName; // Private field

    // Public property to encapsulate the private field
    public string EmployeeName
    {
        get
        {
            return employeeName;
        }
        set
        {
            employeeName = value;
        }
    }
}
```

### Explanation

In the example above:

- **Private Field:** The `employeeName` field is declared as `private`, meaning it cannot be accessed directly from outside the `Employee` class. This is a key aspect of encapsulation, as it hides the internal state of the object.
  
- **Public Property:** The `EmployeeName` property is declared as `public`, allowing controlled access to the private `employeeName` field. The property provides `get` and `set` methods to read and modify the value of `employeeName`, respectively.

### Benefits of Encapsulation

1. **Data Hiding:** By using encapsulation, the internal implementation details of a class are hidden from the outside world. This ensures that the object's internal state is protected from unintended changes.
  
2. **Controlled Access:** Encapsulation allows controlled access to the data by providing public methods (getters and setters) to retrieve or modify the data. This helps in maintaining the integrity of the data.
  
3. **Flexibility and Maintainability:** Encapsulation makes the code more flexible and easier to maintain. Changes to the internal implementation of a class do not affect the code that uses the class.


## Inheritance

### Definition

**Inheritance** is a key principle of Object-Oriented Programming (OOP) that allows a new class (derived class) to inherit properties and behaviors (methods) from an existing class (base class). This promotes code reuse and establishes a natural hierarchy between classes.

### Example: Inheritance in C#

Below is an example demonstrating inheritance using two classes, `Parent` and `Child`, in C#.

```csharp
using System;

public class Parent
{
    // Constructor of the Parent class
    public Parent()
    {
        Console.WriteLine("Parent class constructor");
    }

    // Virtual method that can be overridden in a derived class
    public virtual void Show()
    {
        Console.WriteLine("Parent show method");
    }
}

public class Child : Parent
{
    // Constructor of the Child class
    public Child()
    {
        Console.WriteLine("Child class constructor");
    }

    // Overriding the Show method from the Parent class
    public override void Show()
    {
        Console.WriteLine("Child show method");
    }
}
```

### Explanation

In the example above:

- **Base Class (`Parent`):** The `Parent` class contains a constructor and a virtual method `Show()`. The virtual method allows derived classes to override it.

- **Derived Class (`Child`):** The `Child` class inherits from the `Parent` class using the colon (`:`) syntax. It also has its own constructor and overrides the `Show()` method of the `Parent` class using the `override` keyword.

### Output

When an instance of the `Child` class is created, the output will be:

```plaintext
Parent class constructor
Child class constructor
```

When the `Show()` method is called on the `Child` class instance, the output will be:

```plaintext
Child show method
```

### Benefits of Inheritance

1. **Code Reusability:** Inheritance allows the reuse of code from the base class in derived classes, reducing redundancy and improving maintainability.

2. **Method Overriding:** Derived classes can override base class methods to provide a more specific implementation, which is useful for achieving polymorphism.

3. **Extensibility:** Inheritance provides a way to build upon existing code, making it easier to extend the functionality of applications.

4. **Hierarchical Structure:** Inheritance naturally organizes code into a hierarchical structure, making it easier to understand and manage.

## Polymorphism

### Definition

**Polymorphism** is a fundamental concept in Object-Oriented Programming (OOP) that allows objects of different classes to be treated as objects of a common base class. Polymorphism enables a single method to operate on different types of objects, allowing for dynamic method binding and more flexible and reusable code.

### Example: Polymorphism in C#

Below is an example demonstrating polymorphism using a base class `Animal` and two derived classes `Dog` and `Cat` in C#.

```csharp
using System;

public class Animal
{
    // Virtual method that can be overridden in derived classes
    public virtual void MakeSound()
    {
        Console.WriteLine("Some generic animal sound");
    }
}

public class Dog : Animal
{
    // Overriding the MakeSound method in the Dog class
    public override void MakeSound()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

public class Cat : Animal
{
    // Overriding the MakeSound method in the Cat class
    public override void MakeSound()
    {
        Console.WriteLine("Meow! Meow!");
    }
}
```

### Explanation

In the example above:

- **Base Class (`Animal`):** The `Animal` class has a virtual method `MakeSound()` which can be overridden by derived classes.

- **Derived Classes (`Dog` and `Cat`):** The `Dog` and `Cat` classes both inherit from the `Animal` class and override the `MakeSound()` method to provide their own specific implementations.

### Polymorphism in Action

Polymorphism allows you to treat objects of `Dog` and `Cat` as `Animal` objects, but when the `MakeSound()` method is called, the correct method for the specific object type is executed.

```csharp
Animal myDog = new Dog();
Animal myCat = new Cat();

myDog.MakeSound(); // Output: Woof! Woof!
myCat.MakeSound(); // Output: Meow! Meow!
```

### Benefits of Polymorphism

1. **Flexibility and Extensibility:** Polymorphism allows methods to be used on objects of different types, making the code more flexible and easier to extend.

2. **Dynamic Method Binding:** The appropriate method is called at runtime based on the object type, enabling dynamic method binding.

3. **Code Reusability:** By writing generic code that operates on the base class, polymorphism promotes code reusability across different object types.

4. **Simplifies Code:** Polymorphism simplifies code by allowing the same interface to be used for different types of objects, reducing the need for multiple condition checks or type-specific code.



## Abstraction

### Definition

**Abstraction** is an essential concept in Object-Oriented Programming (OOP) that focuses on hiding the implementation details of a class and exposing only the necessary features to the user. It allows you to define a template (abstract class) with abstract methods that must be implemented by derived classes, promoting a clear separation between what a class does and how it does it.

### Example: Abstraction in C#

Below is an example demonstrating abstraction using an abstract base class `Shape` and its derived classes `Circle` and `Rectangle` in C#.

```csharp
using System;

public abstract class Shape
{
    // Abstract method that must be implemented by derived classes
    public abstract double CalculateArea();

    // Concrete method that can be optionally used by derived classes
    public void Display()
    {
        Console.WriteLine("Displaying the shape.");
    }
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    // Implementing the abstract method
    public override double CalculateArea()
    {
        return Math.PI * Radius * Radius;
    }
}

public class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    // Implementing the abstract method
    public override double CalculateArea()
    {
        return Length * Width;
    }
}
```

### Explanation

In the example above:

- **Abstract Base Class (`Shape`):** The `Shape` class is declared as abstract, meaning it cannot be instantiated directly. It contains an abstract method `CalculateArea()` that must be implemented by any derived class. The `Display()` method is a concrete method that provides a default behavior which derived classes can optionally use.

- **Derived Classes (`Circle` and `Rectangle`):** The `Circle` and `Rectangle` classes inherit from the `Shape` class and provide specific implementations for the `CalculateArea()` method. This allows each shape to define its own way of calculating the area while adhering to the interface provided by the abstract base class.

### Usage

Abstraction allows you to work with objects at a higher level, focusing on what they can do rather than how they do it. Here's how you might use these classes:

```csharp
Shape myCircle = new Circle(5.0);
Shape myRectangle = new Rectangle(4.0, 6.0);

Console.WriteLine("Circle Area: " + myCircle.CalculateArea());
Console.WriteLine("Rectangle Area: " + myRectangle.CalculateArea());

myCircle.Display(); // Optional use of the concrete method
myRectangle.Display(); // Optional use of the concrete method
```

### Benefits of Abstraction

1. **Code Clarity and Maintainability:** Abstraction helps in separating the interface from the implementation, making the code easier to understand and maintain.

2. **Reusability and Flexibility:** By defining a common interface for related classes, abstraction allows for reusability and flexibility in using different implementations interchangeably.

3. **Enhanced Security:** Abstraction hides the implementation details from the user, exposing only the necessary functionalities, which enhances security by preventing direct access to internal states and methods.

4. **Encourages Design Patterns:** Abstraction encourages the use of design patterns, as it provides a clear structure for defining relationships between different classes and objects.