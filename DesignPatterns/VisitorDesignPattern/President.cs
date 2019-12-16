using System;
using System.Collections.Generic;
using System.Text;

namespace VisitorDesignPattern
{
    class President : Employee
    {
        // Constructor
        public President()
          : base("Dick", 45000.0, 21)
        {
        }
    }
}
