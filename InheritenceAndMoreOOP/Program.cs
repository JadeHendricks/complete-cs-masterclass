using System;

namespace InheritenceAndMoreOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio myRadio = new Radio(false, "Sony");
            myRadio.SwitchOn();
            myRadio.ListenRadio();

            Console.WriteLine("******************************");

            TV myTV = new TV(false, "LG");
            myTV.WatchTV();
        }
    }
}
