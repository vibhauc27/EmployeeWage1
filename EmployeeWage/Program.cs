using System;
using System.Collections.Generic;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1;
            int empRatePerHour = 20;

            int empHour = 0;
            int empWage = 0;

            Random random = new Random();

            int empCheck = random.Next(0,2);
            if (empCheck == fullTime)
            {
                empHour = 8;
            }
            else
            {
                empHour = 0;
            }
            empWage = empHour * empRatePerHour;
            Console.WriteLine("Employee wage : " + empWage);
        }
    }
}