using System.Text.RegularExpressions;

namespace RegExApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\d";
            Regex regex = new Regex(pattern);

            string text = "Hi there, my number is 12314";

            MatchCollection matches = regex.Matches(text);

            Console.WriteLine("{0} hits found", matches.Count);

            foreach (Match match in matches)
            {
                GroupCollection group = match.Groups;
                Console.WriteLine("{0} found at {1}", group[0].Value, group[0].Index);
            }
            
            Console.ReadKey();
        }
    }
}
