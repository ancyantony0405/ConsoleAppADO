using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleAppBankingSystemEvent.Model;
namespace ConsoleAppBankingSystemEvent.Service
{
    // Declare delegate
    public delegate void TransactionDelegate(int accountNumber, decimal amount);
    public delegate void TransactionEventHandler(string message);

    public class ServiceImplementation : IBank
    {
        public Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();

        // Event for transaction notifications
        public event TransactionEventHandler TransactionNotification;

        protected virtual void OnTransactionNotification(string message)
        {
            TransactionNotification.Invoke(message);
        }

        // Create account
        public void CreateAccount(int accountNumber, decimal initialBalance = 0)
        {
            if (!accounts.ContainsKey(accountNumber))
            {
                accounts[accountNumber] = new BankAccount(accountNumber, initialBalance);
                OnTransactionNotification($"Account {accountNumber} created with balance {initialBalance}");
            }
            else
            {
                OnTransactionNotification("Account already exists");
            }
        }

        // Deposit
        public void Deposit(int accountNumber, decimal amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                accounts[accountNumber].Balance += amount;
                OnTransactionNotification("Deposit successful");
                OnTransactionNotification($"New balance: {accounts[accountNumber].Balance}");
            }
            else
            {
                OnTransactionNotification("Account not found");
            }
        }

        // Withdraw
        public void Withdraw(int accountNumber, decimal amount)
        {
            if (accounts.ContainsKey(accountNumber))
            {
                if (accounts[accountNumber].Balance >= amount)
                {
                    accounts[accountNumber].Balance -= amount;
                    OnTransactionNotification($" Withdrawal successful");
                    OnTransactionNotification($"New balance: {accounts[accountNumber].Balance}");
                }
                else
                {
                    OnTransactionNotification("Insufficient balance");
                }
            }
            else
            {
                OnTransactionNotification("Account not found");
            }
        }

        // Check balance
        public void CheckBalance(int accountNumber)
        {
            if (accounts.ContainsKey(accountNumber))
                OnTransactionNotification($"Account {accountNumber} balance: {accounts[accountNumber].Balance}");
            else
                OnTransactionNotification("Account not found");
        }
    }
}
