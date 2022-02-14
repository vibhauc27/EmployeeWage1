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
       public const int maxHoursInMonth = 10;
        
        public static int EmployeeWage()
        {
            //int fullTime = 1;
            //int partTime = 2;
            int empRatePerHour = 20;

            int empHour = 0;
            int totalEmpHour = 0;
            int totalWorkingDays = 0;
            int totalEmpWage = 0;

            while(totalEmpHour <= maxHoursInMonth && totalWorkingDays <= numOfWorkingDays)
            {
                totalWorkingDays++;
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
                totalEmpHour += empHour;
                //empWage = empHour * empRatePerHour;
                //totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("Days : " + totalWorkingDays + "Employee Hours : " + empHour);
            }
            totalEmpWage = totalEmpHour * empRatePerHour;
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            EmployeeWage();
        }
    }
}