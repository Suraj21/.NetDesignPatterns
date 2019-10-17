using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
