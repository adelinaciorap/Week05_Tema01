using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1.School_classes
{
    public class Teachers : Person
    {
        
        private List<Discipline> discipline;
        
        public Teachers(string firstName, string lastName, List<Discipline> discipline)
            : base(firstName, lastName)
        {
            this.Discipline = discipline;
        }
        
        public List<Discipline> Discipline { get; set; }
        
    }
}
    

