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
        private int height;
        public int width;
        public int volume;

        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }


        //we do not need to have a member variable above with this way of doing it
        public int Width { get; set; }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                } 
                else
                {
                    height = value;
                }
                
            }
        }

        public void SetLength(int length)
        {
            if (length < 0)
            {
                throw new Exception("Length should be higher than 0");
            }
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
