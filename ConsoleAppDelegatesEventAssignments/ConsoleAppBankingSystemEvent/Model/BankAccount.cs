using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBankingSystemEvent.Model
{
    public class BankAccount
    {
        // Field
        public int AccountNumber { get; set; }
        public decimal Balance { get; set; }

        // Default contructor
        public BankAccount()
        {
            
        }

        // Parameterized constructor
        public BankAccount(int accountNumber, decimal initialBalance = 0)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }
    }
}
