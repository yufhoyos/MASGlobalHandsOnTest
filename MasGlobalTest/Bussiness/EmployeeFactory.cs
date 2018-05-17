using Model;
using System;

namespace Business
{
    public class EmployeeFactory
    {
        public static IEmployee LoadEmployee(EmployeeDTO emp)
        {
            IEmployee newEmployee = new Employee
            {
                Id = emp.Id,
                RoleId = emp.RoleId,
                Name = emp.Name,
                RoleDescription = emp.RoleDescription,
                RoleName = emp.RoleName,
                ContractType = emp.ContractTypeName
            };
            switch (emp.ContractTypeName)
            {
                case EmployeeContractType.HourlySalaryEmployee:
                    newEmployee.Salary = emp.HourlySalary;
                    newEmployee.AnnualSalary = emp.HourlySalary * 12 * 120;
                    break;
                case EmployeeContractType.MonthlySalaryEmployee:
                    newEmployee.Salary = emp.MonthlySalary;
                    newEmployee.AnnualSalary = emp.MonthlySalary * 12;
                    break;
            }
            return newEmployee;
        }
    }
}
