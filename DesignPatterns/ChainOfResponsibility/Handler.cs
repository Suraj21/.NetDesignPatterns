using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    /// <summary>
    /// The Handler abstract class, contains a member that holds the next handler in the chain and an associated
    /// method to set this successor. It is also an abstract method that must be implementd by concrete classes to handle 
    /// the requests or pass it to the next object in the pipeline
    /// </summary>
    public abstract class Approver
    {
        //Loan Event
        public EventHandler<LoanEventArgs> LoanEvent;

        public abstract void LoanHandler(object sender, LoanEventArgs eventArgs);

        public Approver()
        {
            LoanEvent += LoanHandler;
        }

        public void ProcessRequest(Loan loan)
        {
            OnLoan(new LoanEventArgs { Loan = loan });
        }

        public virtual void OnLoan(LoanEventArgs loanEventArgs)
        {
            LoanEvent?.Invoke(this, loanEventArgs);
        }

        //gets or sets the next approver
        public Approver Successor { get; set; }
    }

    public class Clerk: Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs eventArgs)
        {
            if(eventArgs.Loan.Amount < 25000)
            {
                Console.WriteLine("{0} approved request# {1}", this.GetType().Name, eventArgs.Loan.Number);
            }
            else if(Successor != null)
            {
                Successor.LoanHandler(this, eventArgs);
            }
        }
    }

    public class AssistantManager : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs eventArgs)
        {
            if (eventArgs.Loan.Amount < 45000)
            {
                Console.WriteLine("{0} approved request# {1}", this.GetType().Name, eventArgs.Loan.Number);
            }
            else if (Successor != null)
            {
                Successor.LoanHandler(this, eventArgs);
            }
        }
    }

    public class Manager : Approver
    {
        public override void LoanHandler(object sender, LoanEventArgs eventArgs)
        {
            if (eventArgs.Loan.Amount < 100000)
            {
                Console.WriteLine("{0} approved request# {1}", this.GetType().Name, eventArgs.Loan.Number);
            }
            else if (Successor != null)
            {
                Successor.LoanHandler(this, eventArgs);
            }
        }
    }
}
