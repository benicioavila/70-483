using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _70_483
{
    public class Dog
    {
        public Dog()
        {
            NumberOfLegs = 4;
        }

        public Dog(int legs)
        {
            NumberOfLegs = legs;
        }
        public int NumberOfLegs { get; set; }
    }
}
