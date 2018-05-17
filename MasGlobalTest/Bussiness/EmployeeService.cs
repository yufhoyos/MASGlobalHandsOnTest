using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Model;

namespace Business
{
    public class EmployeeService : IEmployeeService
    {
        private IEmployeesRepository _repository;
        public EmployeeService(IEmployeesRepository repository)
        {
            _repository = repository;
        }
        public async Task<IEmployee> GetEmployee(int id)
        {
            EmployeeDTO employeeDTO = await _repository.GetEmployee(id);
            return EmployeeFactory.LoadEmployee(employeeDTO);
        }

        public async Task<List<IEmployee>> GetEmployees()
        {
            List<EmployeeDTO> employeesDTO = await _repository.GetEmployees();
            return employeesDTO.Select(e => EmployeeFactory.LoadEmployee(e)).ToList();
        }
    }
}
