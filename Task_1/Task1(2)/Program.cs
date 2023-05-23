namespace Task1_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            ILogger logger = new ConsoleLogger();
            AccountLogger accountLogger = new AccountLogger(logger);

            Account account = new Account();
            account.Deposit(2000, accountLogger);
            account.Withdraw(1000, accountLogger);
            account.Withdraw(1500, accountLogger);
            account.Deposit(-2000, accountLogger);

            TransactionLogger transactionLogger = new TransactionLogger(logger);

            Transaction transaction = new Transaction();
            transaction.Amount = 1000;
            transaction.Date = DateTime.Now;
            transaction.TransactionType = "Withdraw";
            transactionLogger.LogTransaction(transaction);


        }
    }
}