using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Test
    {
        static void Main(string[] args)
        {
            Dog[] dogs = new Dog[]
            {
                new Dog("Pluto", 3, "male", "Pitbull"),
                new Dog("Zara", 4, "female", "American Bulldog"),
                new Dog("Codita", 6, "male", "Husky"),
                new Dog("Biskit", 4, "male", "Labrador"),
                new Dog("Suri", 8, "female", "Beagle"),
            };
            
            Cat[] cats = new Cat[]
            {
                new Cat("Garfield", 5, "male", "Fluffy"),
                new Cat("Lola", 3, "female", "Shorthair "),
                new Cat("Tina", 4, "female", "Longhair"),
                new Cat("Gigi", 7, "male", "Hairless")
            };

            Tomcats tom = new Tomcats("Gogu", 5, "male", "Fluffy");
            tom.MakeSound();
            Kittens kitten = new Kittens("Pisi", 1, "female", "Shorthair");
            kitten.MakeSound();
            
            Frog[] frogs = new Frog[]
            {
                new Frog("Kermit", 3, "male", "green"),
                new Frog("Pipa", 4, "female", "yellow"),
                new Frog("Mitz", 1, "male", "black"),
                new Frog("Bigboy", 9, "male", "white")
            };
            
            Console.WriteLine("=====================================");

            Console.WriteLine("Average age of dogs are: " + Dog.AverageAge(dogs));
            dogs[2].MakeSound();
            dogs[1].MakeSound();
            dogs[3].MakeSound();
            dogs[0].MakeSound();

            Console.WriteLine("=====================================");
            
            Console.WriteLine("Average age of cats are " + Cat.AverageAge(cats));
            cats[0].MakeSound();
            cats[3].MakeSound();
            tom.MakeSound();
            kitten.MakeSound();

            Console.WriteLine("=====================================");
            
            Console.WriteLine("Average age of frogs are: " + Frog.AverageAge(frogs));
            frogs[3].MakeSound();
            frogs[0].MakeSound();
            frogs[1].MakeSound();
            frogs[2].MakeSound();

            Console.WriteLine("=====================================");

        }
    }
}


