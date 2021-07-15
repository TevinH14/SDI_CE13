using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamilton_Tevin_CustomClass
{
    class BankAccount
    {
        string mUserFullName;
        decimal mCheckingAccount;
        decimal mBankAccount;

        public BankAccount(string _userFullName ,decimal _checkingAccount , decimal _bankAccount)
        {
            Console.WriteLine($"\r\nWelcome {_userFullName} your Bank account is now active\r\n");
            mUserFullName = _userFullName;
            mCheckingAccount = _checkingAccount;
            mBankAccount = _bankAccount;
        }

        


        
        public string GetUserFullName()
        {
            return mUserFullName;
        }
        public void SetUserFullName(string _userFullName)
        {

        }

        public decimal GetCheckingAccount()
        {
            return mCheckingAccount;
        }
        public void SetCheckingAccount(decimal _checkingAccount)
        {
            mCheckingAccount = _checkingAccount;
        }

        public decimal GetBankAccount()
        {
            return mBankAccount;
        }
        public void SetBankAccount(decimal _bankAccount)
        {
            mBankAccount = _bankAccount;
        }
       
        //method to add checking and bank account 
        public decimal UserMoney()
        {
            decimal grandTotal = mCheckingAccount + mBankAccount;
            return grandTotal;
        }
    }
}
