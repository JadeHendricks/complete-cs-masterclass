using System;

namespace Hello_World
{
    internal class Program
    {
        //entry point of our program
        static void Main(string[] args)
        {
            //changing the console colours
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.BackgroundColor = ConsoleColor.DarkGreen;

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

            Console.Read();

        }
    } 
}
