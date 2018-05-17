using Business;
using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using Moq;
using System.Threading.Tasks;

namespace BusinessTest
{
    [TestClass]
    public class EmployeeServiceTests
    {
        private EmployeeService _service;
        private Mock<IEmployeesRepository> mock;
        public EmployeeServiceTests()
        {
            mock = new Mock<IEmployeesRepository>();
            _service = new EmployeeService(mock.Object);
        }

        [TestMethod]
        public async Task GetEmployee_ID_1_GetsIEmployeType()
        {
            mock.Setup(p => p.GetEmployee(1)).ReturnsAsync<IEmployeesRepository, EmployeeDTO>(new EmployeeDTO { Id = 1 });
            var result = await _service.GetEmployee(1);
            Assert.IsInstanceOfType(result, typeof(IEmployee));
        }


        [TestMethod]
        public async Task GetEmployee_ID_1_HourlyAnnualSalary()
        {
            decimal hourlysalary = 500;
            decimal Annualsalary = hourlysalary * 12 * 120;
            mock.Setup(p => p.GetEmployee(1)).ReturnsAsync<IEmployeesRepository, EmployeeDTO>(new EmployeeDTO { Id = 1, ContractTypeName = EmployeeContractType.HourlySalaryEmployee, HourlySalary = hourlysalary });
            var result = await _service.GetEmployee(1);
            Assert.IsTrue(result.AnnualSalary.Equals(Annualsalary));
        }

        [TestMethod]
        public async Task GetEmployee_ID_1_MonthlyAnnualSalary()
        {
            decimal monthlysalary = 500;
            decimal Annualsalary = monthlysalary * 12;
            mock.Setup(p => p.GetEmployee(1)).ReturnsAsync<IEmployeesRepository, EmployeeDTO>(new EmployeeDTO { Id = 1, ContractTypeName = EmployeeContractType.MonthlySalaryEmployee, MonthlySalary = monthlysalary });
            var result = await _service.GetEmployee(1);
            Assert.IsTrue(result.AnnualSalary.Equals(Annualsalary));
        }
    }
}
