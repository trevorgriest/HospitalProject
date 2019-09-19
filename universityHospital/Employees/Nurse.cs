using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital.Employees
{
    class Nurse : Employee
    {
        int patients { get; set; }

        public Nurse(string Name, int Number)
        {
            this.patients = 0;
            base.number = Number;
            base.name = Name;
            base.isPaid = false;
            base.salary = 50000;
        }
        public override void CareForPatient()
        {

        }
        public override void DrawBlood()
        {

        }
    }
}
