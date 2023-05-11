using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationDay8
{
    public class EmpWageBuilderArray
    {

        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private ArrayList companyEmpWageList;

        public EmpWageBuilderArray()
        {
            this.companyEmpWageList = new ArrayList();
        }

        public void AddCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            companyEmpWageList.Add(new CompanyEmpWage(company, empRatePerHour, numOfWorkingDays, maxHoursPerMonth));
        }

        public void ComputeEmpWage()
        {
            foreach (CompanyEmpWage companyEmpWage in companyEmpWageList)
            {
                companyEmpWage.setTotalEmpWage(ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.ToString());
            }
        }

        private int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;

            while (totalEmpHrs <= companyEmpWage.maxHoursPerMonth && totalWorkingDays < companyEmpWage.numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs: " + empHrs);
            }
            return totalEmpHrs * companyEmpWage.empRatePerHour;
        }

    }
}