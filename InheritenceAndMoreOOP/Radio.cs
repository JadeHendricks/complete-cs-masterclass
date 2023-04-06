using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndMoreOOP
{
    internal class Radio : ElectricalDevice
    {

        //constructor
        //because our radio constructor isn't much different from the base constructor (ElectricalDevice) we can use the base yo set thae values without a body
        //so what's happening here is that we are saying all values passed to the Radio constructor please basse it on to the base constructor (ElectricalDevice) where it will be set
        public Radio(bool isOn, string brand): base(isOn, brand) { }

        //method to listen to the radio
        public void ListenRadio()
        {
            //first check if the radio is on
            if (IsOn)
            {
                //listen to radio
                Console.WriteLine("Listening to the Radio!");
            } else
            {
                //print error message
                Console.WriteLine("Radio is switched off, switch it on first");
            }
        }
    }
}
