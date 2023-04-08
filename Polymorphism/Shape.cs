using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //when you create a abstract class
    //you can make abstract methods that we have to implement once a class inherits from this class
    abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine($"\nThis is a {this.Name}");
        }

        public abstract double Volume();
    }
}
