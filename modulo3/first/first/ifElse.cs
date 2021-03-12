using System;
using System.Collections.Generic;
using System.Text;

namespace first
{
    class ifElse
    {
        static void x(string[] args)
        {
            Console.WriteLine("Digite um número e veja se é par ou impar");
            int a = int.Parse(Console.ReadLine());

            if(a % 2 == 0)
            {
                Console.WriteLine(a + " é um número Par");
            }
            else
            {
                Console.WriteLine(a + " é um número Impar");
            }
        }
    }
}
