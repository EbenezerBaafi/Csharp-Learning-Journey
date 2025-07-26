using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Debugging
{
    public class BankAccount
    {
        double balance;

        public double Balance
        {
            get {  return balance; }
        }
        public BankAccount(double balance)
        {
            this.balance = balance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > balance)
                return;
            balance -= amount;
        }
     
    }
}
