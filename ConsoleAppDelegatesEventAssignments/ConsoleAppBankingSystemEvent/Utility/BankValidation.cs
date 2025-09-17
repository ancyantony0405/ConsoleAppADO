using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppBankingSystemEvent.Utility
{
    internal class BankValidation
    {
        public static bool ValidateAccountNumber(string input, out int accountNumber)
        {
            if (int.TryParse(input, out accountNumber) && accountNumber > 0)
            {
                return true;
            }
            Console.WriteLine("Invalid account number");
            return false;
        }

        public static bool ValidateAmount(string input, out decimal amount)
        {
            if (decimal.TryParse(input, out amount) && amount > 0)
            {
                return true;
            }
            Console.WriteLine("Amount must be greater than 0");
            return false;
        }
    }
}
