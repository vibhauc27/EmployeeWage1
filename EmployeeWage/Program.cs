using System;
using System.Collections.Generic;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1;
            Random random = new Random();

            int empCheck = random.Next(0,2);
            if (empCheck == fullTime)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            
        }
    }
}