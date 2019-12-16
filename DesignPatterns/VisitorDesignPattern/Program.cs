using System;

namespace VisitorDesignPattern
{
    class Program
    {
        /// <summary>
        /// This real-world code demonstrates the Visitor pattern in which two objects traverse a list
        /// of Employees and performs the same operation on each Employee. The two visitor objects define
        /// different operations -- one adjusts vacation days and the other income.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Setup employee collection

            Employees e = new Employees();
            e.Attach(new Clerk());
            e.Attach(new Director());
            e.Attach(new President());

            // Employees are 'visited'

            e.Accept(new IncomeVisitor());
            e.Accept(new VacationVisitor());

            // Wait for user

            Console.ReadKey();
        }
    }
}
