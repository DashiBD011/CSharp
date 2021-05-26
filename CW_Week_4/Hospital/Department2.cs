using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Department2 : Reception, IConsultation
    {
        private string _name;             // Название отделения
        private string _head_of_the_dep;  // Заведующий отделением 
        public string _complaint;         
        public string _prescription;      
        public string _medicine;          


        public Department2(string name, string head_of_the_dep, string complaint, string prescription, string medicine)
        {
            _name = name;
            _head_of_the_dep = head_of_the_dep;
            _complaint = complaint;
            _prescription = prescription;
            _medicine = medicine;
        }

        public void consultation()
        {
            Console.WriteLine($"Жалоба: {_complaint}");
            Console.WriteLine($"Назначения: {_prescription}");
            Console.WriteLine($"Лекарство: { _medicine}");
        }
       

    }
}
