namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer myCustomer = new Customer();

            myCustomer.SetDetails("Frank", "Mainstreet 2", "222222");
            Console.WriteLine("Details about customer: " + myCustomer.Name);

            Console.ReadKey();
        }
    }

}
