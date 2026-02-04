namespace Dictionaries
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        
        public Employee(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> employees = new Dictionary<int, Employee>();

            employees.Add(1, new Employee("John Doe", 35, 10000));
            employees.Add(2, new Employee("John Does", 35, 1008900));
            employees.Add(3, new Employee("John Dofe", 35, 100070));
            employees.Add(4, new Employee("John Dogde", 35, 170000));
            employees.Add(5, new Employee("John Doeg", 35, 1023000));
            
            foreach (var item in employees)
            {
                Console.WriteLine($"ID: {item.Key} named: {item.Value.Name}, earns: {item.Value.Salary} and is {item.Value.Age} years old!");
            }
            
            Console.ReadKey();
        }
    }
}
