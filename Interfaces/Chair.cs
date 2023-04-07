using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Chair : Furniture, IDestroyable
    {
        //implementing the desctructionSound
        public string DestructionSound { get; set; }

        //simple constructor
        public Chair(string color, string material):base(color, material) {
            //init the interfaces property with a value in the constructor
            this.DestructionSound = "chairDestructionSound.mp3";
        }

        //implementing the interfaces method
        public void Destroy()
        {
            //when a chair gets destroyed we should play the desctruction sound and spawn the destroyed chair parts
            Console.WriteLine($"The {this.Color} chair was destroyed");
            Console.WriteLine("Playing desctruction sound {0}", this.DestructionSound);
            Console.WriteLine("Spawning chair parts");
        }
    }
}
