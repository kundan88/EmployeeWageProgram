using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        public void CalDailyEmployeeWage()
        {
            int empRatePrHr = 20;
            int empHr;
            int empWage;
            int isPresent = 1;

            int employeeStatus = new Random().Next(2);
            Random random = new Random();

            if (employeeStatus == isPresent)
            {
                Console.WriteLine("Employee is Present");
                empHr = 8;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHr = 0;
            }

            empWage = empRatePrHr * empHr;
            Console.WriteLine("Employees daily wage is " + empWage);
        }
    }

}