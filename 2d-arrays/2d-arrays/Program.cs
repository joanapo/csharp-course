namespace _2d_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int sum = 0;

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    sum += numbers[i, j]; 
                }
                Console.WriteLine(sum);
                sum = 0;
            }

            Console.ReadKey();
        }
    }
}
