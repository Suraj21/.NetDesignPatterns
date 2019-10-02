using DecoratorDesignPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern.Decorator
{
    public abstract class CarDecorator : ICar
    {
        private ICar Car;
        public CarDecorator(ICar car)
        {
            Car = car;
        }
        public string Make => Car.Make;

        public double GetPrice()
        {
            return Car.GetPrice();
        }
        public abstract double GetDiscountedPrice();
    }
}
