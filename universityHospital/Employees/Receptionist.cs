using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital.Employees
{
    class Receptionist : Employee
    {
        bool isOnPhone { get; set; }

        public Receptionist()
        {
            base.salary = 45000;
        }
    }
}
