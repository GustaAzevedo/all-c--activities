using System;
using System.Collections.Generic;
using System.Text;

namespace third
{
    class ProgramaDois
    {
        static void x()
        {
            ProdutoDois x = new ProdutoDois("PS3", 800.00, 5);
            Console.WriteLine("Digite um novo nome para o produto");
            x.SetNome(Console.ReadLine());

            Console.WriteLine(x.GetNome());
            Console.WriteLine(x.GetPreco());
            Console.WriteLine(x.GetQuantidade());
        }
    }
}
