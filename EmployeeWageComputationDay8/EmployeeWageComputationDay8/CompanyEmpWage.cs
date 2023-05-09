using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationDay8
{
        public class CompanyEmpWage
        {
            public string company;
            public int empRatePerHour;
            public int numOfWorkingDays;
            public int maxHoursPerMonth;
            public int totalEmpwage;

            public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMont)
            {
                this.company = company;
                this.empRatePerHour = empRatePerHour;
                this.numOfWorkingDays = numOfWorkingDays;
                this.maxHoursPerMonth = maxHoursPerMont;
            }
            public void setTotalEmpWage(int totalEmpwage)
            {
                this.totalEmpwage = totalEmpwage;
            }
            public string toString()
            {
                return "Total emp Wage for company :" + this.company + "is" + this.totalEmpwage;
            }
        }
}
