using System;
using System.Collections.Generic;

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

            Console.WriteLine("****************************************");

            BMW bmwM5 = new BMW(300, "black", "M5");
            bmwM5.ShowDetails();

            Console.WriteLine("****************************************");

            //forcing the bmw to use the Car Method
            Car carB = (Car)bmwM5;
            carB.ShowDetails();
        }
    }
}
