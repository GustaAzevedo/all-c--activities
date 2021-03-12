using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace first
{
    class treinoDois
    {
        static void c(string[] args)
        {
            //  Apresentação 
            string cumprimento = "Bom dia";
            string nome = "Gustavo de Azevedo";
            long saldo = 25000000000;
            float carteira = 3500.4580f;
            sbyte idade = 17;

            Console.Write(cumprimento);
            Console.WriteLine(" , Tudo Bem?");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Me chamo " + nome);
            Console.Write("Eu no ano de 2024 consegui acumular ");
            Console.Write(saldo);
            Console.WriteLine("$ de Dollars");
            Console.Write("Possuo na minha carteira agora: ");
            Console.WriteLine(carteira.ToString("F2", CultureInfo.InvariantCulture) + "$"); // troca o , por . 
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Olá, eu sou o {0}, tenho {1} anos, possuo um patrimônio líquido de {2} Dolares, mas só estou com {3:F2} reais na carteira agora", nome, idade, saldo, carteira);
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"My name is {nome}, I'm {idade} and i have {saldo}");
        }
    }
}
