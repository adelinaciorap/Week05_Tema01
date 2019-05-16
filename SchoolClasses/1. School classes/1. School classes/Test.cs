using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School_classes
{
    class Test
    {
        static void Main(string[] args)
        {
            Students stu1 = new Students("Ioan", "Balan", 10);
            stu1.AddComment("Ioan is a needs to work harder.");

            Students stu2 = new Students("Ana", "Maria", 5);
            stu2.AddComment("Ana is a good student.");

            Students stu3 = new Students("Mihai", "Cretu", 7);
            stu3.AddComment("Mihai is not doing the homeworks.");

            Discipline mathematics = new Discipline("Mathematics", 4);
            mathematics.AddComment("Students understand Mathematics");

            Discipline music = new Discipline("Music", 3);
            Discipline chemistry = new Discipline("Chemistry", 3);
            Discipline english = new Discipline("English", 1);

            Teachers teach1 = new Teachers("Marcel", "Stan", new List<Discipline>() { mathematics, chemistry });
            teach1.AddComment("Marcel Stan is an experienced teacher");

            Teachers teach2=  new Teachers("Elena", "Gavrila", new List<Discipline>() { english });
            Class firstClass = new Class(new List<Students>() { stu1, stu3 }, new List<Teachers>() { teach1}, "A12");
            Class secondClass = new Class(new List<Students>() { stu2,stu3 }, new List<Teachers>() { teach2 }, "B7");

            School school = new School(new List<Class>() { firstClass, secondClass }, "Mihai Eminescu");
            school.PrintSchoolName();
            firstClass.ToString();
            secondClass.ToString();

            // Show comments
            stu1.PrintComment();
            stu2.PrintComment();
            stu3.PrintComment();
            mathematics.PrintComment();
            teach1.PrintComment();
        }


    }

}



    

