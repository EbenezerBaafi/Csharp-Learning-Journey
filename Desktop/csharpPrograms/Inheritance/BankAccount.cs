using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BankAccount
    {
        public float balance;

        public float Balance
        {
            get { return balance; }
        }
        public BankAccount(float initialBalance)
        {
            this.balance = initialBalance;
        }

        // deposit
        public void Deposit(float amount)
        {
            balance += amount;
        }

        public void Withdraw(float amount)
        {
            if (amount > balance)
                Console.WriteLine("Insufficient balance, can't make this withdrawal");
            else 
                balance -= amount;
        }
    }
}
