using System;

namespace EmployeeWage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation!");
            Console.WriteLine();
            EmployeeWageComputaion wage = new EmployeeWageComputaion(20, 8, 4, 20, 100);
            wage.CalculateWage();
        }
    }
}
