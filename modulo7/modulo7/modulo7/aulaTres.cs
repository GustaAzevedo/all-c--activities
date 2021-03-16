using System;
using System.Collections.Generic;
using System.Text;

namespace modulo7
{
    class aulaTres
    {
        static void x()
        {
            double preco = 34.5;
            double desconto;
            if (preco < 20.0)
            {
                desconto = preco * 0.1;
            }
            else
            {
                desconto = preco * 0.05;
            }
            Console.WriteLine(desconto);
            Console.WriteLine();


            //if
            double precoUm = 34.5;
            double desconto1 = (precoUm < 20.0) ? precoUm * 0.1 : precoUm * 0.05;
            Console.WriteLine(desconto1);


        }
    }
}
