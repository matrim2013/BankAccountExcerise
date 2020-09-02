using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var userAccount = new BankAccount(500);
            

            userAccount.Deposit();
            Console.WriteLine("   ");
            userAccount.Withdraw();
            Console.WriteLine("  ");
            Console.WriteLine($"Your new balance is {userAccount.GetBalance(), 0:c} ");


          
        }
    }
}
