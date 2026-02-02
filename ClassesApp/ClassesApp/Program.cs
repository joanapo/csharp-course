namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("Audi", "A3", false);
            Car bmw = new Car("BMW", "i7", true);
            
            Console.WriteLine("Brand is " + audi.Brand);
            Console.WriteLine("Brand is " + bmw.Brand);

            Console.ReadKey();
        }
    }

}
