using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Schema;

namespace BankEncapsulation
{
    public class BankAccount
    {
        
        private double balance = 0;
        public BankAccount(double amount) 
        {
            balance = amount;
        }

        public void Deposit ()
        {
            double depositAmount;
            bool isNumber;
            do
            {
                Console.WriteLine("How much would you like to deposit?");
                isNumber = double.TryParse(Console.ReadLine(), out depositAmount);

            } while (isNumber == false);

            balance += depositAmount;
            
        }

        public void Withdraw()
        {
            double withdrwalAmount;
            bool isNumber;
            do
            {
                Console.WriteLine($"You current balance is {balance,0:c}");
                Console.WriteLine("How much would you like to withdraw?");
                
                isNumber = double.TryParse(Console.ReadLine(), out withdrwalAmount);

                while (withdrwalAmount > balance)
                {
                    Console.WriteLine("Insufficent Funds");
                    Console.WriteLine("How much would you like to withdraw?");

                    isNumber = double.TryParse(Console.ReadLine(), out withdrwalAmount);
                }

            } while (isNumber == false);

            balance -= withdrwalAmount;
            
        }

        public double GetBalance()
        {
            return balance;
        }

    }
}
