using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using modulo14.Atividade3.Entities;
using modulo14.Atividade3.Services;

namespace modulo14.Atividade3
{
    class Programa
    {
        static void x()
        {
            Console.WriteLine("Entre com os dados do contrato");
            Console.Write("Número: ");
            int numContrato = int.Parse(Console.ReadLine());
            Console.Write("Data (dd/mm/yyyy): ");
            DateTime dataCotrato = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Valor do Contrato: ");
            double valorContrato = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Número de parcelas: ");
            int parcelas = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(numContrato, dataCotrato, valorContrato);

            RegistroParcelas registroParcelas = new RegistroParcelas(contrato, new Nubank());
            registroParcelas.SeparaMeses(parcelas);

            Console.WriteLine("Parcelas");
            for(int i = 0; i < parcelas; i++)
            {
                Console.WriteLine(registroParcelas.Contrato.Parcelas[i].DataParcela.Date + " - " + registroParcelas.Contrato.Parcelas[i].PrecoParcela.ToString("F2", CultureInfo.InvariantCulture));
            }

        }
    }
}
