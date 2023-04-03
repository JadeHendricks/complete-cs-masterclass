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

            //using the default constructor
            Human joe = new Human("Joe", "Rogan", "Green");

            //call methods on the instance
            denis.IntroduceMySelf();
            micheal.IntroduceMySelf();
            joe.IntroduceMySelf();

            //properties
            Box box = new Box();
            //changing the length of the box with a setter
            box.SetLength(5);
            box.height = 4;
            box.width = 5;

            //getting the values with a getter
            Console.WriteLine("Box length is " + box.GetLength());
            Console.WriteLine("Box volume is " + box.GetVolume());

            box.DisplayInfo();

            Console.Read();
        }
    }
}
