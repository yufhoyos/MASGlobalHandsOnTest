using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public interface IEmployeesRepository
    {
        Task<EmployeeDTO> GetEmployee(int id);
        Task<List<EmployeeDTO>> GetEmployees();
    }
}
