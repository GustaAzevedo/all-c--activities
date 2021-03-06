using System;
using System.Globalization;
using System.Collections.Generic;
using atividade1.Entities;
using atividade1.Entities.Enums;

namespace atividade1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do departamento: ");
            string depName = Console.ReadLine();
            Console.WriteLine("Entre com a data");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Nível (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salarial: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dep = new Departament(depName);

            Worker trabalhador = new Worker(name, level, baseSalary, dep);

            Console.Write("Quantos contratos esse trabalhador tem?: ");
            int contratos = int.Parse(Console.ReadLine());


            for (int i = 1; i <= contratos; i++)
            {
                Console.WriteLine($"Entre com  a {i}° data do contrato: ");
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor Hora: ");
                double valoHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração: ");
                int hour = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valoHora, hour);

                trabalhador.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Entre com o mês e ano para calcular o valor total (MM/YYYY):");
            string mesEano = Console.ReadLine();
            int mes = int.Parse(mesEano.Substring(0, 2));
            int ano = int.Parse(mesEano.Substring(3));
            Console.WriteLine("Nome: " + trabalhador.Name);
            Console.WriteLine("Depatamento: " + trabalhador.Departament.Name);
            Console.WriteLine("Total: " + mesEano + ": " + trabalhador.Income(mes, ano).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
