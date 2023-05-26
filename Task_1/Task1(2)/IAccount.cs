using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_2_
{
    public interface IAccount
    {
        public void Withdraw(decimal amount);
        public void Deposit(decimal amount);
    }
}
