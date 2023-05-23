
//To practice using SOLID principles, you can 
//refactor the code by applying the principles mentioned earlier,
//such as creating separate classes for logging,
//following the single responsibility principle,
//introducing interfaces, and decoupling dependencies.


using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}


public interface ILogger
{
    public void Log(string message);

}

public class ConsoleLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}


public interface ITransactionLogger
{
    public void LogTransaction(Transaction transaction);
    public void LogWarning(string error);
}


public class TransactionLogger : ITransactionLogger
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

    public void LogWarning(string error)
    {
        logger.Log("\nError: "+error);
    }
}






public class Account
{
    public string AccountNumber { get; set; }
    public decimal Balance { get; set; }
    public string Owner { get; set; }

    public void Deposit(decimal amount, ITransactionLogger transactionLogger)
    {
        if (amount >= 0)
        {
            Balance += amount;
            transactionLogger.LogTransaction(new Transaction
            {
                Amount = amount,
                Date = DateTime.Now,
                TransactionType = "Deposit"
            });
        }
        else
        {
            transactionLogger.LogWarning("Invalid amount value");
        }

    }

    public void Withdraw(decimal amount, ITransactionLogger transactionLogger)
    {
        if (amount <= Balance)
        {
            Balance -= amount;
            transactionLogger.LogTransaction(new Transaction
            {
                Amount = amount,
                Date = DateTime.Now,
                TransactionType = "Withdraw"
            });
        }
        else
        {
            transactionLogger.LogWarning("Insufficient balance");
        }
    }
}


public class Transaction
{
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public string TransactionType { get; set; }
}