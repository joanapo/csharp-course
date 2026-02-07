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
            private Hammer _hammer;
            private Saw _saw;

            public Builder(Hammer hammer, Saw saw)
            {
                _hammer = hammer; // constructor dependency injection
                _saw = saw;
            }

            public void BuildHouse()
            {
                _hammer.Use();
                _saw.Use();
                Console.WriteLine("House built!");
            }
        }

        static void Main(string[] args)
        {
            Hammer hammer = new Hammer();
            Saw saw = new Saw();
            Builder builder = new Builder(hammer, saw);

            builder.BuildHouse();

            
            Console.ReadKey();
        }
    }
}
