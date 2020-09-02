using System;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var userAccount = new BankAccount(500);
            
            userAccount.Deposit();
            
            userAccount.Withdraw();
            
            Console.WriteLine($"Your new balance is {userAccount.GetBalance(), 0:c} ");
            // In the Main method, create an instance of the PersonalInformation class and ask the user to input their phone number, 
            //then display the newly formatted phone number(NumberFormatted) to the user

            var userAbe = new PersonalInformation();
            Console.WriteLine("What is your phone number?");
            userAbe.NumberFormatted = Console.ReadLine();
            Console.WriteLine($"Your phone number has been recorded as {userAbe.NumberFormatted}");



    }
    }
}
