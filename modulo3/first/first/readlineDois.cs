using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace first
{
    class readlineDois
    {
        static void g(string[] args)
        {
            Console.WriteLine("Digite o Seu nome completo");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] array = Console.ReadLine().Split(' ');
            string sobrenome = array[0];
            int idade = int.Parse(array[1]);
            float altura = float.Parse(array[2], CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("------------------------");
            Console.WriteLine();
            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
