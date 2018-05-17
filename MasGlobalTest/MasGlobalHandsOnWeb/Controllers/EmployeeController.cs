using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace MasGlobalHandsOnWeb.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _service;
        public EmployeeController(IEmployeeService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<List<IEmployee>> GetEmployees()
        {
            return await _service.GetEmployees();
        }

        [HttpGet("{id}")]
        public async Task<IEmployee> GetEmployee(int id)
        {
            return await _service.GetEmployee(id);
        }

    }
}
