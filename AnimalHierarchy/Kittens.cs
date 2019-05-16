
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Kittens : Cat
    {
        public Kittens(string name, int age, string sex, string gender)
               : base(name, age, "female", gender)
        {

        }
        
        public override void MakeSound()
        {
            Console.WriteLine("Kitten {0} speaks: meooow meooow!", this.Name);
        }
    }

}


