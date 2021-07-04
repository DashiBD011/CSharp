using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital
{
    interface IConsultation
    {
        public string consultation(Patient patient, Doctor doctor);
    }
}
