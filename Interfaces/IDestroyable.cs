using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface IDestroyable
    {
        //property to store the audio file of the destruction sound
        public string DestructionSound { get; set; }

        //method to destroy an object
        void Destroy();
    }
}
