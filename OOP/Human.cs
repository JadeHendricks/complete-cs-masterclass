using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Human
    {
        //members variable
        public string firstName = "Michael";
        private string lastName;

        //member method
        public void IntroduceMySelf()
        {
            Console.WriteLine("Hi, I'm {0}", firstName);
        } 

    }
}
