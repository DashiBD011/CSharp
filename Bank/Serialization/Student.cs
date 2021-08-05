using System;
using System.Collections.Generic;
using System.Text;

namespace Serialization
{
    [Serializable]
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Group group { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;

        }
        public override string ToString()
        {
            return Name;
            
        }
    }
}
