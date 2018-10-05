using DecoratorDesignPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.ConcreteComponent
{
    public sealed class Hyundai : ICar
    {
        public string Make => "HatchBack";

        public double GetPrice()
        {
            return 8000000;
        }
    }
}
