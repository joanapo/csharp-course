namespace Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> employees = new Dictionary<int, string>();

            employees.Add(101, "John Doe");
            employees.Add(102, "Bob Smith");
            employees.Add(103, "Bob Smith");
            employees.Add(104, "Bob Smith");
            employees.Add(105, "Bob Smith");
            employees.Add(106, "Bob Smith");

            string name = employees[101];
            //Console.WriteLine(name);

            employees[102] = "Jane Smith";

            employees.Remove(101);

            if (!employees.ContainsKey(101))
            {
                employees.Add(101, "Mike Jike");
            }

            int counter = 101;
            while (employees.ContainsKey(counter))
            {
                counter++;
            }
            employees.Add(counter, "Bob Rob");

            foreach (KeyValuePair<int, string> employee in employees)
            {
                Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
            }
            
            Console.ReadKey();
        }
    }
}
