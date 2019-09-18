using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital.Employees
{
    class Janitor : Employee
    {
        bool isSweeping { get; set; }
        public Janitor()
        {
            base.salary = 40000;
        }
    }
}
