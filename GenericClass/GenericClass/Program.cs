namespace GenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger();

            logger.Log<int>(10);
            logger.Log("Hello World");
        }
    }
}
