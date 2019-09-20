using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital.Employees
{
    public class Receptionist : Employee
    {
         public bool isOnPhone { get; set; }

        public Receptionist(string Name, int Number)
        {
            this.isOnPhone = false;
            base.number = Number;
            base.name = Name;
            base.isPaid = false;
            base.salary = 45000;
        }
    }
}
