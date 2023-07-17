using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_exersice_8
{
    
    
        
        
            

namespace SalaryCalculator
    {
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Choose Employee Type:");
                Console.WriteLine("1. HR");
                Console.WriteLine("2. Admin");
                Console.WriteLine("3. Software Developer");

                int employeeType = int.Parse(Console.ReadLine());

                switch (employeeType)
                {
                    case 1:
                        Console.Write("Enter working hours: ");
                        int workingHoursHR = int.Parse(Console.ReadLine());

                        Console.Write("Enter number of working days: ");
                        int numWorkingDaysHR = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Monthly Salary: {CalculateSalary(workingHoursHR, numWorkingDaysHR)}");
                        break;

                    case 2:
                        Console.Write("Enter working hours: ");
                        int workingHoursAdmin = int.Parse(Console.ReadLine());

                        Console.Write("Enter number of working days: ");
                        int numWorkingDaysAdmin = int.Parse(Console.ReadLine());

                        Console.Write("Enter project handles: ");
                        int projectHandlesAdmin = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Monthly Salary: {CalculateSalary(workingHoursAdmin, numWorkingDaysAdmin, projectHandlesAdmin)}");
                        break;

                    case 3:
                        Console.Write("Enter working hours: ");
                        int workingHoursDev = int.Parse(Console.ReadLine());

                        Console.Write("Enter number of working days: ");
                        int numWorkingDaysDev = int.Parse(Console.ReadLine());

                        Console.Write("Enter project handles: ");
                        int projectHandlesDev = int.Parse(Console.ReadLine());

                        Console.Write("Enter extras: ");
                        int extrasDev = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Monthly Salary: {CalculateSalary(workingHoursDev, numWorkingDaysDev, projectHandlesDev, extrasDev)}");
                        break;

                    default:
                        Console.WriteLine("Invalid employee type.");
                        break;
                }

                Console.ReadLine();
            }

            static decimal CalculateSalary(int wHour, int nWDays, int projectHandles = 0, int extras = 0)
            {
                decimal baseSalary = wHour * nWDays * 100;
                decimal projectSalary = projectHandles * 3000;
                decimal extrasSalary = extras * 2000;

                decimal totalSalary = baseSalary + projectSalary + extrasSalary;

                return totalSalary;
            }
        }
    }
}
    

