using Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
using System.Threading.Tasks;

namespace DataTest
{
    [TestClass]
    public class EmployeesRepositoryTests
    {
        private EmployeesRepository _repository;
        public EmployeesRepositoryTests()
        {
            
        }

        [TestInitialize]
        public void TestInit()
        {
            _repository = new EmployeesRepository();
        }

        [TestMethod]
        public async Task GetEmployee_ID_1_GetsEmployeeDTOType()
        {
            var result = await _repository.GetEmployee(1);
            Assert.IsInstanceOfType(result, typeof(EmployeeDTO));
        }

        [TestMethod]
        public async Task GetEmployee_ID_1_GetsEmployeeInfo()
        {
            var result = await _repository.GetEmployee(1);
            Assert.IsTrue(result.Name.Equals("Juan"));
        }

        [TestMethod]
        public async Task GetEmployees_Return2Records()
        {
            var result = await _repository.GetEmployees();
            Assert.IsTrue(result.Count == 2);
        }
    }
}
