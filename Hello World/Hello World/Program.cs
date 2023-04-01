using System;

namespace Hello_World
{
    internal class Program
    {
        //constants as fields
        const double PI = 3.14159265359;
        const int weeks = 52, months = 12;
        const int days = 365;
        const string name111 = "Jimmy";

        //create a constant of type string with your birthday as its value
        const string birthday = "13 May 1993";

        //entry point of our program
        static void Main(string[] args)
        {
            //changing the console colours
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("test " + name111.Length);
            //Method Calling
            WriteSomething();
            WriteSomethingSpecific("This is coming from a parameter passed to a method");
            Console.WriteLine(Add(Add(1, 4), Add(5, 10)));
            Console.WriteLine(Add(1, 4));
            Console.WriteLine(Multiply(2, 5));
            Console.WriteLine(Calculate());

            Console.WriteLine("Hello World!");
            // declaring a variable
            int num1;

            //assigning and init a variable in one go
            num1 = 13;
            int num2 = 23;
            int sum = num1 + num2;

            Console.WriteLine(num1);

            //using concatination
            Console.WriteLine("num1 " + num1 + " + num2 " + num2 + " is " + sum);

            //declaring multiple variables at once
            int num3, num4, num5;

            //using doubles
            //if you need high precision use doubles
            //a precision sort of data type that is capable of holding 64 bits of decimal numbers or floating points
            double d1 = 3.1415;
            double d2 = 5.1;
            double dDivistion = d1 / d2;
            Console.WriteLine("d1/ d2 = " + dDivistion);

            //using floats (f)
            //if you need low precision use floats. Less memory is used (not that important - see console)
            //Float is a shortened term for "floating point." By definition, it's a fundamental data type built into the compiler that's used to define numeric values with floating decimal points
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDivision = f1 / f2;
            Console.WriteLine("f1/ f2 = " + fDivision);

            //using strings and methods on strings
            string myName = "Jade";
            string myLastName = "Hendricks";
            string fullName = ("My name is " + myName.ToLower() + " " + myLastName.ToUpper());

            Console.WriteLine(fullName);

            //Conversion
            //Explicit Conversion
            double myDouble = 13.37;
            int myInt;

            //casting double to int
            //aka please make a int out of a double i.e 13
            myInt = (int)myDouble;
            Console.WriteLine(myInt);

            //Implicit Conversion
            //storing smaller values into bigger data types
            int myInt2 = 11684164;
            long bigNumber = myInt2;
            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            //Type Conversion
            string myString = myDouble.ToString(); // "13.37"
            string myString2 = myFloat.ToString();
            bool sunIsShining = false;
            string myString3 = sunIsShining.ToString();
            Console.WriteLine(myString + " " + myString2 + " " + myString3);

            //parsing a string to a integer
            string myString4 = "15";
            string myString5 = "13";
            //Double.Parse();
            int number1 = Int32.Parse(myString4);
            int number2 = Int32.Parse(myString5);
            string result1 = myString4 + myString5;
            int result2 = number1 + number2;

            Console.WriteLine(result1);
            Console.WriteLine(result2);

            //String Manipulation
            int age = 29;
            string name = "Jade";

            //string formatting
            //string formatting uses indexing
            Console.WriteLine("Hell my name is {0}, I am {1} years old", name, age);

            //string interpolation
            Console.WriteLine($"Hello my name is {name}, I am a {age} years old.");

            //verbatim strings
            //if you remove the @ here you will get an error because \a\u\d are not valid escape characters
            Console.WriteLine(@"C:\User\Admin\Dog Pictures\Dog1\Super Cool Dog.png");
            Console.WriteLine(@"Muhahaha \n you have no powers here");
            //for example
            Console.WriteLine("Muhahaha \n you have powers here");


            //challenege 1
            string randomString;
            Console.WriteLine("Please enter your name and press enter");
            randomString = Console.ReadLine();
            Console.WriteLine("To upper string " + randomString.ToUpper());
            Console.WriteLine("To lower string " + randomString.ToLower());
            Console.WriteLine("Trimmed string " + randomString.Trim());

            //challenge 2
            string randomString2;
            char characterToSearchFor;
            int getIndex;
            string namex;
            string lastNamex;
            string fullNamex;
            Console.WriteLine("Enter a string here:");
            randomString2 = Console.ReadLine();
            Console.WriteLine("Enter the character to search:");
            characterToSearchFor = Console.ReadLine()[0];
            getIndex = randomString2.IndexOf(characterToSearchFor);
            Console.WriteLine($"The index of {characterToSearchFor} inside of the text is {getIndex}");

            Console.WriteLine("Now enter in your first name:");
            namex = Console.ReadLine();
            Console.WriteLine("Now enter in your last name:");
            lastNamex = Console.ReadLine();

            fullNamex = string.Concat(namex, " ", lastNamex);
            Console.WriteLine($"Your name is {fullNamex}");

            //constants
            Console.WriteLine($"My birthday is always going to be: {0}", birthday);



            //getting user input
            string input = Console.ReadLine();
            Console.WriteLine(input);

            Console.Read();

        }

        public static void WriteSomething()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Calculate()
        {
            Console.WriteLine("Please Enter the first number");
            string userInput1 = Console.ReadLine();

            Console.WriteLine("Please Enter the second number");
            string userInput2 = Console.ReadLine();

            int num1 = int.Parse(userInput1);
            int num2 = int.Parse(userInput2);

            return num1 + num2;
        }
    } 
}
