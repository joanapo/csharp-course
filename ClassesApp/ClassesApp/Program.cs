namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer earl = new Customer("Earl");

            Console.WriteLine("Name of Customer is " + earl.Name);

            Console.ReadKey();
        }
    }

}
