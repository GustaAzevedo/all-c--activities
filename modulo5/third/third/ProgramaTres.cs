using System;
using System.Collections.Generic;
using System.Text;

namespace third
{
    class ProgramaTres
    {
        static void x()
        {
            ProdutoTres x = new ProdutoTres("PS3", 800.00, 5);
            Console.WriteLine("Digite um novo nome para o produto");
            x.Nome = Console.ReadLine();

            Console.WriteLine(x.Nome);
            Console.WriteLine(x.Preco);
            Console.WriteLine(x.Quantidade);
        }
    }
}
