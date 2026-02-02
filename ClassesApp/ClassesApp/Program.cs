namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer earl = new Customer("Earl");
            Customer frankTheTank = new Customer("FrankTheTank", "Mainstreet 1", "000000");
            Console.WriteLine("Name of Customer is " + earl.Name);
            // Default Cutomer
            Customer myCustomer = new Customer();
            Console.WriteLine("Please enter the customer's name: ");
            myCustomer.Name = Console.ReadLine();
            Console.WriteLine("Details about customer: " + myCustomer.Name);
            Console.ReadKey();
        }
    }

}
