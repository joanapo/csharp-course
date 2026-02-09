namespace DelegatesAndEventsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = {1, 2, 3};
            string[] stringArray = { "One", "Two", "Three" };

            PrintArray(intArray);
            PrintArray(stringArray);
            
            Console.ReadKey();
        }

        public static void PrintIntArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i); 
            }
        }

        public static void PrintStringArray(string[] array)
        {
            foreach(string s in array)
            {
                Console.WriteLine(s);
            }
        }

        
        // a generic method that accepts a generic datatyoe
        public static void PrintArray<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.WriteLine(item);
            }
        }

    }
}
