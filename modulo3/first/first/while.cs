using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace first
{
    class @while
    {
        static void x()
        {
            Console.WriteLine("Digite um número impar");
            int a = int.Parse(Console.ReadLine());
            
            while(a % 2 == 0)
            {
                Console.WriteLine("Digite um número impar");
                a = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Você digitou um número ímpar");
        }
    }
}
