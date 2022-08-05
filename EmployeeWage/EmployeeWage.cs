using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    public class EmployeeWage
    {
        public void EmployeeCheckAttendance()
        {
            int is_Full_Time = 1;
            Random random = new Random();
            int employeeCheck = new Random().Next(2);

            if (employeeCheck == is_Full_Time)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}