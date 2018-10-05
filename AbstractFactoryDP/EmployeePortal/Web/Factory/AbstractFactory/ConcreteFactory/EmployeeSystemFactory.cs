using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.Factory.AbstractFactory
{
    public class EmployeeSystemFactory
    {
        public IComputerFactory Create(Employee employee)
        {
            IComputerFactory computerFactory = null;
            if(employee.EmployeeTypeID == 1)
            {
                if(employee.JobDescription == "Manager")
                {
                    computerFactory = new MacLaptopFactory();
                }
                else
                {
                    computerFactory = new MacFactory();
                }
            }
            else if (employee.EmployeeTypeID == 2)
            {
                if (employee.JobDescription == "Manager")
                {
                    computerFactory = new DellLaptopFactory ();
                }
                else
                {
                    computerFactory = new DellFactory();
                }
            }

            return computerFactory;
        }
    }
}