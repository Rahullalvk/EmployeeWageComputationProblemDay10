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
            int EMP_RATE_PER_HOUR = 20;

            int IS_FULL_TIME = 1;
            int IS_PART_TIME = 2;
            int empHours = 0;
            int empWages = 0;
            Random rdm = new Random();
            int empCheck = rdm.Next(3);
            {
                switch (empCheck)
                {
                    case 0:
                        empCheck = 0;
                        empHours = 0;
                        break;
                    case 1:
                        empCheck = 1;
                        empHours = 8;
                        break;
                    case 2:
                        empCheck = 2;
                        empHours = 4;
                        break;
                }

            }
            empWages = empHours * EMP_RATE_PER_HOUR;
            Console.WriteLine("Total wage of the employee :" + empWages);

        }

    }
}

