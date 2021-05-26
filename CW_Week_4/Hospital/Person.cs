using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Person
    {
        public string _last_name;
        public string _first_name;
        private int _age;

        public Person(string last_name, string first_name, int age)
        {
            _last_name = last_name;
            _first_name = first_name;
            _age = age;
        }
        
    }
}
