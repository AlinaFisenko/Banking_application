namespace Task1_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ILogger consoleLogger = new ConsoleLogger();

            Dictionary<string, Account> accounts = new Dictionary<string, Account>();


            Account account1 = new Account();
            Account account2 = new Account("number2", 100m, "Alina Fisenko");
            Account account3 = new Account("number3", 200m, "Ivan Ivanenko");

            accounts.Add(account1.AccountNumber, account1);
            accounts.Add(account2.AccountNumber, account2);
            accounts.Add(account3.AccountNumber, account3);

            accounts["not_set"].Withdraw(100m);
            accounts["number2"].Deposit(100m);
            accounts["number2"].Withdraw(300m);
            accounts["number2"].ShowAllTransactions();



        }
    }
}