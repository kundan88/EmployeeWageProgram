using System;
namespace EmployeeWage;
public class Program
{
    public static void Main(string[] args)
    {

        EmployeeWageComputation empWageComputation = new EmployeeWageComputation();
        empWageComputation.AddCompany("TATA", 20, 8, 4, 100, 20);
        empWageComputation.CalculateEmpWage("tata");
        empWageComputation.AddCompany("MAHINDRA", 20, 8, 7, 300, 16);
        empWageComputation.CalculateEmpWage("mahindra");
        empWageComputation.AddCompany("Tesla", 60, 8, 7, 10, 200);
        empWageComputation.CalculateEmpWage("tesla");

        Console.WriteLine("Enter the Company name");
        string company = Convert.ToString(Console.ReadLine());
        empWageComputation.func(company);

    }
}