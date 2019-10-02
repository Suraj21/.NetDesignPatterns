using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    /// <summary>
    /// The 'Bridge/Implementor' interface
    /// </summary>
    public interface IPaymentSystem
    {
        void ProcessPayment(string paymentSystem);
    }
}
