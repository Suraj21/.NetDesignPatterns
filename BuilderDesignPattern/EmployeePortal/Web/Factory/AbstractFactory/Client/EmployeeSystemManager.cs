using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Factory.AbstractFactory
{
    public class EmployeeSystemManager
    {
        IComputerFactory computerFactory = null;
        public EmployeeSystemManager(IComputerFactory computerFactory)
        {
            this.computerFactory = computerFactory;
        }
        public string GetSystemDetails()
        {
            IBrand brand = computerFactory.Brand();
            IProcessor processor = computerFactory.Processor();
            ISystemType systemType = computerFactory.SystemType();
            string returnValue = string.Format("{0} {1} {2}", brand.GetBrand(), processor.GetProcessor(), systemType.GetSystemType());
            return returnValue;
        }
    }
}