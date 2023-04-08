using System;
using System.Collections.Generic;
using System.IO;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is a list of cars and we can create Audis and BMWs in it
            //so the reasons for this is called Polymorphism, when you can use the child class to replace the base class
            //Polymorphism at work #1: An audi and BMW, Porsche can all be used wherever a Car is expected. No cast is required
            //this is because an implicit conversion exists from a derived class to its base class
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            // Polymorphism at work #2 the virutal repair method repair is invoked on each of the derived classes, not the base class
            foreach (var car in cars)
            {
                car.Repair();
            }

            Console.WriteLine("****************************************");

            Car bmwZ3 = new BMW(270, "white", "Z3");
            Car audiA3 = new Audi(220, "grey", "A3");

            //this will call the ShowDetails() inside of the base class
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();

            bmwZ3.SetCarIdInfo(1234, "Jade Hendricks");
            audiA3.SetCarIdInfo(5562, "Jason Statham");

            bmwZ3.GetCarIdInfo();
            audiA3.GetCarIdInfo();

            Console.WriteLine("****************************************");

            BMW bmwM5 = new BMW(300, "black", "M5");
            bmwM5.ShowDetails();

            Console.WriteLine("****************************************");

            //forcing the bmw to use the Car Method
            Car carB = (Car)bmwM5;
            carB.ShowDetails();

            Console.WriteLine("****************************************");

            //Abstract classes
            AbstractClassesExample();
            ReadFromTextFile();
            WriteTextToFile();
        }

        public static void AbstractClassesExample()
        {
            Shape[] shapes =
            {
                new Sphere(4),
                new Cube(3)
            };

            foreach (Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0} has a volume of {1}", shape.Name, shape.Volume());

                //we use the as keyword here in order to create a variable as a certain type
                //and if the loop sees it as a cube it will not be null
                Cube iceCube = shape as Cube;

                if (iceCube == null)
                {
                    Console.WriteLine("This shape is no cube");
                }

                //we use is here to check if a variable is of a certain type
                if (shape is Cube)
                {
                    Console.WriteLine("This shape is a cube");
                }

                //casting from an object to a cube
                //this only works if the object actaully contains a Cube
                object cube1 = new Cube(7);
                //I want to create a new cube called cube 2
                //and I want to cast cube1 into a cube
                //this will only work if cube1 is actually a cube
                Cube cube2 = (Cube)cube1;

                Console.WriteLine("{0} has a volume of {1}", cube2.Name, cube2.Volume());

            }
            Console.WriteLine("****************************************");
        }

        public static void ReadFromTextFile()
        {
            //IO = Input Output
            //example 1 - reading text
            string text = System.IO.File.ReadAllText(@"C:\Users\hendr\Desktop\repos\complete-cs-masterclass\notes\textfile.txt");
            Console.WriteLine("Textfile contains the following text: {0}", text);

            //example 2 - reading text per line
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\hendr\Desktop\repos\complete-cs-masterclass\notes\textfile.txt");
            Console.WriteLine("Contents of textfile.txt = ");
            foreach (string line in lines)
            {
                Console.WriteLine("\t" + line);
            }

            Console.WriteLine("****************************************");
        }

        public static void WriteTextToFile()
        {
            //example 1
            string[] lines = { "First 250", "Second 242", "Third 240" };
            File.WriteAllLines(@"C:\Users\hendr\Desktop\repos\complete-cs-masterclass\notes\highscores.txt", lines);

            //example 2
            Console.WriteLine("Please give the file a name:");
            string fileName = Console.ReadLine();
            Console.WriteLine("Please enter the text for the file.");
            string input = Console.ReadLine();
            File.WriteAllText(@"C:\Users\hendr\Desktop\repos\complete-cs-masterclass\notes\" + fileName + ".txt", input);

            //example 3
            using(StreamWriter file = new StreamWriter(@"C:\Users\hendr\Desktop\repos\complete-cs-masterclass\notes\thirdOnlyTextFile.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("Third"))
                    {
                        file.WriteLine(line);
                    }
                }
            }
        }
    }
}
