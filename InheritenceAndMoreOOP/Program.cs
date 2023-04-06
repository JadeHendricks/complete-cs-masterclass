using System;

namespace InheritenceAndMoreOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            Console.WriteLine("******************************");

            TV myTV = new TV(false, "LG");
            myTV.WatchTV();

            Console.WriteLine("******************************");

            Dog dog = new Dog("Chuckie", 13, false);
            Console.WriteLine($"{dog.Name} is {dog.Age} years old");
            dog.MakeSound();
            dog.Play();
            dog.Eat();

            Console.WriteLine("******************************");

            Post post1 = new Post("Thanks everyone for the birthday wishes", true, "Jade Hendricks");
            Console.WriteLine(post1.ToString());

            Console.WriteLine("******************************");

            ImagePost imagePost1 = new ImagePost("Check out my new shoes", "Jade Hendricks", "https://images.com/shoes", true);
            Console.WriteLine(imagePost1.ToString());

        }
    }
}