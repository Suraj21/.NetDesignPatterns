using System;

namespace ChainOfResponsibility
{
    /// <summary>
    ///Loan Event argument holds loan info 
    /// </summary>
    public class LoanEventArgs : EventArgs
    {
        internal Loan Loan { get; set; }
    }
}
