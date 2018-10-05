using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;
using Web.Models;

namespace Web.Factory.FactoryMethod
{
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee employee) : base(employee)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager contractEmployeeManager = new ContractEmployeeManager();
            _emp.MedicalAllowance = contractEmployeeManager.GetMedicalAllowance();
            return contractEmployeeManager;
        }
    }
}