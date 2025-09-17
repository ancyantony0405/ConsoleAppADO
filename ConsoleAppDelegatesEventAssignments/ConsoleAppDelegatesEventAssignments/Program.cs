using ConsoleAppBankingSystem.Model;
using ConsoleAppBankingSystem.Utility;

namespace ConsoleAppDelegatesEventAssignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            // sample account
            //bank.CreateAccount(1001, 500);
            Console.Write("Enter Account Number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Initial Balance: ");
            decimal initialBalance = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Account created successfully !");

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

                // Enter account number
                Console.Write("Enter Account Number: ");
                if (!int.TryParse(Console.ReadLine(), out accountNumber))
                {
                    Console.WriteLine("Invalid account number");
                    continue;
                }
                
                switch (choice)
                {
                    case "1":
                        Console.Write("Enter deposit amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                            depositDelegate(accountNumber, depositAmount);
                        else
                            Console.WriteLine("Invalid amount");
                        break;

                    case "2":
                        Console.Write("Enter withdrawal amount: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                            withdrawDelegate(accountNumber, withdrawAmount);
                        else
                            Console.WriteLine("Invalid amount");
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