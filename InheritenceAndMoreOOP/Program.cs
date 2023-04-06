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
        }
    }
}