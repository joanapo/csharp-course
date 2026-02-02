namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.SetDetails("Frank", "Mainstreet 2");
            Console.WriteLine("Details about customer: " + customer.ContactNumber);

            Console.ReadKey();
        }
    }

}
