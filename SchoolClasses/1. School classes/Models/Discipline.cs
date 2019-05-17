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
        private int numberOfLectures;
        private int numberOfExercises;


        public Discipline(string disciplineName, int numberOfLectures, int numberOfExercises)
        {
            this.DisciplineName = disciplineName;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }
        
        public string DisciplineName { get; set; }


        public int NumberOfExercises { get; set; }

        public int NumberOfLectures { get; set; }

    }


}

