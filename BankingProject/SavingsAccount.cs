using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    internal class SavingsAccount : Account
    {
        private double interestRate = 0.05;

        public SavingsAccount(string number, string holder, double initialBalance)
            : base(number, holder, initialBalance) { }

        public void AddInterest()
        {
            balance += balance * interestRate;
        }

        public override void DisplayAccountInfo()
        {
            Console.WriteLine("[Savings Account Info]");
            base.DisplayAccountInfo();
        }
    }

   
}
