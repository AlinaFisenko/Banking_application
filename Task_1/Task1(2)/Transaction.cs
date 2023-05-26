using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2_
{
    public class Transaction
    {
        private decimal Amount { get; set; }
        private DateTime Date { get; set; }
        private string TransactionType { get; set; }

        public Transaction(decimal amount, string transactionType)
        {
            Amount = amount;
            Date = DateTime.Now;
            TransactionType = transactionType;
        }

        public override string ToString()
        {
            return $"TransactionType: {TransactionType}  amount: {Amount} date: {Date}\n";
        }
    }
}
