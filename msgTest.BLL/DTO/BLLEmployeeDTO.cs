using mgcTest.BLL.FactoryMethod.Abstract;
using mgcTest.BLL.FactoryMethod.Concrete;
using mgcTest.DTO;

namespace mgcTest.BLL.DTO
{
    public class BLLEmployeeDTO : EmployeeDTO
    {
        public decimal CalculatedAnnualSalary
        {
            get
            {
                if (this.ContractTypeName.Equals("MonthlySalaryEmployee"))
                {
                    CalculateFactory factory = new CalculateMonthlyFactory();
                    CalculateMethod calculateMethod = factory.GetCalculateMethod();
                    return calculateMethod.CalculatedAnnualSalary(this.MonthlySalary);
                }
                else
                {
                    CalculateFactory factory = new CalculareHourlyFactory();
                    CalculateMethod calculateMethod = factory.GetCalculateMethod();
                    return calculateMethod.CalculatedAnnualSalary(this.HourlySalary);
                }
            }
        }
    }
}