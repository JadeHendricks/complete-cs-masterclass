using System;
using System.Collections.Generic;

namespace EventsAndDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelegatesBasicsExample();
            CreateOurOwnDelegatesAndAnonymousMethods();
        }

        public static void DelegatesBasicsExample()
        {
            //Delegates that already exist in C#
            //remove all expects a delegate to be pass to it and it will automatically call it when needed
            List<string> names = new List<string>() { "Aiden", "Sif", "Walter", "Anatoli" };

            Console.WriteLine("----before----");
            //print the names before the remove method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //calling the RemoveAllMethod and passing a method Filter that we created.
            names.RemoveAll(Filter);

            //print the names after the remove all method
            Console.WriteLine("----after----");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        static bool Filter(string s)
        {
            //return whethere the string s contains the letter "i"
            //the cotnains method will return a boolean which will return aswell
            return s.Contains("i");
        }

        //delcaring our delegate
        //our delegate will take a person as a param and return a boolean regarding the ages met
        public delegate bool FilterDelegate(Person p);

        public static void CreateOurOwnDelegatesAndAnonymousMethods()
        {
            Person p1 = new Person() { Name = "Aiden", Age = 41 };
            Person p2 = new Person() { Name = "Sif", Age = 69 };
            Person p3 = new Person() { Name = "Walter", Age = 12 };
            Person p4 = new Person() { Name = "Anatoli", Age = 25 };

            List<Person> people = new List<Person>() { p1, p2, p3, p4 };
            Console.WriteLine("----Minors----");
            DisplayPeople("Kids", people, IsMinor);
            Console.WriteLine("----Adults----");
            DisplayPeople("Adults", people, IsAdult);
            Console.WriteLine("----Seniors----");
            DisplayPeople("Senior", people, IsSenior);

            //using an anonymous function

            //here we create a new varialbe called filter of type FilterDelegate.
            //Then we assign an anonymous method to it instead of already defined method
            FilterDelegate filter = delegate (Person person)
            {
                return person.Age >= 20 && person.Age <= 30;
            };
            Console.WriteLine("----Between 20 and 30 with anonymous method----");
            DisplayPeople("Between 20 and 30 : ", people, filter);
            Console.WriteLine("----All people with anonymous method part 2----");
            DisplayPeople("Between 20 and 30 : ", people, delegate (Person person) { return true; });

            //Lambda Expressions
            //statement Lambda - a search jeyword to filter the names
            string searchKeyword = "A";
            Console.WriteLine("----age > 20 with searchKeyword----");
            DisplayPeople("age > 20 with search keyword:" + searchKeyword, people, (p) => 
            { 
                if (p.Name.Contains(searchKeyword) && p.Age > 20)
                {
                    return true;
                } else
                {
                    return false;
                }
            });

            //expression lambda
            //one line of code
            Console.WriteLine("----Exaclty 25----");
            DisplayPeople("Exactly 25:", people, p => p.Age == 25);
        }

        //A method to display a list of people that passes the filter condition (return true)
        //This method will take a title to be displayed, the list of people and filter delegate
        static void DisplayPeople(string title, List<Person> people, FilterDelegate filter)
        {
            Console.WriteLine(title);

            foreach (Person person in people)
            {
                //check if this person passes the filter
                if (filter(person))
                {
                    //print the person's name and age
                    Console.WriteLine("{0}, {1} years old", person.Name, person.Age);
                }
            }
        }
        //=========FILTERS=============
        static bool IsMinor(Person person)
        {
            return person.Age < 18;
        }

        static bool IsAdult(Person person)
        {
            return person.Age >= 18;
        }

        static bool IsSenior(Person person)
        {
            return person.Age > 65;
        }
    }
}
