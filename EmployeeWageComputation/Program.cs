﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WelCome To Emplyee Wage Compution");
            CalculateEmpWagePrMonth obj = new CalculateEmpWagePrMonth();
            obj.TotalWage();
            Console.ReadLine();
        }
    }
}
