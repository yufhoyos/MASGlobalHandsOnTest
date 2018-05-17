using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Employee : IEmployee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public decimal Salary { get; set; }
        public EmployeeContractType ContractType { get; set; }
        public decimal AnnualSalary { get; set; }
    }
}
