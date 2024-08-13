using System;

namespace OOPExample
{
    // Abstraction: Abstract class Shape provides a template for all shapes
    public abstract class Shape
    {
        // Encapsulation: Abstract method to calculate area (to be implemented by derived classes)
        public abstract double CalculateArea();

        // Concrete method to display information about the shape
        public void Display()
        {
            Console.WriteLine("Displaying the shape.");
        }
    }

    // Inheritance: Circle class inherits from the abstract class Shape
    public class Circle : Shape
    {
        // Encapsulation: Private field for radius with a public property
        private double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        // Constructor to initialize the radius
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Polymorphism: Overriding the CalculateArea method for Circle
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    // Inheritance: Rectangle class inherits from the abstract class Shape
    public class Rectangle : Shape
    {
        // Encapsulation: Private fields for length and width with public properties
        private double length;
        private double width;

        public double Length
        {
            get { return length; }
            set { length = value; }
        }

        public double Width
        {
            get { return width; }
            set { width = value; }
        }

        // Constructor to initialize length and width
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        // Polymorphism: Overriding the CalculateArea method for Rectangle
        public override double CalculateArea()
        {
            return Length * Width;
        }
    }

    // Main program class
    class Program
    {
        static void Main(string[] args)
        {
            // Polymorphism in action: Treating different shapes as Shape objects
            Shape myCircle = new Circle(5.0);
            Shape myRectangle = new Rectangle(4.0, 6.0);

            // Calculating and displaying areas
            Console.WriteLine("Circle Area: " + myCircle.CalculateArea());
            Console.WriteLine("Rectangle Area: " + myRectangle.CalculateArea());

            // Using the Display method from the Shape class
            myCircle.Display();
            myRectangle.Display();
        }
    }
}
