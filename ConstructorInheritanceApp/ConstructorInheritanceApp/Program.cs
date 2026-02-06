namespace ConstructorInheritanceApp
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }

        // Base class constructor
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine("Person constructor called");
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
    
    public class Employee: Person
    {
        public Employee(string name, int age): base(name, age)
        {
            Console.WriteLine("Employee (derived class) constructor called");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee joe = new Employee("Joe", 36);
            joe.DisplayPersonInfo();
            Console.ReadKey();
        }
    }
}
