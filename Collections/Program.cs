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
            MultiDimensionalArrayExample();
            NestedForLoopsAnd2DArrays();
            JaggedArraysExample();

            int[] studentsGrades = new int[] { 15, 13, 12, 8, 6 };
            double averageResult = ArraysAsParamsExample(studentsGrades);

            Console.WriteLine($"The average result of the grades are {averageResult}");
            Console.WriteLine("*****************************************************");

            //challenge - ArraysAsParamsExampleChallenge
            int[] happinessArray = new int[] { 1, 2, 3, 4, 5 };
            ArraysAsParamsExampleChallenge(happinessArray);

            ParamsKeywordExample(); //this will continue to run even though our method is looking for an array - params
            ParamsKeywordExample("hello", "my", "name", "is", "Jeff"); //this will work too, the param allows 0 or unlimited params.


            int min = RealWorldExampleWithParams(6,4,5,7,8,0,1,5);
            int min2 = RealWorldExampleWithParams(-11, 4, 5, 7, 8, 0, 1, 5);
            Console.WriteLine("The minimum is :{0} ", min);
            Console.WriteLine("The minimum is :{0} ", min2);
            Console.WriteLine("*****************************************************");


            Console.Read();
        }

        public static void ForArraysExample()
        {
            int[] nums = new int[5];

            for(int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
                Console.WriteLine("FOR LOOP - Element{0} = {1}", i, nums[i]);
            }

            Console.WriteLine("*****************************************************");
        }

        public static void ForEachArraysExample()
        {
            int[] nums = { 1,2,3,4,5 };
            int counter = 0;

            foreach(int i in nums)
            {
                Console.WriteLine("FOREACH LOOP - Element{0} = {1}", counter, i);
                counter++;
            }

            Console.WriteLine("*****************************************************");
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
    
        //multi-dimensional arrays
        public static void MultiDimensionalArrayExample()
        {
            //declaring a 2d array
            string[,] matrix;

            //declaring a 3d array
            int[,,] threeD;

            //two dimensional array
            int[,] array2D = new int[,]
            {
                { 1,2,3 },  //row 1
                { 4,5,6 },  //row 2
                { 7,8,9 }   //row 3
            };

            Console.WriteLine("*****************************************************");

            Console.WriteLine("Centeral value inside of the 2d array is {0}", array2D[1,1]); //in the first row I want position 1 (starts at 0 index)

            Console.WriteLine("*****************************************************");

            Console.WriteLine("The 7th value is {0}", array2D[2,0]);

            Console.WriteLine("*****************************************************");

            //three dimensional array
            string[,,] array3D = new string[,,]
            {
                {
                    { "000", "001" },
                    { "010", "011" }
                },
                {
                    { "100", "101" },
                    { "110", "111" }
                }
            };

            Console.WriteLine("The 4th value is {0}", array3D[0, 1, 0]); //first nested array, 2nd row, first value

            Console.WriteLine("*****************************************************");

            //another way of initialzing a 2d array
            //3 rows and 2 entries per row
            string[,] array2DString = new string[3, 2]
            { 
                { "one", "two" },
                { "three", "four" },
                { "five", "six" },
            };

            array2DString[1, 1] = "chicken";

            Console.WriteLine("This should output 'chicken' = {0}", array2DString[1,1]);

            Console.WriteLine("*****************************************************");

            //finding out how many dimensions and array has
            int dimensions = array2DString.Rank; //rank gets the number of dimensions of an array
            Console.WriteLine("array2DString has {0} dimensions", dimensions);

            Console.WriteLine("*****************************************************");

            //creating a multidimension array without add it's rank
            int[,] array2D2 = { 
                { 1, 2 }, 
                { 3, 4 } 
            };

            Console.WriteLine("array2D2 - this should give me 3 - {0}", array2D2[1, 0]);

            Console.WriteLine("*****************************************************");
        }

        //have to make it static as you cannot use a non static item in a static method
        static int[,] matrix =
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        public static void NestedForLoopsAnd2DArrays()
        {
            //goes through all the times in the array
            foreach (int item in matrix)
            {
                Console.WriteLine("foreach - " + item + " ");
            }

            Console.WriteLine("*****************************************************");

            Console.WriteLine("This is our 2D array printed using the nested for loop");

            //getLength is used to get the dimension of the array you want to itterate over
            //same thing as forEach loop, but now we have access to all the values and can use/change them on the fly
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.WriteLine("nestedFor - " + matrix[i,j] + " ");
                }
            }

            Console.WriteLine("*****************************************************");

            //challenge - only print out the odd numbers
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] % 2 != 0)
                    {
                        Console.WriteLine("nestedForChallenge - " + matrix[i, j] + " ");
                    }
                }
            }

            Console.WriteLine("*****************************************************");
        }
    
        public static void JaggedArraysExample()
        {
            //basically an array in an array
            //could be multiple arrays in one array
            //in this case we are saying we want 3 arrays inside of the jagged array
            int[][] jaggedArray = new int[3][];

            jaggedArray[0] = new int[5];
            jaggedArray[1] = new int[3];
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1,2,3,4,5 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 1, 2 };

            //alternative way of creating the same thing
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 1, 2, 4, 5, 6 }
            };

            Console.WriteLine("JaggedArraysExample - this should be 4 : {0}", jaggedArray2[0][3]);
            Console.WriteLine("JaggedArraysExample - this should be 6 : {0}", jaggedArray2[1][4]);

            Console.WriteLine("*****************************************************");

            //challenge - get all the values from the jagged array on the console
            for(int i = 0; i < jaggedArray2.Length; i++)
            {
                Console.WriteLine("challege = Element {0}", i);
                Console.WriteLine("*****************************************************");
                for (int j = 0; j < jaggedArray2[i].Length; j++)
                {
                    Console.WriteLine("challege = Value {0}", jaggedArray2[i][j]);
                }
            }

            Console.WriteLine("*****************************************************");

            //challenge 2 - introduce someone from one family to another family
            string[][] friendsAndFamilyArray = new string[][]
            {
                new string[] { "james", "jimmy" },
                new string[] { "stacy", "carline" },
                new string[] {"john", "austin" }
            };

            Console.WriteLine("Hi {0}, I would like to introduce {1} to you", friendsAndFamilyArray[0][0], friendsAndFamilyArray[1][0]);
            Console.WriteLine("Hi {0}, I would like to introduce {1} to you", friendsAndFamilyArray[1][1], friendsAndFamilyArray[2][1]);
            Console.WriteLine("*****************************************************");

        }
    
        public static double ArraysAsParamsExample(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }

            average = (double)sum / size;
            return average;
        }
    
        //challenge
        //add +2 to each item in the aray that is passed into the method
        public static void ArraysAsParamsExampleChallenge(int[] x)
        {
            for(int i = 0; i < x.Length; i++)
            {
                x[i] += 2;
                Console.WriteLine("ArraysAsParamsExampleChallenge " + x[i]);
            }
            Console.WriteLine("*****************************************************");
        }

        //the param keyword allows 0 or unlimited params to be passed down without crashing.
        public static void ParamsKeywordExample(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                Console.Write(sentence[i] + " ");
            }
            Console.WriteLine("*****************************************************");
        }

        //get the lowest number from the params passed
        public static int RealWorldExampleWithParams(params int[] numbers)
        {
            //checking to make sure the number is within bounds
            int min = int.MaxValue;

            foreach (int number in numbers)
            {
                //if number is less than 2147483647
                //setting the min to the lowest number until we get the lowest number set to min to return
                if (number < min)
                {
                    min = number;
                }

                
            }
            return min;
        }
        
    }
}
