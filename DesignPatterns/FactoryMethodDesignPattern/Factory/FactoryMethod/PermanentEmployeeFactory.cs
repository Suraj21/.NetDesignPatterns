using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;
using Web.Models;

namespace Web.Factory.FactoryMethod
{
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee employee) : base(employee)
        {

        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager permanentEmployeeManager = new PermanentEmployeeManager();
            _emp.HouseAllowance = permanentEmployeeManager.GetHouseAllowance();
            return permanentEmployeeManager;
        }
    }
}