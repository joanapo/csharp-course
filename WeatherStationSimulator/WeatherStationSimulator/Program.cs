namespace WeatherStationSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate: ");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = { "Sunny", "Rainy", "Cloudy", "Snowy" };
            string[] weatherConditions = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                weatherConditions[i] = conditions[random.Next(conditions.Length)];
            }

            double averageTemp = CalculateAverage(temperature);
            Console.WriteLine($"The average temperature is {averageTemp}.");
            Console.WriteLine($"The mininum temperature is {MinTemperature(temperature)}.");
            Console.WriteLine($"The maximum temperature is {temperature.Max()}.");
            Console.WriteLine($"The most common condition is {MostCommonCondition(conditions)}.");
            
            Console.ReadKey();
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0;i < conditions.Length; i++)
            {
                int tempCount = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i])
                    {
                        tempCount++;
                    }
                }
                if (tempCount > count)
                {
                    mostCommon = conditions[i];
                }
            }
            return mostCommon;
        }
        
        static double CalculateAverage(int[] temperature)
        {
            double sum = 0;

            foreach (int value in temperature)
            {
                sum += value;
            }

            double average = sum / temperature.Length;
            return average;

        }

        static int MinTemperature(int[] temperature)
        {
            int min = temperature[0];
            foreach (int value in temperature)
            {
                if (value < min)
                {
                    min = value;
                }
            }
            return min;
        }
    }
}
