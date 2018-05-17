using Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
   public interface IEmployeeService
    {
        Task<IEmployee> GetEmployee(int id);
        Task<List<IEmployee>> GetEmployees();
    }
}
