using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Human
    {
        //members variable
        private string firstName;
        private string lastName;
        private string eyeColour;
        private int age;

        //default constructor
        public Human()
        {
            Console.WriteLine("Hello I am from the constructor :)");
        }

        //parameterize constructor
        public Human(string firstName, string lastName, string eyeColour, int age) { 
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColour = eyeColour;
            this.age = age;
        }

        //parameterize constructor
        public Human(string firstName, string lastName, string eyeColour)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColour = eyeColour;
        }

        //member method
        public void IntroduceMySelf()
        {
            if (age != 0)
                Console.WriteLine("Hi there, I'm {0}{1}. My eye colour is {2} and I am {3} year old", firstName, lastName, eyeColour, age);
            else
                Console.WriteLine("Hi there, I'm {0}{1}. My eye colour is {2}", firstName, lastName, eyeColour);
        } 

    }
}
