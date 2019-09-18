using System;
using System.Collections.Generic;
using System.Text;

namespace universityHospital
{
    class Utility
    {
        List<Employee> employeeList = new List<Employee>();

        public void ViewAllEmployees()
        {
            foreach(Employee employee in employeeList)
            {
                Console.WriteLine("*******************************");
                Console.WriteLine("Name : " + employee.name);
                Console.WriteLine("Number : " + employee.number);
                Console.WriteLine("Salary : " + employee.salary);
                Console.WriteLine("Employee Paid : " + employee.isPaid);
            }
            Console.WriteLine("*******************************");
        }
        public void SelectEmployee()
        {

        }
    }
}
