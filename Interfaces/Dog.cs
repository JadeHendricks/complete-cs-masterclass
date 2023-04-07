using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Dog
    {
        public string Name { get; set; }
        public bool IsNaughtyDog { get; set; }

        //simple constructor
        public Dog(string name, bool isNaughtyDog)
        {
            this.Name = name;
            this.IsNaughtyDog = isNaughtyDog;
        }

        //this method will print how many treats the dog received
        public void GiveTreat(int numberOfTreats)
        {
            //print a message containing the number of treats and the name of the dog
            Console.WriteLine("Dog: {0} said wuoff {1} times!", this.Name, numberOfTreats);
        }
    }
}
