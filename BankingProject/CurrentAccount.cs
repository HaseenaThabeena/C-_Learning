using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    internal class CurrentAccount : Account
    {
        private double overdraftLimit = 1000;

        public CurrentAccount(string number, string holder, double initialBalance)
            : base(number, holder, initialBalance) { }

        public override void Withdraw(double amount)
        {
            if (amount <= balance + overdraftLimit)
                balance -= amount;
            else
                Console.WriteLine("Withdrawal exceeds overdraft limit.");
            Console.ReadKey();
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine("[Current Account Info]");
            base.DisplayAccountInfo();
        }
    }
}
