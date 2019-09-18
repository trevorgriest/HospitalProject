using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital
{
    class Doctor : Employee
    {
        string specialty { get; set; }
        public Doctor()
        {
            base.salary = 90000;
        }

        public void CareForPatient()
        {

        }
        public void DrawBlood()
        {

        }
    }
}
