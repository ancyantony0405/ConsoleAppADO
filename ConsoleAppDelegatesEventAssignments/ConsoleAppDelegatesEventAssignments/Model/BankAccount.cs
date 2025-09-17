using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBankingSystem.Model
{
    // Declare a delegate
    public delegate void TransactionDelegate(int accountNumber, decimal amount);

    // BankAccount class
    public class BankAccount
    {
        // Field
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }

        // Default constructor
        public BankAccount()
        {
            
        }

        // Parameterized construction
        public BankAccount(int accountNumber, decimal initialBalance = 0)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        // Deposit method
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposit successful");
            Console.WriteLine($"New balance: {Balance}");
        }

        // Withdraw method
        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine("Withdrawal successful");
                Console.WriteLine($"New balance: {Balance}");
            }
        }

        // CheckBalance method
        public void CheckBalance()
        {
            Console.WriteLine($"Account {AccountNumber} balance: {Balance}");
        }
    }
}