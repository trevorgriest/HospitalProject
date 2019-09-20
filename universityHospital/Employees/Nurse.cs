using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital.Employees
{
    public class Nurse : Employee
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
        public override void CareForPatient(Patient patient)
        {
            patient.health++;
            Console.WriteLine("Patient current health : " + patient.health);
        }
        public override void DrawBlood(Patient patient)
        {
            patient.blood -= 2;
            Console.WriteLine("Patient current blood level : " + patient.blood);
        }
    }
}
