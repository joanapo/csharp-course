namespace DelegatesApp
{
    // 1. Declaration:
    public delegate void Notify(string message);
    internal class Program
    {
        static void Main(string[] args)
        {
            // 2. Instantiation:
            Notify notifyDelegate = ShowMessage;

            // 3. Invocation
            notifyDelegate("Hello, Delegates!");
            
            
            Console.ReadKey();
        }

        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
