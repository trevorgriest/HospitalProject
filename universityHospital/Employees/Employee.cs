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
        public void PayEmployee()
        {
            if(isPaid ==  false)
            {
                Console.WriteLine(name + " has been paid " + salary);
                this.isPaid = true;
            }
            else Console.WriteLine(name + " has already been paid");
            Console.ReadLine();
        }
        public virtual void CareForPatient()
        {

        }
        public virtual void DrawBlood()
        {

        }
    }
}
