using System;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int array
            int[] grades = new int[5];
            grades[0] = 20;
            grades[1] = 10;
            grades[2] = 15;
            grades[3] = 33;
            grades[4] = 1;

            Console.WriteLine("grades at index 0 : {0}", grades[0]);
            string input = Console.ReadLine();

            //assign value to array at index 0
            grades[0] = int.Parse(input);

            Console.WriteLine("grades at index 0 after user input is now : {0}", grades[0]);

            //another way of initializing an array
            int[] gradesOfMathStudentsA = { 20, 13, 12, 8, 8 };

            //another way of initializing an array
            int[] gradesOfMathStudentsB = new int[] { 20, 13, 12, 8, 8 };

            //getting the length of an array
            Console.WriteLine("The length of the gradesOfMathStudentsA array is {0}", gradesOfMathStudentsA.Length);


            //calling methods
            ForArraysExample();
            ForEachArraysExample();
            Challenge();

            Console.Read();
        }

        public static void ForArraysExample()
        {
            int[] nums = new int[10];

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
                Console.WriteLine("FOR LOOP - Element{0} = {1}", i, nums[i]);
            }
        }

        public static void ForEachArraysExample()
        {
            int[] nums = { 1,2,3,4,5,6,7,8,9,10 };
            int counter = 0;

            foreach(int i in nums)
            {
                Console.WriteLine("FOREACH LOOP - Element{0} = {1}", counter, i);
                counter++;
            }
        }

        //course challenge
        public static void Challenge()
        {
            string[] fiveFriends = { "James", "Johnny", "Stacy", "Lucy", "Eric" };

            foreach(string friend in fiveFriends)
            {
                Console.WriteLine("Hey {0} how are you?", friend);
            }
        }
    }
}
