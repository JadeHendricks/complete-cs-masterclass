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
            Box box = new Box(3,4,5);
            //changing the length of the box with a setter
            box.SetLength(5);
            //setting this value with Height = get/set
            box.Height = 4;
            box.Width = 6; //public int Width { get; set; }

            //getting the values with a getter
            Console.WriteLine("Box length is " + box.GetLength());
            Console.WriteLine("Box volume is " + box.GetVolume());
            Console.WriteLine("Box width is " + box.Width);

            box.DisplayInfo();

            //Members
            Members member1 = new Members();
            member1.Introducing(true);

            Console.Read();
        }
    }
}
