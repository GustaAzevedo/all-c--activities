using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using modulo11.Atividade.Entities;
using modulo11.Atividade.Exceptions;

namespace modulo11.Atividade
{
    class Program
    {
        static void Main()
        {
           

            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string name = Console.ReadLine();
                Console.Write("Initial balance: ");
                double saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limit: ");
                double limiteSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account p1 = new Account(number, name, saldoInicial, limiteSaque);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                p1.Withdraw(saque);
                Console.WriteLine("New balance: " + p1.Balance);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Error: " + e.Message);
            }
            
            

        }
    }
}
