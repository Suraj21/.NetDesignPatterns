﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeDesignPattern
{
    /// <summary>
    /// Refined Abstraction
    /// </summary>
    public class CardPayment : Payment
    {
        public override void MakePayment()
        {
            _IPaymentSystem.ProcessPayment("Card Payment");
        }
    }
}
