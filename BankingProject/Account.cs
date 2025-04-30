using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingProject
{
    internal class Account
    {
        int account_number;
        double balance;
        string account_holder;
        public void deposit()
        {
            Console.WriteLine("Enter the Deposit amount");
            double deposit = Convert.ToDouble(Console.ReadLine());
            balance = deposit + balance;
        }
        public void withdraw()
        {
            Console.WriteLine("Enter the Withdraw amount");
            double withdraw = Convert.ToDouble(Console.ReadLine());
        }
    }
}
