using System;

namespace StateDesignPattern
{
    class Program
    {
        /// <summary>
        /// This real-world code demonstrates the State pattern which allows an Account to behave differently 
        /// depending on its balance. The difference in behavior is delegated to State objects called RedState, 
        /// SilverState and GoldState. These states represent overdrawn accounts, starter accounts, and accounts 
        /// in good standing.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Open a new account
            Account account = new Account("Jim Johnson");

            // Apply financial transactions
            account.Deposit(500.0);
            account.Deposit(300.0);
            account.Deposit(550.0);
            account.PayInterest();
            account.Withdraw(2000.00);
            account.Withdraw(1100.00);

            // Wait for user

            Console.ReadKey();
        }
    }
}
