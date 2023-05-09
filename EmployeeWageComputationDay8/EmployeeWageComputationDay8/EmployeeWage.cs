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
            const int EMP_RATE_PER_HOUR = 20;
            const int IS_FULL_TIME = 1;
            const int IS_PART_TIME = 2;
            const int NUM_OF_WORKING_DAYS = 5;
            int empHours = 0;
            int empWages = 0;
            int totalEmpwages = 0;
            for (int day = 0; day < NUM_OF_WORKING_DAYS; day++)
            {

                Random rdm = new Random();
                int empCheck = rdm.Next(3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHours = 8;
                        break;
                    case IS_PART_TIME:
                        empHours = 4;
                        break;
                    default:
                        empHours = 0;
                        break;
                }


                empWages = empHours * EMP_RATE_PER_HOUR;
                Console.WriteLine("Total wage of the employee :" + empWages);
                totalEmpwages += empWages;
            }
            Console.WriteLine("total EmpWages : " + totalEmpwages);
        }
    }

}

