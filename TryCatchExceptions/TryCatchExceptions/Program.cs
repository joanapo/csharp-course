namespace TryCatchExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = 0;
            try
            {
                Console.WriteLine("Please enter a number");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = 2;
                result = num1 / num2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message); 
            }
            finally
            {
                Console.WriteLine("This always executes.");
            }

            Console.WriteLine("The result is " + result);
            Console.ReadKey();
            
        }
    }
}
