using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2_
{
    public interface IAccountLogger
    {
        public void LogWithdraw(decimal amount, string AccountNumber);
        public void LogDeposit(decimal amount, string AccountNumber);
        public void LogWarning(string error);

    }
}
