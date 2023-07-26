using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment16
{
    internal class Bankaccount
    {
        private static int nextAccountNumber = 1;
        private readonly int accountNumber;
        public int AccountNumber
        {
            get { return accountNumber; }
        }
        private string accountHolderName;
        public string AccountHolderName
        {
            get { return accountHolderName; }
            set { accountHolderName = value; }
        }
        private double balance;
        public Bankaccount(string accountHolderName)
        {
            this.accountNumber = nextAccountNumber++;
            this.accountHolderName = accountHolderName;
            this.balance = 0.0;
        }
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit must be greater than zero");
            }
            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawl amount must be greater than zero");
            }
            if (amount > balance)
            {
                throw new ArgumentException("Insufficient balance");
            }
            balance -= amount;
        }
        public double GetBalance()
        {
            return balance;
        }
    }
}