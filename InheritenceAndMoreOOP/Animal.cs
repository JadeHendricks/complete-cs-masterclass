using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndMoreOOP
{
    internal class Animal
    {
        public string Name;
        public int Age;
        public bool IsHungry;

        public Animal(string name, int age, bool isHungry) {
            this.Name = name;
            this.Age = age;
            this.IsHungry = isHungry;
        }

        //virtual basically allows this method to be overwritten by classes that inherit this class
        //you can override if you want, but you don't have to
        public virtual void MakeSound()
        {

        }

        //virtual basically allows this method to be overwritten by classes that inherit this class
        //you can override if you want, but you don't have to
        public virtual void Eat()
        {
            //check if animal is hungry
            if(IsHungry)
            {
                //if yes then print the name of the animal + "is eating"
                Console.WriteLine($"{this.Name} is eating");
            } else {
                //otherwise print that the animal is not hungry
                Console.WriteLine($"{this.Name} is not hungry");
            }
        }

        //virtual basically allows this method to be overwritten by classes that inherit this class
        //you can override if you want, but you don't have to
        public virtual void Play()
        {
            Console.WriteLine($"{this.Name} is playing");
        }
    }
}
