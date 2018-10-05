using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Factory.AbstractFactory
{
    public class MacFactory : IComputerFactory
    {
        public IBrand Brand()
        {
            return new MAC();
        }

        public IProcessor Processor()
        {
            return new I7();
        }

        public virtual ISystemType SystemType()
        {
            return new Desktop();
        }
    }

    public class MacLaptopFactory : MacFactory
    {
        public override ISystemType SystemType()
        {
            return new Laptop();
        }
    }
}