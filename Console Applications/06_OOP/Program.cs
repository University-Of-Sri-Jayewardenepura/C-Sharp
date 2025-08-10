using System;
using System.Collections.Generic;

namespace ConsoleApps.OOP
{
    class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;
        public virtual string Describe() => $"Person: {Name}";
    }

    class Employee : Person
    {
        public decimal Salary { get; private set; }
        public Employee(string name, decimal salary) : base(name) => Salary = salary;
        public override string Describe() => $"Employee: {Name} earns {Salary:C}";
        public void GiveRaise(decimal amount) => Salary += amount;
    }

    class Program
    {
        static void Main()
        {
            var people = new List<Person>
            {
                new Person("Alice"),
                new Employee("Bob", 50000m),
                new Employee("Charlie", 62000m)
            };
            foreach (var p in people)
            {
                Console.WriteLine(p.Describe());
            }
        }
    }
}
