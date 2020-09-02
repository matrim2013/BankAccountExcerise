using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount() { }
        private double Balance = 1000;
        public void Deposit (double d)
        {
            Balance += d;
        }
        public double GetBalance()
        {
            return Balance;
        }
    }
}
