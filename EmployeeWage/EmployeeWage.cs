using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        public void PartTimeEmployeeWage()
        {
            int wrkHr;
            int empRatePrHr = 20;
            int empWage;
            int isFullTime = 1;
            int isPresent = 1;

            int employeeStatus = new Random().Next(0, 2);
            int empTime = new Random().Next(0, 2);

            if (employeeStatus == isPresent)
            {
                if (empTime == isFullTime)
                {
                    Console.WriteLine("Employee is Present");
                    wrkHr = 8;

                }
                else
                {
                    Console.WriteLine("Employe is Present");
                    wrkHr = 4;
                }
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                wrkHr = 0;
            }

            empWage = wrkHr * empRatePrHr;
            Console.WriteLine("Employee wage is " + empWage);
        }

    }
}