using System;

namespace universityHospital
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int inputInt;
            Utility utility = new Utility();

            do
            {
                Console.WriteLine("Enter \"view\" to view all employees");
                Console.WriteLine("Enter an employee ID to select an employee");
                input = Console.ReadLine();
                if(int.TryParse(input, out inputInt))
                {
                    utility.SelectEmployee();
                }
                if(input.ToLower() == "view")
                {
                    utility.ViewAllEmployees();
                }
            }
            while ();
        }
    }
}
