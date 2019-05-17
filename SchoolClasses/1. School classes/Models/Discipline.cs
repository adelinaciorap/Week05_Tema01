using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1.School_classes
{
    public class Discipline : Comment
    {

        private string disciplineName;
        private int numberOfHours;


        public Discipline(string disciplineName, int numberOfHours)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfHours = numberOfHours;
        }
        
        public string DisciplineName { get; set; }


        public int NumberOfHours { get; set; }



    }


}

