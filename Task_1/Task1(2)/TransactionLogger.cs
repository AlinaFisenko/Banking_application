using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2_
{
    public class TransactionLogger
    {
        ILogger logger;

        public TransactionLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void LogTransaction(Transaction transaction)
        {
            logger.Log($"Transaction: {transaction.TransactionType}, Amount: {transaction.Amount}, Date: {transaction.Date}");
        }

    }
}
