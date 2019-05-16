﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1.School_classes
{
    public class Person : Comment
    {
        private string firstName;
        private string lastName;
        
        public Person(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        
        public string FirstName { get; set; }
        

        public string LastName { get; set; }

    }
}
    

