using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationDay8
{
    internal class EmployeeWage
    {
        public const int EMP_RATE_PER_HOUR = 20;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int NUM_OF_WORKING_DAYS = 20;
        public const int MAX_HRS_IN_MONTH = 100;
        public void EmployeeAttendence()
        {
            int empHours = 0;
            int empWages = 0;
            int totalEmpwages = 0;
            int totalWorkingDays = 0;
            int totalEmphrs = 0;


            while (totalEmphrs <= MAX_HRS_IN_MONTH && totalWorkingDays < MAX_HRS_IN_MONTH)
            {
                totalWorkingDays++;
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


                totalEmphrs = totalEmphrs + empHours;
                Console.WriteLine("Day# : " + totalWorkingDays + "Emp hrs :" + empHours);
                totalEmpwages += empWages;
            }
            int totalEmpWage = totalEmphrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("total Emp wages : " + totalEmpWage);

        }

    }
}

