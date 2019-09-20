﻿using System;
using System.Collections.Generic;
using System.Text;
using universityHospital.Employees;

namespace universityHospital
{
    class Utility
    {
        List<Employee> employeeList = new List<Employee>();

        public void ViewAllEmployees()
        {
            foreach(Employee employee in employeeList)
            {
                string profession = null;
                if (employee is Doctor) profession = "Doctor";
                else if (employee is Nurse) profession = "Nurse";
                else if (employee is Receptionist) profession = "Receptionist";
                else if (employee is Janitor) profession = "Janitor";

                Console.WriteLine("*******************************");
                Console.WriteLine("Job Title : " + profession + "\n");
                Console.WriteLine("Name : " + employee.name);
                Console.WriteLine("Number : " + employee.number);
                Console.WriteLine("Salary : " + employee.salary);
                Console.WriteLine("Employee Paid : " + employee.isPaid);
            }
            Console.WriteLine("*******************************");
        }
        public Employee SelectEmployee(int employeeNumber)
        {
            Employee employeeMatch = null;
            foreach(Employee employee in employeeList)
            {
                if (employee.number == employeeNumber) employeeMatch = employee;
            }
            return employeeMatch;
        }
        public void DisplaySelectedEmployee(Employee employee, Patient patient)
        {
            bool inSelectMenu = true;

            Console.WriteLine("*******************************");
            Console.WriteLine("Name : " + employee.name);
            Console.WriteLine("Number : " + employee.number);
            Console.WriteLine("Salary : " + employee.salary);
            Console.WriteLine("Employee Paid : " + employee.isPaid);
            Console.WriteLine("*******************************\n");
            Console.WriteLine("<b> Return to menu");
            Console.WriteLine("<p> Pay employee");
            if (employee is Doctor || employee is Nurse)
            {
                Console.WriteLine("<c> Care for Patient");
                Console.WriteLine("<d> Draw Blood");
            }
            string input = Console.ReadLine();
            if (employee is Doctor || employee is Nurse)
            {
                if (input.ToLower() == "c") employee.CareForPatient(patient);
                if (input.ToLower() == "d") employee.DrawBlood(patient);
            }
            if (input.ToLower() == "b") inSelectMenu = false;
            if (input.ToLower() == "p") employee.PayEmployee();
            Console.ReadLine();
            Console.Clear();
        }
        public void CreateEmployees()
        {
            employeeList.Add(new Doctor("Mike Joedie",12342,"Brains"));
            employeeList.Add(new Nurse("John Mcdiver", 34321));
            employeeList.Add(new Receptionist("Amanda Smith", 44234));
            employeeList.Add(new Janitor("Jimbo Balls", 91234));
        }
    }
}
