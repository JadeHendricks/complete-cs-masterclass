using System;

namespace Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5; 
            int num2 = 3; 
            int num3;

            //unary operator
            num3 = -num1;
            Console.WriteLine("num3 is {0}", num3); //-5 in this case (multiplies it with -1)

            bool isSunny = false;
            Console.WriteLine("is it sunny? {0}", !isSunny); //negating the values

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is now {0}", num++); //post increment this will only work in the next line, if you want to have it work immediately you do (++num)
            Console.WriteLine("num is now {0}", ++num); //pre increment

            //decrement operator (oposite of the above)
            num--;
            Console.WriteLine("num is now {0}", num);

            //relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("Result of num1 < num2 is {0}", isLower);

            //equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("Result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("Result of num1 != num2 is {0}", isEqual);

            //conditional operators
            bool isLowerAndSunny;
            isLowerAndSunny = isLower && isSunny;
            Console.WriteLine("Result of isLower && isSunny is {0}", isLowerAndSunny); //checking if they are both true
            isLowerAndSunny = !isLower && !isSunny;
            Console.WriteLine("Result of !isLower && !isSunny is {0}", isLowerAndSunny); //checking if they are both false

            isLowerAndSunny = isLower || isSunny;
            Console.WriteLine("Result of isLower || isSunny is {0}", isLowerAndSunny); //checking if atleast one of them are true

            Console.Read();
        }
    }
}
