using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee employee)
        {
            BaseEmployeeFactory baseEmployeeFactory = null;

            if(employee.EmployeeTypeID == 1)
            {
                baseEmployeeFactory = new PermanentEmployeeFactory(employee);
            }
            if (employee.EmployeeTypeID == 2)
            {
                baseEmployeeFactory = new ContractEmployeeFactory(employee);
            }

            return baseEmployeeFactory;
        }
    }
}