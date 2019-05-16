
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Cat : Animal
    {
        private string coat;
        
        public Cat(string name, int age, string sex, string coat)
            : base(name, age, sex)
        {
            this.Coat = coat;
        }
        
        public string Coat { get; set; }
        
        
        public override void MakeSound()
        {
            Console.WriteLine("Cat {0} speaks: purrrr meowwww", this.Name);
        }

    }
}
