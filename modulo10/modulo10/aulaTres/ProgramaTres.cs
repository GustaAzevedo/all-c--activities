using System;
using modulo10.aulaTres.Entities;
namespace Course
{
    class ProgramaTres
    {

        static void X(string[] args)
        {
            Account acc1 = new Account(1001, "gu", 500.00);
            Account acc2 = new SavingsAccount(1001, "gu", 500.00, 0.01);

            acc1.Withdraw(10.0);
            acc2.Withdraw(10.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }

}