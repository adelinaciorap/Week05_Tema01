using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Dog : Animal

    {
        private string breed;
        public Dog(string name, int age, string sex, string breed) : base(name, age, sex)
        {
            this.Breed = breed;
        }
        public string Breed { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("Dog {0} speaks: woof woof!", this.Name);
        }
        
    }
}


