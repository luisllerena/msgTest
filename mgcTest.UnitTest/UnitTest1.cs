using mgcTest.BLL;
using mgcTest.BLL.FactoryMethod.Abstract;
using mgcTest.BLL.FactoryMethod.Concrete;
using mgcTest.DAL;
using NUnit.Framework;

namespace mgcTest.UnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }     

        [Test]
        public void TestBLLCalculateHourlyFactory()
        {
            decimal hourlySalary = 50;
            decimal expectedValue = 72000;
            CalculateFactory factory = new CalculareHourlyFactory();
            CalculateMethod calculateMethod = factory.GetCalculateMethod();
            var annualSalary = calculateMethod.CalculatedAnnualSalary(hourlySalary);
            Assert.AreEqual(annualSalary, expectedValue);
        }

        [Test]
        public void TestBLLCalculateMonthlyFactory()
        {
            decimal monthlySalary = 2500000;
            decimal expectedValue = 30000000;
            CalculateFactory factory = new CalculateMonthlyFactory();
            CalculateMethod calculateMethod = factory.GetCalculateMethod();
            var annualSalary = calculateMethod.CalculatedAnnualSalary(monthlySalary);
            Assert.AreEqual(annualSalary, expectedValue);
        }

        [Test]
        public void TestBLLGetEmployees()
        {
            int minimunRecordsCount = 1;
            BusinessService businessService = new BusinessService();
            int employeeCount = businessService.GetEmployees().data.Count;
            Assert.GreaterOrEqual(employeeCount, minimunRecordsCount);
        }
    }
}