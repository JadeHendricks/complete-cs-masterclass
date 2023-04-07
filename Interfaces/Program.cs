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

            Console.WriteLine("********************************");

            IEnumeratorAndIEnumerable();

        }

        /// <summary>
        /// IEnumerable<T> contains a single method that you must implement when implementing this interface
        /// GetEnumerator(), which returns an IEnumerator<T> Object
        /// The returned IEnumerator<T> provides the ability to iterate through the collection
        /// by exposing a current property that points at the object we are currrntly at in the collection
        /// </summary>
        /// 
       
        /// when is it recommended to use the IEnumerable interface:
        /// - your collection represetns a mssive database table, you don't want to copy the entire thing into emmory and cause performance issues in your app
        /// when is it not recommended to use the IEnumerable interface:
        /// - When you need the results right away and are possible mutating/editing the objects later on.
        /// - In this case, it is better to use an array or a list instead.

        public static void IEnumeratorAndIEnumerable()
        {
            //the IEnumerable interface is the base interface for many collections in C#
            //it's job is to provide a way to iterate through a collection
            //this is why we can use loops to loop through lists or dictionaries, because these loops inherit from the IEnumerable interface 
            //there are 2 types of IEnumerables - 1) generic<T> - 2) non generic collections (which is not recommended if you can help it)

            DogShelter shelter = new DogShelter();
            foreach (Dog dog in shelter)
            {
                if (!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                } else
                {
                    dog.GiveTreat(1);
                }
            }

        }
    }
}
