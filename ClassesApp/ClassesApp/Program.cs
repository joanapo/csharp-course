namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myAudi = new Car("Audi", "A3", false);
            myAudi.Drive();

            Car myBMW = new Car("BMW", "i7", true);
            myBMW.Drive();

            Console.ReadKey();
        }
    }

}
