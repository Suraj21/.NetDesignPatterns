using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern
{
    class Director : Employee
    {
        // Constructor
        public Director()
          : base("Elly", 35000.0, 16)
        {
        }
    }
}
