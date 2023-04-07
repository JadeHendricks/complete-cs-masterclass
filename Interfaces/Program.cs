using System;
using System.Collections.Generic;

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

            Console.WriteLine("********************************");

            IEnumerable<int> unkownCollection;
            unkownCollection = IEnumeratorAndIEnumerableExample1(1);
            Console.WriteLine("This is a List<int>");
            //foreach number in the collection we got back from GetCollection(1);
            foreach(int num in unkownCollection)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("********************************");

            //call GetCollection with option = 2 will return a Queue<int>
            //but we will store it in a base type of generic colleciions
            unkownCollection = IEnumeratorAndIEnumerableExample1(2);
            Console.WriteLine("This is a Queue<int>");
            //foreach number in the collection we got back from GetCollection(2);
            foreach (int num in unkownCollection)
            {
                Console.Write(num + " ");
            }

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

        //this way we don't care if it's a list, a queue etc because they all use IEnumarable and we will be able to loop over them regardless.
        static IEnumerable<int> IEnumeratorAndIEnumerableExample1(int option)
        {
            //create a list of numbers and init it
            List<int> numbersList = new List<int>() { 1,2,3,4,5 };

            Queue<int> numbersQueue = new Queue<int>();
            //adding values to the queue - FIFO
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            //if option 1
            if (option == 1)
            {
                return numbersList;
            } else if (option == 2)
            {
                return numbersQueue;
            } else
            {
                //return an array of numbers init with some numbers
                return new int[] { 11,12,13,14,15 };
            }
        }
    }
}
