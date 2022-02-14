using System;
using System.Collections.Generic;

namespace EmployeeWage
{
    class Program
    {
       public const int fullTime = 1;
       public const int partTime = 2;
       public const int numOfWorkingDays = 2;
       //public const int empRatePerHour = 20;
        static void Main(string[] args)
        {
            //int fullTime = 1;
            //int partTime = 2;
            int empRatePerHour = 20;

            int empHour = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for(int day = 0; day < numOfWorkingDays; day++)
            {
                Random random = new Random();

                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case partTime:
                        empHour = 4;
                        break;
                    case fullTime:
                        empHour = 8;
                        break;
                    default:
                        empHour = 0;
                        break;
                }
                empWage = empHour * empRatePerHour;
                totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("Employee wage : " + empWage);
            }
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
            
        }
    }
}