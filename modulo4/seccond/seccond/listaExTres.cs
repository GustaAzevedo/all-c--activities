using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace seccond
{
    class listaExTres
    {
        static void Main()
        {
            Console.WriteLine("Digite o Valor da cotação atual do Dollar");
            double cotacaoAtual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite quantos dollars você quer comprar");
            double dollar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double ValorReal = ConversorMoeda.ConverteDollar(cotacaoAtual ,dollar);
            Console.WriteLine("Valor a ser pago em reais = " + ValorReal.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
