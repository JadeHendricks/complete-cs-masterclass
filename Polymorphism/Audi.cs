﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    //a Audi is a car
    internal class Audi : Car
    {
        public string Model { get; set; }
        private string Brand = "Audi";

        public Audi(int hp, string color, string model) : base(hp, color)
        {
            this.Model = model;
        }

        //when using new here it says that showDetails should be used in this class and not in the base class
        public new void ShowDetails()
        {
            Console.WriteLine("The HP is : {0} and the Color is : {1}, the brand is {2} and the model is {3}", this.HP, this.Color, this.Brand, this.Model);
        }

        public override void Repair()
        {
            Console.WriteLine("The Audi {0} was repaired!", this.Model);
        }
    }
}
