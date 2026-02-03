namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>
            {
                10, 5, 15, 3, 9
            };

            numbers.Sort();
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.ReadLine();
        }
    }
}
