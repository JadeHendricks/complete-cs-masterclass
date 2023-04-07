using System;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ticket t1 = new Ticket(10);
            Ticket t2 = new Ticket(10);

            //we are using a IEquatable interface here that allows us to compare objects
            //if they have the same values, usually this will always be false because of referencing.
            Console.WriteLine(t2.Equals(t1));

            Console.WriteLine("********************************");

            //Creating two objects of type chair
            Chair officeChair = new Chair("Brown", "Plastic");
            Chair gamingChair = new Chair("Red", "Wood");

            //Creating a new object of the type Car
            Car damagedCar = new Car(80f, "Blue");

            //add the two chairs to the IDestroyable list of the car so that when we destroy the car the destroyable objects
            //that are near the car will get destroyed aswell
            //the reason we can add chairs to our DestroyablesNearby list is because the cahir implements the same interface IDestryable
            //which means that a chair is now going to be accepted as an object of IDestryable
            damagedCar.DestroyablesNearby.Add(officeChair);
            damagedCar.DestroyablesNearby.Add(gamingChair);

            //destroy the car
            damagedCar.Destroy();

        }
    }
}
