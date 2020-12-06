using mgcTest.BLL.FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace mgcTest.BLL.FactoryMethod.Concrete
{
    public class CalculateMonthlyFactory : CalculateFactory
    {
        public override CalculateMethod GetCalculateMethod()
        {
            return new CalculateMonthlyAnnualSalary();
        }
    }
}