using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter Account Holder Name");
                    string accountHolderName = Console.ReadLine();
                    Bankaccount account = new Bankaccount(accountHolderName);
                    Console.WriteLine($"Account Number: {account.AccountNumber}");
                    Console.WriteLine($"Account Holder Name: {account.AccountHolderName}");
                    Console.WriteLine($"Account Balance: {account.GetBalance()}");

                    Console.WriteLine("Enter the amount to be deposited");
                    double depositAmount = double.Parse(Console.ReadLine());
                    account.Deposit(depositAmount);
                    Console.WriteLine($"Balance after deposit: {account.GetBalance()}");

                    Console.WriteLine("Enter the amount to be withdrwan");
                    double withdrawAmount = double.Parse(Console.ReadLine());
                    account.Withdraw(withdrawAmount);
                    Console.WriteLine($"Balance after withdrawl: {account.GetBalance()}");

                    Console.WriteLine("Do you want to continue? (Y/N)");
                    string response = Console.ReadLine().ToUpper();
                    if (response != "Y")
                    {
                        break;
                    }
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}