using EmployeeWageComputationDay8;

namespace EmployeeWageComputationDy8 
{
    class program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmployeeWage employeeWage = new EmployeeWage();
            employeeWage.EmployeeAttendence();
        }
    }
}