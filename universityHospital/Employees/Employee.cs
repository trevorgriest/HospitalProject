using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital
{
    class Employee
    {
        public string name { get; set; }
        public int number { get; set; }
        public int salary { get; set; }
        public bool isPaid { get; set; }
        void PayEmployee()
        {
            if(isPaid ==  false)
            {
                this.isPaid = true;
            }
        }
        public virtual void CareForPatient()
        {

        }
        public virtual void DrawBlood()
        {

        }
    }
}
