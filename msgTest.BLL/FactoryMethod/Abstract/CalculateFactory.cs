using System;
using System.Collections.Generic;
using System.Text;

namespace mgcTest.BLL.FactoryMethod.Abstract
{
    //Creator abstract class
    public abstract class CalculateFactory
    {
        public abstract CalculateMethod GetCalculateMethod();
    }
}
