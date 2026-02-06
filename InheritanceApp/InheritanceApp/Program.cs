using System.Threading.Channels;

namespace InheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.MakeSound();
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

        public virtual void MakeSound()
        {
            Console.WriteLine("Generic sound");
        }
    }

    // single class inheritance
    class Dog: Animal
    {
        public override void MakeSound()
        {
            base.MakeSound();
            Console.WriteLine("Woof");
        }

  
    }

    // hierarchical inheritance
    class Cat: Animal
    {
       public override void MakeSound()
        {
            Console.WriteLine("Meow");
        }
    }
    
    // multilevel inheritance
    class Collie: Dog
    {
        public virtual void GoNuts()
        {
            Console.WriteLine("Collie going nuts!!");
        }
    }
}
