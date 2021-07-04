using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    class Department2 : Reception, IConsultation
    {
        private string _name;             // Название отделения
        
        public string _prescription;      
        public string _medicine;          


        public string consultation(Patient patient, Doctor doctor)
        {
            return $"Пациент: {patient}\n Прнимаемый врач: {doctor} \n Рекомендации: {_prescription} \n Лекарство: {_medicine}";
        }

    }
}
