using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace seccond
{
    class two
    {
        static void X()
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados dos produtos: ");
            Console.Write("Nome: ");
            p.Name = Console.ReadLine();
            Console.Write("Preço: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade de produto em estoque: ");
            p.Qtd = int.Parse(Console.ReadLine());

            Console.WriteLine();       
            Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine();

            Console.Write("Adicione a quantidade de produtos que desejar: ");
            int entra = int.Parse(Console.ReadLine());
            p.AdicionaProdutos(entra);
            Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine();

            Console.Write("Adicione a quantidade de produtos que desejar: ");
            int sai = int.Parse(Console.ReadLine());
            p.RemoveProdutos(sai);
            Console.WriteLine("Dados do Produto" + p);



        }
    }
}
