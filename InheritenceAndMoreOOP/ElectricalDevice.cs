using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceAndMoreOOP
{
    internal class ElectricalDevice
    {
        //boolean that determines the state of the Device
        public bool IsOn { get; set; }
        //string for the brand name of the Device
        public string Brand { get; set; }

        //constructor
        public ElectricalDevice(bool isOn, string brand)
        {
            this.IsOn = isOn;
            this.Brand = brand;
        }

        //switch on the Device
        public void SwitchOn()
        {
            this.IsOn = true;
        }

        //switch off the Device
        public void SwitchOff()
        {
            this.IsOn = false;
        }
    }
}
