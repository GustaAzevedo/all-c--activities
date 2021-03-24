using System;
using System.Linq;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using modulo17.Atividade02.Entities;

namespace modulo17.Atividade02
{
    class Program
    {
        static void Main()
        {
            try
            {
                List<Funcionario> funcionarios = new List<Funcionario>();
                string caminho = @"C:\proj\txt\m17-atividade2.txt";

                using (StreamReader sr = File.OpenText(caminho))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vet = sr.ReadLine().Split(",");
                        string nm = vet[0];
                        string email = vet[1];
                        double salario = double.Parse(vet[2], CultureInfo.InvariantCulture);
                        funcionarios.Add(new Funcionario(nm, email, salario));
                    }
                }

                Console.Write("Enter salary: ");
                double valorEntrada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Email of people whose salary is more than " + valorEntrada + ":");
                var funcionarioSalario =
                    from f in funcionarios
                    where f.Salario > valorEntrada
                    orderby f.Email
                    select f.Email;

                foreach(var f in funcionarioSalario)
                {
                    Console.WriteLine(f);
                }

                Console.WriteLine();
                Console.Write("Digite uma Letra Maiúscula: ");
                char inicial = char.Parse(Console.ReadLine());

                var letraInicial = funcionarios.Where(f => f.Nome[0] == inicial).Sum(f => f.Salario);

                Console.WriteLine("Sum of salary of people whose name starts with " + inicial + ": " + letraInicial);

            }
            catch (IOException e)
            {
                Console.WriteLine("Error: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
