using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace third
{
    class AtividadeUm
    {
        static void X()
        {
            Console.Write("Entre o número da conta: ");
            int conta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nome = (Console.ReadLine());
            Console.Write("Haverá depósito inicial (s/n)? ");
            char deposito = char.Parse(Console.ReadLine());                       

            ContaCliente c1 = new ContaCliente(nome, conta, deposito  );
          
            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1);

            Console.Write("Entre um valor para depósito: ");
            c1.ValorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(c1);

            Console.Write("Entre um valor para depósito: ");
            c1.ValorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine(c1);


        }
    }
}
