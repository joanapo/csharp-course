namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>{10, 5, 15, 3, 9, 25, 18};

            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            bool hasLargeNumber = numbers.Any(x => x > 20);
            
            Predicate<int> isGreaterThanTen = x => x > 10;
            
            List<int> higherTen = numbers.FindAll(isGreaterThanTen);

            Console.WriteLine("Number 10 and higher in our list:");
            foreach (int number in higherTen)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
