using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1.School_classes
{
    public class School
    {
        private string schoolName;
        private List<Class> classes;

        
        public School(List<Class> classes, string schoolName)
        {
            this.Classes = classes;
            this.SchoolName = schoolName;
        }
        
        public string SchoolName { get; set; }
        

        public List<Class> Classes
        {
            get { return this.classes; }
            set { this.classes = value; }
        }
        
        public void PrintSchoolName()
        {
            Console.WriteLine("---------- {0} ----------", SchoolName);
        }
    }

}
    

