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
        public string JobTitle { get; private set; }
        public int EmployeeID { get; private set; }

        public Employee(string name, int age, string jobTitle, int employeeID): base(name, age)
        {
            JobTitle = jobTitle;
            EmployeeID = employeeID;
            
            Console.WriteLine("Employee (derived class) constructor called");
        }

        public void DisplayEmployeeInfo()
        {
            DisplayPersonInfo();
            Console.WriteLine($"Job title: {JobTitle}, Employee ID: {EmployeeID}");
        }
    }

    public class Manager: Employee
    {
        public int TeamSize { get; private set; }

        public Manager(string name, int age, string jobTitle, int employeeID, int teamSize): base(name, age, jobTitle, employeeID)
        {
            TeamSize = teamSize;
        }

        public void DisplayManagerInfo()
        {
            DisplayEmployeeInfo();
            Console.WriteLine($"Team size: {TeamSize}");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Manager joe = new Manager("Joe", 36, "Sales Rep", 1234, 7);
            joe.DisplayManagerInfo();
            Console.ReadKey();
        }
    }
}
