using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverDesignPattern
{
    /// <summary>
    /// The 'Observer' interface
    /// </summary>
    interface IInvestor
    {
        void Update(Stock stock);
    }
}
