using System;
using System.Diagnostics.Tracing;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ForLoopExample();
            ForLoopExample();
            DoWhileLoopExample();
            WhileLoopExample();
            BreakExample();
            ContinueExample();
            Console.Read();
        }

        public static void ForLoopExample()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Hello there {0}", i);
            }
            Console.WriteLine("*********************");

            for (int i = 0; i <= 25; i+=5)
            {
                Console.WriteLine("Hello there part 2 {0}", i);
            }
            Console.WriteLine("*********************");

            //only print out the odd numbers
            for (int i = 1; i < 20; i += 2)
            {
                Console.WriteLine("Here are the odd numbers you are looking for {0}", i);
            }
            Console.WriteLine("*********************");
        }
        
        //this will always run atleast one time.
        public static void DoWhileLoopExample()
        {
            int counter = 15;
            int lengthOfText = 0;
            string wholeText = "";
            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter < 5);

            do
            {
                Console.WriteLine("Please enter a name of a friend:");
                string nameOfAFriend = Console.ReadLine();
                int currentLength = nameOfAFriend.Length;
                lengthOfText += currentLength;
                wholeText += nameOfAFriend;
            } while (lengthOfText < 20);
            Console.WriteLine("Thanks that was enough the names entered are {0} and the total length is {1}", wholeText, lengthOfText);
        }
    
        public static void WhileLoopExample()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine("We are in the while loop! {0}", counter);
                counter++;
            }
            Console.WriteLine("*********************");
        }
    
        public static void BreakExample()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("We are inside break loop {0}", i);
                if (i == 3)
                {
                    Console.WriteLine("At 3 we stop!");
                    break;
                }
            }
        }

        public static void ContinueExample()
        {
            for (int i = 0; i < 10; i++)
            {
                //this will skip the number that is divisible by 2
                if (i % 2 == 0)
                {
                    Console.WriteLine("Even number has been skipped!");
                    continue;
                }

                Console.WriteLine(i);
            }
        }
    }
}
