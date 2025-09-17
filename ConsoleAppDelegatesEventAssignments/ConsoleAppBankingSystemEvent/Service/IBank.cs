using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBankingSystemEvent.Service
{
    public interface IBank
    {
        void CreateAccount(int accountNumber, decimal initialBalance = 0); // Account creation
        void Deposit(int accountNumber, decimal amount); // Deposit amount
        void Withdraw(int accountNumber, decimal amount); // Withdraw amount
        void CheckBalance(int accountNumber); // Check the balance
    }
}
