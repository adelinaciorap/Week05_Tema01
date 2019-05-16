using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    public class Tomcats : Cat
    {
        public Tomcats(string name, int age, string sex, string breed)
            : base(name, age, "male", breed)
        {
        }
        
        public override void MakeSound()
        {
            Console.WriteLine("Tomcat {0} speaks: hiss hiss!", this.Name);
        }
    }
}


