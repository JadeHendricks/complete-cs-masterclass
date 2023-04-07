using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //subclass that extends vehicle
    internal class Car : Vehicle, IDestroyable
    {
        //implementing the desctructionSound
        public string DestructionSound { get; set; }

        //creating a new property to store the destroyable objects nearby
        //when a car gets destryoed it should also destroy nearby objects
        //this list is of type IDestroyable which means it can store any Object that implements this interface.
        //we can only access the properties and methods in this interface
        public List<IDestroyable> DestroyablesNearby;

        //simple constructor
        public Car(float speed, string color):base(speed, color)
        {
            //init the interfaces property with a value in the constructor
            this.DestructionSound = "CarExplosionSound.mp3";
            //init the list of destroyable objects
            this.DestroyablesNearby = new List<IDestroyable>();
        }

        //implementing the interfaces method
        public void Destroy()
        {
            //when a car gets destroyed we should play the destruction sound and create fire effect
            Console.WriteLine("Playing desctruction sound {0}", this.DestructionSound);
            Console.WriteLine("Create fire");

            //go through each destroyable object nearby and call it's destroy method
            foreach (IDestroyable destroyable in DestroyablesNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
