using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
     class CheckEmplyeePesentOrNot
    {
        public void EmplyeeCheck()
        {
            int IS_FULL_TIME = 1;
            Random check = new Random();

            int empCheck = check.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Not Present");
            }
        }
    }
}
