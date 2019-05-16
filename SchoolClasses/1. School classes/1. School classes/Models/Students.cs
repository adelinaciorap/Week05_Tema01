using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School_classes
{ 
    public class Students : Person
    {
        
        private int studentClassNumber;
        
        public Students(string firstName, string lastName, int studentClassNumber)
            : base(firstName, lastName)
        {
            this.StudentClassNumber = studentClassNumber;
        }

        // Properties
        public int StudentClassNumber { get; set; }
        
    }
}
    

