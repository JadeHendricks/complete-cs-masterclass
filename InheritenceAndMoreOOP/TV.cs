using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndMoreOOP
{
    internal class TV : ElectricalDevice
    {
        //constructor
        //because our TV constructor isn't much different from the base constructor (ElectricalDevice) we can use the base yo set thae values without a body
        //so what's happening here is that we are saying all values passed to the TV constructor please basse it on to the base constructor (ElectricalDevice) where it will be set
        public TV(bool isOn, string brand):base(isOn, brand) {}

        //method towatch the TV
        public void WatchTV()
        {
            //first check if the TV is on
            if (IsOn)
            {
                //watch the TV
                Console.WriteLine("Watching TV!");
            }
            else
            {
                //print error message
                Console.WriteLine("TV is switched off, switch it on first");
            }
        }
    }
}
