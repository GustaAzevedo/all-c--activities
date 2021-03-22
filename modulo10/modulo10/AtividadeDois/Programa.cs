using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using modulo10.AtividadeDois.Entities;

namespace modulo10.AtividadeDois
{
    class Programa
    {
        static void Main()
        {
            List<Pessoa> lista = new List<Pessoa>();
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write("Individual or company (i/c)?: ");
                char ch = char.Parse(Console.ReadLine());
                if(ch == 'i')
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double receitaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Health expenditures: ");
                    double gastoSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new PessoaFisica(nome, receitaAnual, gastoSaude));
                }
                else
                {
                    Console.Write("Name: ");
                    string nome = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double receitaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Number of employees: ");
                    int numFunc = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(nome, receitaAnual, numFunc));
                } 
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double total = 0;
            foreach (Pessoa i in lista)
            {
                Console.WriteLine(i.Nome + ": $" + i.ValorImposto().ToString("F2", CultureInfo.InvariantCulture));
                total += i.ValorImposto();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
