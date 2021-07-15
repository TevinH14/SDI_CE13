using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamilton_Tevin_CustomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //fullname 
            Console.WriteLine("please enter your full name");
           string userFullName = Console.ReadLine();
            while (string.IsNullOrWhiteSpace(userFullName))
            {
                Console.WriteLine("\r\nplese don't leave blank\r\nPlease entedr your full name");
                userFullName = Console.ReadLine();
            }
            //checing account 
            Console.WriteLine("\r\nWhat is the starting vaule of your checking account");
            string userCheckString = Console.ReadLine();
            decimal userCheck;
            while (!(decimal.TryParse(userCheckString, out userCheck)))
            {
                Console.WriteLine("\r\nplease dont leave blank and only enter numbers\r\nWhat is the starting vaule of your checking account");
                userCheckString = Console.ReadLine();
            }
            // bank acccount 
            Console.WriteLine("What is the starting vaule of your bank account");
            string userBankString = Console.ReadLine();
            decimal userBank;
            while (!(decimal.TryParse(userBankString, out userBank)))
            {
                Console.WriteLine("\r\nplease dont leave blank and only enter numbers\r\nWhat is the starting vaule of your bank account");
                userBankString = Console.ReadLine();
            }
            BankAccount userBankInfo= new BankAccount(userFullName,userCheck,userBank);           
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("which option would you like to take next\r\nPress 1 if you would like to withdrawal then press enter\r\nPress 2 if you like to deposit then press enter");
                string userChoiceString = Console.ReadLine();
                int userChoice;
                while (!(int.TryParse(userChoiceString, out userChoice) && (userChoice != 1 || (userChoice != 2))))
                {
                    Console.WriteLine("\r\nplease don't leave blank and only enter numbers\r\nwhich option would you like to take next\r\nPress 1 if you would like to withdrawal then press enter\r\nPress 2 if you like to deposit then press 2");
                    userChoiceString = Console.ReadLine();
                }
                string userchange;
                if (userChoice == 1)
                {                   
                    Console.WriteLine("\r\nwhich account would you like to withdrawal from\r\nPress 1 for your checking account\r\npress 2 for your bank account");
                    string userChoice2String = Console.ReadLine();
                    int userChoice2;
                    while (!(int.TryParse(userChoice2String, out userChoice2) && (userChoice2 != 1 || (userChoice2 != 2))))
                    {
                        Console.WriteLine("\r\nplease don't be blank and choose one of the following\r\nwhich account would you like to withdrawal from\r\nPress 1 for your checking account\r\npress 2 for your bank account");
                        userChoice2String = Console.ReadLine();
                    }
                    if (userChoice2 == 1)
                    {
                        Console.WriteLine("How much will you like to withdrawal from your checking account");
                        string  userChangeString = Console.ReadLine();
                        decimal userChange;
                        while (!(decimal.TryParse(userChangeString, out userChange)))
                        {
                            Console.WriteLine("please don't leave this blank and only enter numbers");
                            userChangeString = Console.ReadLine();
                        }
                        if (userBankInfo.GetCheckingAccount() < userChange)
                        {
                            Console.WriteLine("you have insufficient funds");
                        }
                        else
                        {
                            decimal checkChange = userBankInfo.GetCheckingAccount() - userChange;
                            userBankInfo.SetCheckingAccount(checkChange);
                        }
                    }
                    else if (userChoice2 == 2)
                    {
                        Console.WriteLine("How much will you like to withdrawal from your bank account");
                        string userChange1String = Console.ReadLine();
                        decimal userChange1;
                        while (!(decimal.TryParse(userChange1String, out userChange1)))
                        {
                            Console.WriteLine("please don't leave this blank and only enter numbers");
                            userChange1String = Console.ReadLine();
                        }
                        if (userBankInfo.GetBankAccount() < userChange1)
                        {
                            Console.WriteLine("you have insufficient funds");
                        }
                        else
                        {
                            decimal bankChange = userBankInfo.GetBankAccount() - userChange1;
                            userBankInfo.SetBankAccount(bankChange);
                        }
                    }
                }
                else if (userChoice == 2)
                {
                    Console.WriteLine("\r\nwhich account would you like to deposit from\r\nPress 1 for your checking account\r\npress 2 for your bank account");
                    string userChoice3String = Console.ReadLine();
                    int userChoice3 = 0;
                    while (!(int.TryParse(userChoice3String, out userChoice3) && (userChoice3 != 1 || (userChoice3 != 2))))
                    {
                        Console.WriteLine("\r\nplease don't be blank and choose one of the following\r\nwhich account would you like to deposit from\r\nPress 1 for your checking account\r\npress 2 for your bank account");
                        userChoice3String = Console.ReadLine();
                    }
                    if (userChoice3 == 1)
                    {
                        Console.WriteLine("How much will you like to deposit from your checking account");
                        string userChange2String = Console.ReadLine();
                        decimal userChange2;
                        while (!(decimal.TryParse(userChange2String, out userChange2)))
                        {
                            Console.WriteLine("please don't leave this blank and only enter numbers");
                            userChange2String = Console.ReadLine();
                        }                                                                                             
                            decimal checkChange = userBankInfo.GetCheckingAccount() + userChange2;
                            userBankInfo.SetCheckingAccount(checkChange);
                    }
                    else if (userChoice3 == 2)
                    {
                        Console.WriteLine("How much will you like to deposit from your bank account");
                        string userChange3String = Console.ReadLine();
                        decimal userChange3;
                        while (!(decimal.TryParse(userChange3String, out userChange3)))
                        {
                            Console.WriteLine("please don't leave this blank and only enter numbers");
                            userChange3String = Console.ReadLine();
                        }                        
                            decimal bankChange = userBankInfo.GetBankAccount() + userChange3;
                            userBankInfo.SetBankAccount(bankChange);                      
                    }
                }
                Console.WriteLine($"\r\nyour grandtotal is {userBankInfo.UserMoney().ToString("c")}\r\n");                
            }




        }
    }
}
