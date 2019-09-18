using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital.Employees
{
    class Nurse : Employee
    {
        int patients { get; set; }

        public Nurse()
        {
            base.salary = 50000;
        }
        public void CareForPatient()
        {

        }
        public void DrawBlood()
        {

        }
    }
}
