namespace GenericClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> boxStr = new Box<string>("Hello World");
            boxStr.UpdateContent("C# is fun!");
            Console.WriteLine(boxStr.GetContent());
        }
    }
}
