using EmployeeServices.Repositories;
using EmployeeServices.Class;
using NUnit.Framework.Legacy;
using Moq;

// You dont use mock for the class you are testing
// With moq we can create mock objects of the class from the interface.
// [TEARDOWN] : after performing tests, it clears out the memory

namespace EmployeeService.Tests
{
    public class EmployeesServiceTests
    {
        private Mock<IEmployeeServiceRepository> _mockRepo;        // Interface instance to test the class that inherites the interface
        private EmployeeServiceClass _employeeServiceClass = new EmployeeServiceClass(); // EmployeeService instance to test the class directly w/o interface


        [SetUp]
        public void Setup()
        {
            _mockRepo = new Mock<IEmployeeServiceRepository>();
        }

        [Test]
        public void GetName_ReturnsMockedValue()
        {
            _mockRepo.Setup(x => x.GetName("Nikhil")).Returns("Nikhil");

            var result = _mockRepo.Object.GetName("Nikhil");                        // Setup and Object exists only on Mock<T>

            ClassicAssert.AreEqual("Nikhil", result);
        }

        [Test]
        public void GetId_ReturnsID()
        {
            var result = _employeeServiceClass.GetId(1);
            ClassicAssert.AreEqual(1, result);
        }

        [TearDown]
        public void ClearMemory()
        {
            _mockRepo = null;
            _employeeServiceClass = null;

        }
    }
}
