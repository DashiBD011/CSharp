using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    public class Person
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private uint Age { get; set; }

        public Person()
        {
            
        }
        public Person(string LastName, string FirstName,uint Age)
        {
            this.LastName = LastName;
            this.FirstName = FirstName;
            this.Age = Age;
        }

        public string InfoPerson()
        {
            return $"{FirstName} {LastName}, {Age} лет ";
        }
      
    }
}
