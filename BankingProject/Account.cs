using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    internal class Account
    {
        private string accountNumber;
        private string accountHolder;
        protected double balance;

        public Account(string number, string holder, double initialBalance)
        {
            accountNumber = number;
            accountHolder = holder;
            balance = initialBalance;
        }

        public virtual void Deposit(double amount)
        {
            if (amount > 0)
                balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount > 0 && amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("Insufficient balance or invalid amount.");
            Console.ReadKey();

        }

        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine($"Account: {accountNumber}, Holder: {accountHolder}, Balance: {balance:C}");
            Console.ReadKey();

        }
    }
}
