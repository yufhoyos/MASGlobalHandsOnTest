﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public interface IEmployee
    {
        int Id { get; set; }
        string Name { get; set; }
        int RoleId { get; set; }
        string RoleName { get; set; }
        string RoleDescription { get; set; }
        decimal Salary { get; set; }
        EmployeeContractType ContractType { get; set; }
        decimal AnnualSalary { get; set; }
    }
}
