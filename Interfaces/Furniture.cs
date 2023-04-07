using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //base class for Furniture
    internal class Furniture
    {
        //color of furniture
        public string Color { get; set; }
        public string Material { get; set; }

        //default constructor
        public Furniture()
        {
            this.Color = "White";
            this.Material = "Wood";
        }

        //simple constrcutor
        public Furniture(string color, string material)
        {
            this.Color = color;
            this.Material = material;
        }
    }
}
