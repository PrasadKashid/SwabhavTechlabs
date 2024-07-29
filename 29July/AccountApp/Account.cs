using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName {  get; set; }
        public double Balance { get; set; } 
        public long AadharNumber { get; set; }

        public const double MIN_BALANCE = 500;
        public Account() { }
        public Account(int accountNumber, string name, string bankName, long aadharNumber) : this(accountNumber, name, bankName, aadharNumber, MIN_BALANCE)
        {
        }
    
        public Account(int accountNumber, string accHolderName, string bankName, long aadharNumber, double balance) 
        {
            AccountNumber = accountNumber;
            AccountHolderName = accHolderName;
            BankName = bankName;
            Balance = balance;
            AadharNumber = aadharNumber;

            if(balance < MIN_BALANCE)
            {
                Balance = MIN_BALANCE;
            }
            else
            {
                Balance = balance;
            }
        }

        //Deposit Amount 
        public bool DepositAmount(double amount)
        {
            this.Balance += amount;
            return true;
        }

        //Withdraw amount
        public bool WithdrawAmount(double amount)
        {
            if (Balance < MIN_BALANCE) {
                return false;
            }
            else
            {
                Balance -= amount;
                return true;
            }
        }

        //Return available balance 
        public  string CheckBalance(List<Account> accounts, int accountNumber)
        {
            foreach(Account account in accounts)
            {
                if (account.AccountNumber == accountNumber){
                    return "Account Balance is "+account.Balance;
                }
            }
            return "Account Not found ";

        }

        //Print account Information
        public string PrintAccountDetails(List<Account> accounts, int accountNumber)
        {
            //return ("Account number : " + accounts.AccountNumber + "\nUser name: " + account.AccountHolderName + "\nBank Name :" + account.BankName + "\nBalance: " + account.Balance + "\nAadhar NUmber :" + account.AadharNumber);
            foreach (Account account in accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    return ("Account number : " + AccountNumber + "\nUser name: " + AccountHolderName + "\nBank Name :" + BankName + "\nBalance: " + Balance + "\nAadhar NUmber :" + AadharNumber);
                }
            }
            return null;
        }
    }
}
