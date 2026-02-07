namespace DependencyInjectionApp
{
    internal class Program
    {
        public class Hammer
        {
            public void Use()
            {
                Console.WriteLine("Hammering Nails!");
            }
        }

        public class Saw
        {
            public void Use()
            {
                Console.WriteLine("Sawing wood");
            }
        }
        
        public class Builder
        {
            public Hammer Hammer {  get; set; }
            public Saw Saw { get; set; }

            public void BuildHouse()
            {
                Hammer.Use();
                Saw.Use();
                Console.WriteLine("House built!");
            }
        }

        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder();
            builder.Hammer = hammer;
            builder.Saw = saw;

            builder.BuildHouse();

            
            Console.ReadKey();
        }
    }
}
