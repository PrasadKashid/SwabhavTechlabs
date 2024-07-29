using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    internal class AccountManager
    {
        public AccountManager() { }

        List<Account> accounts;
        //select Operation
        public void selectOperations()
        {
            List<Account> accounts = new List<Account>();
            //Deserialize Data --> Extract Data from JSON
            accounts = SerializeDeserialize.DeserializeData();
            Console.WriteLine("Welcome to the banking app!");


            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Select an operation: ");
                Console.WriteLine("1. Add Account ");
                Console.WriteLine("2. Transactions ");
                Console.WriteLine("3. Remove Account ");
                Console.WriteLine("4. Exit");
                int selectOperation;
                while (!int.TryParse(Console.ReadLine(), out selectOperation) || selectOperation < 1 || selectOperation > 4)
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 3.");
                }

                switch (selectOperation)
                {
                    case 1:
                        AddAccount(ref accounts);
                        break;
                    case 2:
                        UpdateOperation(accounts);
                        break;
                    case 3:
                        Console.WriteLine("Enter Account number ");
                        int accountNumber = int.Parse(Console.ReadLine());
                        RemoveAccount(ref accounts, accountNumber);
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            //Serialization of data --> Puts data in JSON
            SerializeDeserialize.SerializeData(accounts);

            Console.WriteLine("Thank you for using the banking app!");
        }

        //Create new account
        public void AddAccount(ref List<Account> accounts)
        {
            Console.WriteLine("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter user name: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter bank name: ");
            string bankName = Console.ReadLine();

            Console.WriteLine("Enter aadhar number: ");
            long aadharNumber = long.Parse(Console.ReadLine());

            Console.WriteLine("Enter balance: ");
            double balance = double.Parse(Console.ReadLine());

            Account newAccount = new Account(accountNumber, userName, bankName, aadharNumber, balance);
            accounts.Add(newAccount);
            Console.WriteLine("Account Created scuccessfully");
        }

        //Remove account 
        public void RemoveAccount(ref List<Account> accounts, int accountNumber)
        {
            bool checkAccount = false;

            for(int i = 0; i<accounts.Count; i++)
            {
                if (accounts[i].AccountNumber == accountNumber)
                {
                    accounts.Remove(accounts[i]);
                    checkAccount = true;
                }
            }
            SerializeDeserialize.SerializeData(accounts);
            if (checkAccount)
            {
                Console.WriteLine("Account Deleted Scuccessfully ");
            }
            else
            {
                Console.WriteLine("Account does not exists");
                Console.WriteLine();
            }
        }



        //Update operation --> Transactions() 
        static void UpdateOperation(List<Account> accounts)
        {
            Console.WriteLine("Enter your account number: ");
            int accNumber = int.Parse(Console.ReadLine());

            foreach (Account account in accounts)
            {
                if (account.AccountNumber == accNumber)
                {
                    Transaction(accounts, account);
                    return;
                }
            }
            Console.WriteLine("Account not found.");
        }

        //Transaction() includes Deposit Withdraw Checkbalance and Print account details
        public static void Transaction(List<Account> accounts, Account accTransaction)
        {
            char choiceAccount = 'y';
            do
            {
                Console.WriteLine("Enter Your Choice: \n1.Deposit \n2.Withdraw \n3.Account Balance \n4.Print Account Details");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the amount to deposit");
                        double depositAmount = double.Parse(Console.ReadLine());
                        //Console.WriteLine(accTransaction.DepositAmount(amount));
                        if (accTransaction.DepositAmount(depositAmount) == true)
                        {
                            Console.WriteLine($"{depositAmount} Deposited Successfully ");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter amount to withdraw ");
                        double withdrawAmount = double.Parse(Console.ReadLine());
                        if (accTransaction.WithdrawAmount(withdrawAmount) == true)
                        {
                            Console.WriteLine($"{withdrawAmount} Withdrawn Successfully ");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Balance");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Your balance is " + accTransaction.CheckBalance(accounts, accTransaction.AccountNumber));
                        break;

                    case 4:
                        Console.WriteLine(accTransaction.PrintAccountDetails(accounts, accTransaction.AccountNumber));
                        Console.WriteLine();

                        break;
                    default:
                        Console.WriteLine("Invalid choice ");
                        continue;
                }
                Console.WriteLine("Do you wish to continue with the same account Y/N ");
                choiceAccount = char.Parse(Console.ReadLine());
            }
            while (choiceAccount == 'Y' || choiceAccount == 'y');
        }
    }
}
