using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// Avoid coupling the sender of a request to its receiver by giving more than one object a chance to handle the request. 
/// Chain the receiving objects and pass the request along the chain until an object handles it.
/// </summary>
namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver rahul = new Clerk();
            Approver rohit = new AssistantManager();
            Approver manoj = new Manager();

            rahul.Successor = rohit;
            rohit.Successor = manoj;

            var loan = new Loan { Number = 20345, Amount = 24000, Purpose = "Bike Loan" };
            rahul.ProcessRequest(loan);

             loan = new Loan { Number = 20346, Amount = 56000, Purpose = "car Loan" };
            rohit.ProcessRequest(loan);

             loan = new Loan { Number = 20347, Amount = 1000000, Purpose = "plane Loan" };
            manoj.ProcessRequest(loan);
        }
    }
}
