using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdAssignment
{
    internal class Q2A3
    {
        // Properties
        public string AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public decimal Balance { get; private set; }

        // Constructor
        public Q2A3(string accountNumber, string accountHolderName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }

        // Method to deposit money
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"Successfully deposited {amount:C}. New balance: {Balance:C}");
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }

        // Method to withdraw money
        public void Withdraw(decimal amount)
        {
            if (amount > 0)
            {
                if (amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"Successfully withdrew {amount:C}. New balance: {Balance:C}");
                }
                else
                {
                    Console.WriteLine("Insufficient balance.");
                }
            }
            else
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
            }
        }

        // Method to display account details
        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Details:");
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance:C}");
        }
        public static void Integer()
        {
            // Create a new bank account
            Q2A3 account = new Q2A3("123456789", "John Doe", 1000.00m);

            // Display account details
            account.DisplayAccountDetails();

            // Deposit money
            account.Deposit(250.00m);

            // Withdraw money
            account.Withdraw(150.00m);

            // Display updated account details
            account.DisplayAccountDetails();
        }
    }
}
    

