using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School_classes
{
        public class Class : Comment
        {
            private List<Students> students;
            private List<Teachers> teachers;
            private string classID;
            
            public Class(List<Students> students, List<Teachers> teachers, string classID)
            {
                this.Students = students;
                this.Teachers = teachers;
                this.ClassID = classID;
            }
             
            public List<Students> Students
            {
                get { return this.students; }
                set { this.students = value; }
            }

            public List<Teachers> Teachers
            {
                get { return this.teachers; }
                set { this.teachers = value; }
            }

            public string ClassID { get; set; }
            
            
            public override string ToString()
            {
                Console.WriteLine("======== Students =========");
                foreach (var element in Students)
                {
                    Console.WriteLine("Full name: {0}, Class: {1}, ClassID: {2}", element.FirstName + " " + element.LastName, element.StudentClassNumber, ClassID);
                }
                Console.WriteLine();
            
                Console.WriteLine("=========Teachers =========");
                foreach (var element in Teachers)
                {
                    Console.WriteLine("Full name: {0} Disciplines: ", element.FirstName + " " + element.LastName);

                    foreach (var item in element.Discipline)
                    {
                    Console.WriteLine("Discipline name: " + item.DisciplineName);
                    Console.WriteLine("Number of lectures: " + item.NumberOfLectures);
                    Console.WriteLine("Number of exercises: " + item.NumberOfExercises);
                    Console.WriteLine();
                    }
                }

                return base.ToString();
            }
        }
    }

