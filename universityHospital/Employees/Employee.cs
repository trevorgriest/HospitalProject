using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital
{
    class Employee
    {
        public string name { get; }
        public string number { get; }
        public int salary { get; set; }
        public bool isPaid { get; set; }
        
        void PayEmployee()
        {
            if(isPaid ==  false)
            {
                this.isPaid = true;
            }
        }
    }
}
