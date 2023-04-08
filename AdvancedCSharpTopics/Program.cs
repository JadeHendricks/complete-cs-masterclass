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
                Console.WriteLine("********************************************");
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
            NullableExample();
        }

        public static void EnumsExample()
        {
            Day fr = Day.Fr;
            Day su = Day.Su;

            Day a = Day.Fr;

            Console.WriteLine(fr == a);
            Console.WriteLine((int)Day.Mo); //0 is the first in the enum value wise
            Console.WriteLine((int)Month.Feb);
            Console.WriteLine("********************************************");
        }

        //allows a value to have a value or to not have a value without complaining about assigning a value to it
        //allows the values to be set to a default value
        public static void NullableExample()
        {
            int? num1 = null;
            int? num2 = 1337;

            double? num3 = new Double?();
            double? num4 = 3.14157;

            bool? boolValue = new bool?();

            bool? isMale = new bool?();

            if (isMale == true)
            {
                Console.WriteLine("User is Male");
            }
            else if (isMale == false)
            {
                Console.WriteLine("User is female");
            } else
            {
                Console.WriteLine("No Gender chosen");
            }

            //The Null coalescing operator
            //if the number is null take the number given else use the number that was assigned to it
            double num8 = num3 ?? 8.21;
            double num9 = num4 ?? 8.21;

            Console.WriteLine("Our nullable numbers are: {0},{1},{2},{3}", num1, num2, num3, num4);
            Console.WriteLine("The nullable boolean value is {0}", boolValue);
            Console.WriteLine("Value of num8 : {0}", num8);
            Console.WriteLine("Value of num8 : {0}", num9);
            Console.WriteLine("********************************************");
        }
    }
}
