using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital.Employees
{
    class Janitor : Employee
    {
        bool isSweeping { get; set; }
        public Janitor(string Name, int Number)
        {
            this.isSweeping = false;
            base.number = Number;
            base.name = Name;
            base.isPaid = false;
            base.salary = 40000;
        }
    }
}
