namespace ListsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> colors = new List<string>();

            colors.Add("red");
            colors.Add("blue");
            colors.Add("green");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            colors.Remove("red");

            foreach (string color in colors)
            {
                Console.WriteLine(color);
            }

            Console.ReadLine();
        }
    }
}
