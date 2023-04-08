using System;

namespace AdvancedCSharpTopics
{
    internal class Program
    {
        //structs are value types and need to contain a value
        //structs cannot contain default constructors (parameterless)
        //it can implement interfaces
        //they do not support inheritence
        //structs cannont be Abstract, Virtual or Protected
        struct Game
        {
            public string name;
            public string developer;
            public double rating;
            public string releaseDate;

            public void Display() 
            {
                Console.WriteLine("Game 1's name is : {0}", name);
                Console.WriteLine("Game 1 was developed by : {0}", developer);
                Console.WriteLine("Game 1's rating is : {0}", rating);
                Console.WriteLine("Game 1 was released in : {0}", releaseDate);
            }
        }

        //basically a list of constants
        //need to be put in the namespace level so that it's more accessbile
        enum Day { Mo, Tu, We, Th, Fr, Sa, Su };
        //this enum will start at value 1 and when we get to 12 it will continue from 12
        enum Month { Jan = 1, Feb, Mar, Apr, May, Jun, Jul = 12, Aug, Sep, Oct, Nov, Dec };

        static void Main(string[] args)
        {
            Game game1;
            game1.name = "Pokemon Go";
            game1.developer = "Niatic";
            game1.rating = 3.5;
            game1.releaseDate = "01.07.2016";

            game1.Display();

            //enums
            EnumsExample();
        }

        public static void EnumsExample()
        {
            Day fr = Day.Fr;
            Day su = Day.Su;

            Day a = Day.Fr;

            Console.WriteLine(fr == a);
            Console.WriteLine((int)Day.Mo); //0 is the first in the enum value wise
            Console.WriteLine((int)Month.Feb);
        }
    }
}
