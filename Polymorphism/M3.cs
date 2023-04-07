using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class M3 : BMW
    {
        public M3(int hp, string color, string model) : base(hp, color, model) { }

        /*public override void Repair()
        {
            base.Repair();
        }*/
    }
}
