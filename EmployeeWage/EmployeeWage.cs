using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    class EmployeeWageComputaion
    {
        private int _empRatePrHr;
        private const int _isFullTime = 1;
        private const int _isPartTime = 2;
        private int _fullTimeHrs;
        private int _partTimeHrs;
        private int _numOfDays;
        private int _maxHrs;
        private int totalWage;

        public EmployeeWageComputaion(int empRatePrHr, int fullTimeHrs, int partTimeHrs, int maxdays, int maxHours)
        {
            _empRatePrHr = empRatePrHr;
            _fullTimeHrs = fullTimeHrs;
            _partTimeHrs = partTimeHrs;
            _numOfDays = maxdays;
            _maxHrs = maxHours;
        }
        private int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }
        public void CalculateWage()
        {
            int workHr;
            int totalWrkHr = 0;
            int totalWrkDays = 0;

            while (totalWrkHr < _maxHrs && totalWrkDays < _numOfDays)
            {
                switch (IsEmployeePresent())
                {
                    case _isFullTime:
                        workHr = _fullTimeHrs;
                        break;
                    case _isPartTime:
                        workHr = _partTimeHrs;
                        break;
                    default:
                        workHr = 0;
                        break;
                }
                totalWrkHr += workHr;
                totalWrkDays++;
            }
            totalWage = totalWrkHr * _empRatePrHr;
            Console.WriteLine("Employee total wage is {0} for {1} working days", totalWage, totalWrkDays);
        }
    }
   
}