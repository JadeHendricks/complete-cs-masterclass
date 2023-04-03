using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //an instance of Human
            //aka creating an object from a classes blueprint
            Human denis = new Human("Denis", "Freedman", "brown", 55);
            Human micheal = new Human("Michael", "Johnson", "blue", 1);

            //call methods on the instance
            denis.IntroduceMySelf();
            micheal.IntroduceMySelf();

            Console.Read();
        }
    }
}
