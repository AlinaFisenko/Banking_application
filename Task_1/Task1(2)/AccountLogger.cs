using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2_
{
    public class AccountLogger : IAccountLogger
    {
        ILogger logger;

        public AccountLogger(ILogger logger)
        {
            this.logger = logger;
        }
        public void LogDeposit(decimal amount, string AccountNumber)
        {
            logger.Log($"Deposited {amount} into account {AccountNumber}");
        }

        public void LogWarning(string error)
        {
           logger.Log(error);
        }

        public void LogWithdraw(decimal amount, string AccountNumber)
        {
            logger.Log($"Withdrew {amount} from account {AccountNumber}");
        }
    }
}
