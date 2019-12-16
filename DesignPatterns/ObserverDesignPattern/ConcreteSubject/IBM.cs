using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    /// <summary>
    /// The 'ConcreteSubject' class
    /// </summary>
    class IBM : Stock
    {
        // Constructor
        public IBM(string symbol, double price)
          : base(symbol, price)
        {
        }
    }
}
