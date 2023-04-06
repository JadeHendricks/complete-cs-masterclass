using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndMoreOOP
{
    internal class Dog : Animal
    {
        //bool property to check if the dog is happy
        public bool IsHappy { get; set; }

        //simple constructor where we pass the name age to our base constructor
        public Dog(string name, int age, bool IsHungry) : base(name, age, IsHungry)
        {
            //all dogs are happy
            this.IsHappy = true;
        }

        //simple override of the virtual method Eat
        public override void Eat()
        {
            //to call the eat method from our base class we use the keyword "base" i.e Animal
            base.Eat();
        }

        //override of the virtual method MakeSound
        public override void MakeSound()
        {
            //since every animal will make a totally different sound
            //each animal will implement their own version of MakeSound
            Console.WriteLine("Wuuuuuuf!");
        }

        //override of the virtual method play
        public override void Play()
        {
            //check if the dog is happy if yes call the Play method from the base class
            if (this.IsHappy)
            {
                base.Play();
            }
        }
    }
}
