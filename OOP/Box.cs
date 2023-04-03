using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Box
    {
        //member variables
        private int length = 3;
        public int height;
        public int width;
        public int volume;

        public void SetLength(int length)
        {
            this.length = length;
        }

        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.width * this.height * this.length;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0}, height is {1} and width is {2} so the volume is {3}", length, height, width, volume = length*height*width);
        }
    }
}
