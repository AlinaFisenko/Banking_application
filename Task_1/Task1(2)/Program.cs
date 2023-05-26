namespace Task1_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ILogger consoleLogger  = new ConsoleLogger();

            List<Account> accounts = new List<Account>
            {
                new Account(),
                new Account("1", 100M, "Alina Fisenko"),
                new Account("2", 5M, "Ivan Ivanenko",consoleLogger )
            };

            //foreach( Account account in accounts )
            //{
            //    Console.WriteLine( account );
            //}

            accounts[2].Withdraw(10M);
            accounts[2].Deposit(10M);
            accounts[2].ShowAllTransactions();


        }
    }
}