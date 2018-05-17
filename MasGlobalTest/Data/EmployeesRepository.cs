using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Model;
using Newtonsoft.Json;

namespace Data
{
    public class EmployeesRepository : ApiRepository, IEmployeesRepository
    {
private static List<EmployeeDTO> allEmployees;
        public EmployeesRepository()
        {

        }
        private async Task LoadEmployees()
        {
            /// For Real I'll probably use polly with the new HttpclientFactory
            var stringResult = await client.GetStringAsync("Employees");
            allEmployees = JsonConvert.DeserializeObject<List<EmployeeDTO>>(stringResult);
        }
        public async Task<EmployeeDTO> GetEmployee(int id)
        {
            if (allEmployees == null)
            {
                await LoadEmployees();
            }

            return allEmployees.FirstOrDefault(e => e.Id == id);
        }

        public async Task<List<EmployeeDTO>> GetEmployees()
        {
            if (allEmployees == null)
            {
                await LoadEmployees();
            }

            return allEmployees;
        }
    }
}
