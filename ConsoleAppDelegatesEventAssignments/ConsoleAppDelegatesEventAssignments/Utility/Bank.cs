using ConsoleAppBankingSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBankingSystem.Utility
{
    // Bank class
    public class Bank
    {
        public Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        // CreateAccount method
        public void CreateAccount(int accountNumber, decimal initialBalance = 0)
        {
            if (!accounts.ContainsKey(accountNumber))
            {
                accounts[accountNumber] = new BankAccount(accountNumber, initialBalance);
                Console.WriteLine($"Account {accountNumber} created with balance {initialBalance}");
            }
            else
            {
                Console.WriteLine("Account already exists");
            }
        }

        // Deposit method
        public void Deposit(int accountNumber, decimal amount)
        {
            if (accounts.ContainsKey(accountNumber))
                accounts[accountNumber].Deposit(amount);
            else
                Console.WriteLine("Account not found");
        }

        // Withdraw method
        public void Withdraw(int accountNumber, decimal amount)
        {
            if (accounts.ContainsKey(accountNumber))
                accounts[accountNumber].Withdraw(amount);
            else
                Console.WriteLine("Account not found");
        }

        // CheckBalance method
        public void CheckBalance(int accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
                accounts[accountNumber].CheckBalance();
            else
                Console.WriteLine("Account not found");
        }
    }
}