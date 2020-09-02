using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var userAccount = new BankAccount();
            Console.WriteLine("How much would you like to deposit?");
            double depositAmount = double.Parse(Console.ReadLine());

            userAccount.Deposit(depositAmount);

            Console.WriteLine($"Your new balance is {userAccount.GetBalance()} ");

          
        }
    }
}
