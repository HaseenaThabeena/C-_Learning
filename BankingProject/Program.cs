using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> accounts = new List<Account>
            {
                new SavingsAccount("SA001", "Alice", 1000),
                new CurrentAccount("CA001", "Bob", 500)
            };

            foreach (var acc in accounts)
            {
                acc.DisplayAccountInfo();
                acc.Deposit(200);
                acc.Withdraw(300);
                acc.DisplayAccountInfo();
                Console.WriteLine();
            }

            SavingsAccount sa = accounts[0] as SavingsAccount;
            sa.AddInterest();
            sa.DisplayAccountInfo();
        }
    }
}
