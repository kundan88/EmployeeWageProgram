using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        public const int empRatePrHr = 20;
        public const int isFullTime = 2;
        public const int isPartTime = 1;

        public void EmpWageUsingSwitchCase()
        {

            int workHr;
            int totalWage;

            int employeeStatus = new Random().Next(2);

            switch (employeeStatus)
            {
                case isFullTime:
                    workHr = 8;
                    break;
                case isPartTime:
                    workHr = 4;
                    break;
                default:
                    workHr = 0;
                    break;
            }
            totalWage = empRatePrHr * workHr;
            Console.WriteLine("Employee total wage is " + totalWage);
        }
    }
}

