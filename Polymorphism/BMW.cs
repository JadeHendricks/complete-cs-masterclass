using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //a BMW is a car
    internal class BMW : Car
    {
        public string Model { get; set; }
        private string Brand = "BMW";

        public BMW(int hp, string color, string model ) : base(hp, color) { 
            this.Model = model;
        }

        //when using new here it says that showDetails should be used in this class and not in the base class
        public new void ShowDetails()
        {
            Console.WriteLine("The HP is : {0} and the Color is : {1}, the brand is {2} and the model is {3}", this.HP, this.Color, this.Brand, this.Model);
        }

        //when using sealed here you won't allow any derived children to override this method (closes it up for further inheritence)
        //this (sealed) can also be used on classes - see M3 class for an example
        public sealed override void Repair()
        {
            Console.WriteLine("The BMW {0} was repaired!", this.Model);
        }
    }
}
