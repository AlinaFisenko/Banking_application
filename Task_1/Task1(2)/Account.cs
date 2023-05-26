﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task1_2_
{
    public class Account : IAccount
    {
        private readonly string AccountNumber;

        private decimal balance;
        private decimal Balance
        {
            get { return balance; }
            set
            {
                if (value >= 0)
                {
                    balance = value;
                }
            }
        }

        private string Owner { get; set; }

        private readonly ILogger logger;

        private List<Transaction> transactions;

        public Account()
        {
            AccountNumber = "not_set";
            Balance = 0;
            Owner = "not_set";
            logger = new ConsoleLogger();
            transactions = new List<Transaction>();
        }

        public Account(string accountNumber, decimal balance, string owner)
        {
            AccountNumber = accountNumber;
            Balance = balance;
            Owner = owner;
            logger = new ConsoleLogger();
            transactions = new List<Transaction>();
        }

        public Account(string accountNumber, decimal balance, string owner, ILogger logger) : this(accountNumber, balance, owner)
        {
            this.logger = logger;
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0 || AccountNumber.Equals("not_set"))
            {
                logger.Log("Invalid amount value or account number\n");
                return;
            }

            transactions.Add(new Transaction(amount, "Deposit"));
            Balance += amount;
            logger.Log($"Deposited account number: {AccountNumber} balance: {Balance} owner: {Owner}\n");
            ToString();
        }

        public void Withdraw(decimal amount)
        {

            if (amount > Balance || AccountNumber.Equals("not_set"))
            {
                logger.Log("Insufficient balance or invalid account number\n");
                return;
            }

            transactions.Add(new Transaction(amount, "Withdraw"));
            Balance -= amount;
            logger.Log($"Withdrawed account number: {AccountNumber} balance: {Balance} owner: {Owner}\n");
            ToString();

        }


        public override string ToString()
        {
            return $"Account number: {AccountNumber}  balance: {Balance} owner: {Owner}\n";
        }


        public void ShowAllTransactions()
        {
            Console.WriteLine("\n\nTransaction history\n");
            foreach (var item in transactions)
            {
                logger.Log(item.ToString());
                item.ToString();
            }
        }
    }
}
