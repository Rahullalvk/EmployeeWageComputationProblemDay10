using EmployeeWageComputationDay8;

namespace EmployeeWageComputationDy8 
{
    class program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmpWageBuilderArray empWageBuilder = new EmpWageBuilderArray();
            empWageBuilder.AddCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilder.AddCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilder.ComputeEmpWage();
        }
    }
}