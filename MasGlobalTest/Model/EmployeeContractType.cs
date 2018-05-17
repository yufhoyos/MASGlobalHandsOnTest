using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Model
{
    public enum EmployeeContractType
    {
        [EnumMember(Value = "Hourly Salary")]
        HourlySalaryEmployee = 1,
        [EnumMember(Value = "Monthly Salary")]
        MonthlySalaryEmployee = 2
    }
}
