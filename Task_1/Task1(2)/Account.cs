using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2_
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string Owner { get; set; }

        public void Deposit(decimal amount, IAccountLogger accountLogger)
        {
            if (amount >= 0)
            {
                Balance += amount;
                accountLogger.LogDeposit(amount, AccountNumber);
            }
            else
            {
                accountLogger.LogWarning("Invalid amount value");
            }
        }

        public void Withdraw(decimal amount, IAccountLogger accountLogger)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                accountLogger.LogWithdraw(amount, AccountNumber);

            }
            else
            {
                accountLogger.LogWarning("Insufficient balance");
            }
        }
    }
}
