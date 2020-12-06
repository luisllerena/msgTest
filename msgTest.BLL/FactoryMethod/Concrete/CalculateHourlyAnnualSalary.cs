using mgcTest.BLL.FactoryMethod.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace mgcTest.BLL.FactoryMethod.Concrete
{
    class CalculateHourlyAnnualSalary: CalculateMethod
    {
        private const int monthlyHours = 120;
        private const int monthsNumber = 12;
        public override decimal CalculatedAnnualSalary(decimal salary)
        {
            return monthlyHours * salary * monthsNumber;
        }
    }
}