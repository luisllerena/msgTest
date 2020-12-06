using mgcTest.BLL.FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace mgcTest.BLL.FactoryMethod.Concrete
{
    public class CalculareHourlyFactory : CalculateFactory
    {
        public override CalculateMethod GetCalculateMethod()
        {
            return new CalculateHourlyAnnualSalary();
        }
    }
}
