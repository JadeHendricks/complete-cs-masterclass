using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //base class for vehicles
    internal class Vehicle
    {
        public float Speed { get; set; }
        public string Color { get; set; }

        public Vehicle()
        {
            this.Speed = 120f;
            this.Color = "White";
        }

        //simple constructor
        public Vehicle(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
        }
    }
}
