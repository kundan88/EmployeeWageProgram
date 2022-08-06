using System;
namespace EmployeeWage;
public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Welcome to Employee Wage Computation!");
        Console.WriteLine();
        EmployeeWageComputaion wage = new EmployeeWageComputaion();
        wage.AddCompany("TATA", 20, 8, 4, 100, 20);
        wage.AddCompany("Mahindra", 30, 8, 4, 100, 20);
        wage.CalculateWage("Tata");
        wage.CalculateWage("Mahindra");
    }
}