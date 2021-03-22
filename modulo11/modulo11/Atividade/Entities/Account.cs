using System;
using System.Collections.Generic;
using System.Text;
using modulo11.Atividade.Exceptions;

namespace modulo11.Atividade.Entities
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawlLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withdrawlLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawlLimit = withdrawlLimit;
        }

        public void Deposit(double x)
        {
            Balance = Balance + x;
        }

        public void Withdraw(double x)
        {
            if(WithdrawlLimit < x)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }
            if(x > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }

            Balance = Balance - x;
        }
    }
}
