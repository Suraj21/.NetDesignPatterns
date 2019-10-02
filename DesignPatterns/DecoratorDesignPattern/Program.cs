using DecoratorDesignPattern.Component;
using DecoratorDesignPattern.ConcreteComponent;
using DecoratorDesignPattern.ConcreteDecorator;
using DecoratorDesignPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Suzuki();
            CarDecorator decorator = new OfferPrice(car);

            Console.WriteLine(String.Format("Make :{0} Price: {1}" + "Discounted Price: {2}", decorator.Make, decorator.GetPrice().ToString(),
                decorator.GetDiscountedPrice().ToString()));

            Console.ReadLine();
        }
    }
}
