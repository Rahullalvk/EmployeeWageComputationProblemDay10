using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationDay8
{
    internal class EmployeeWage
    {
        public void EmployeeAttendence()
        {

            int IS_FULL_TIME = 1;
            Random rdm = new Random();
            int empCheck = rdm.Next(2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee Is present");
            }
            else
            {
                Console.WriteLine("Employee Is absent");
            }

        }
    }
}
