using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace third
{
    class RespAtividade
    {
        static void Main()
        {
            ContaBancaria conta;

            Console.WriteLine("Entre com o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o Titular da conta: ");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá deposito inicial (s/n)? ");
            char res = char.Parse(Console.ReadLine());

            if(res == 's' || res == 'S')
            {
                Console.WriteLine("Entre com o valor inicial");
                double depInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(numero, titular, depInicial);
            }

            else
            {
                conta = new ContaBancaria(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da Conta:");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com o saque");
            double dep = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Deposito(dep);
            Console.WriteLine("Dados da Conta atualizados");
            Console.WriteLine(conta);

            Console.WriteLine();
            Console.WriteLine("Entre com o saque");
            double saq = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.Saque(saq);
            Console.WriteLine("Dados da Conta atualizados");
            Console.WriteLine(conta);

        }
    }
}
