using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Frog : Animal
    {
        private string color;
        
        public Frog(string name, int age, string sex, string color)
            : base(name, age, sex)
        {
            this.color = Color;
        }
        
        public string Color { get; set; }
        
        
        public override void MakeSound()
        {
            Console.WriteLine("Frog {0} speaks: croak croak!", this.Name);

        }
    }
}
