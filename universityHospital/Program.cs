﻿using System;
using universityHospital.Employees;

namespace universityHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            // Team name = Team Rocket
            string input;
            int inputInt;
            Employee selectedEmployee = null;
            Utility utility = new Utility();
            Patient patient = new Patient();
            utility.CreateEmployees();

            while(true)
            {
                Console.WriteLine("Enter \"view\" to view all employees");
                Console.WriteLine("Enter an employee ID to select an employee");
                input = Console.ReadLine();
                if (int.TryParse(input, out inputInt))
                {
                    Console.Clear();
                    selectedEmployee = utility.SelectEmployee(inputInt);
                    if (selectedEmployee == null) Console.WriteLine("There is no employee with this ID number");
                    else utility.DisplaySelectedEmployee(selectedEmployee, patient);
                }
                if (input.ToLower() == "view")
                {
                    Console.Clear();
                    utility.ViewAllEmployees();
                }
            } 
        }
    }
}
