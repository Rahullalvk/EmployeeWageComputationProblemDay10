using EmployeeWageComputationDay8;

namespace EmployeeWageComputationDy8 
{
    class program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.addCompanyEmpWage("DMart", 20, 2, 10);
            empWageBuilderArray.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilderArray.computeEmpWage();
        }
    }
}