using System.Threading.Channels;

namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Bark();
            myDog.Eat();

            Console.ReadLine();
        }
    }

    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    // single class inheritance
    class Dog: Animal
    {
        public void Bark()
        {
            Console.WriteLine("Woof");
        }
    }

    // hierarchical inheritance
    class Cat: Animal
    {
       public void Meow()
        {
            Console.WriteLine("Meow");
        }
    }
    
    // multilevel inheritance
    class Collie: Dog
    {
        public void GoingNuts()
        {
            Console.WriteLine("Collie going nuts!!");
        }
    }
}
