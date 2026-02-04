namespace Nullables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? age = null;

            if (age.HasValue)
            {
                Console.WriteLine("Age is " + age);
            }
            else
            {
                Console.WriteLine("Age is not specified.");
            }

                Console.ReadKey();
        }
    }
}
