using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital
{
    public class Doctor : Employee
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
