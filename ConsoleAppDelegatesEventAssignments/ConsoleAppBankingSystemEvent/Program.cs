using ConsoleAppBankingSystemEvent.Service;
using ConsoleAppBankingSystemEvent.Utility;

namespace ConsoleAppBankingSystemEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ServiceImplementation bank = new ServiceImplementation();

            // Subscribe to event
            bank.TransactionNotification += msg => Console.WriteLine(msg);

            Console.Write("Enter Account Number: ");
            if (!BankValidation.ValidateAccountNumber(Console.ReadLine(), out int accountNumber))
                return;

            Console.Write("Enter Initial Balance: ");
            if (!BankValidation.ValidateAmount(Console.ReadLine(), out decimal initialBalance))
                return;

            bank.CreateAccount(accountNumber, initialBalance);

            // Delegates for transactions
            TransactionDelegate depositDelegate = bank.Deposit;
            TransactionDelegate withdrawDelegate = bank.Withdraw;

            while (true)
            {
                Console.WriteLine("Banking System");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Check Balance");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                if (choice == "4") break;

                Console.Write("Enter Account Number: ");
                if (!BankValidation.ValidateAccountNumber(Console.ReadLine(), out accountNumber))
                    continue;

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter deposit amount: ");
                        if (BankValidation.ValidateAmount(Console.ReadLine(), out decimal depositAmount))
                            depositDelegate(accountNumber, depositAmount);
                        break;

                    case "2":
                        Console.Write("Enter withdrawal amount: ");
                        if (BankValidation.ValidateAmount(Console.ReadLine(), out decimal withdrawAmount))
                            withdrawDelegate(accountNumber, withdrawAmount);
                        break;

                    case "3":
                        bank.CheckBalance(accountNumber);
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
