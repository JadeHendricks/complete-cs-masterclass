using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //IEquatable = you need to declare what type of objects you want to compare
    internal class Ticket : IEquatable<Ticket>
    {
        //property tos tore the duration of the ticket in hours
        public int DurationInHours { get; set; }
        //simple constructor

        public Ticket(int durationInHours)
        {
            this.DurationInHours = durationInHours;
        }

        //we are using a IEquatable interface here that allows us to compare objects
        //if they have the same values, usually this will always be false because of referencing.
        public bool Equals(Ticket other)
        {
            return this.DurationInHours == other.DurationInHours;
        }
    }
}
