using System;

namespace Model
{
    public class EmployeeDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public EmployeeContractType ContractTypeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
        public decimal HourlySalary { get; set; }
        public decimal MonthlySalary { get; set; }
    }
}
