using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AnimalHierarchy
{
    public abstract class Animal : ISound
    {
        private string name;
        private int age;
        private string sex;

        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }

        public Animal(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public abstract void MakeSound();
        public static double AverageAge(Animal[] animals)
        {
            double total = 0;
            foreach (var being in animals)
            {
                total += being.Age;
            }
            double average = total/ animals.Length;
            return average;
        }
    }
}

