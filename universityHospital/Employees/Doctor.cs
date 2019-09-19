using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital
{
    class Doctor : Employee
    {
        string specialty { get; set; }
        public Doctor(string Name, int Number, string Specialty)
        {
            this.specialty = Specialty;
            base.number = Number;
            base.name = Name;
            base.isPaid = false;
            base.salary = 90000;
        }

        public override void CareForPatient()
        {

        }
        public override void DrawBlood()
        {

        }
    }
}
