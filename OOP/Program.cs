using System;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //an instance of Human
            //aka creating an object from a classes blueprint
            Human denis = new Human();

            //access public variable from outside
            denis.firstName = "Denis";
            //call methods on the instance
            denis.IntroduceMySelf();

            Human micheal = new Human();
            micheal.IntroduceMySelf();

            Console.Read();
        }
    }
}
