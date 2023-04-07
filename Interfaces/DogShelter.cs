using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //we are allowing the user to iterate over the dog type
    internal class DogShelter : IEnumerable<Dog>
    {
        //list of type List<Dog>
        public List<Dog> dogs;
        
        //this constructor will init the dogs list with some values
        public DogShelter()
        {
            //init the dogs list using the colelction-initializer
            dogs = new List<Dog>()
            {
                new Dog("Casper", false),
                new Dog("Sif", true),
                new Dog("Oreo", false),
                new Dog("Pixel", false)
            };
        }

        IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
        {
            return dogs.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
