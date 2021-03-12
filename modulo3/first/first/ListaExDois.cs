using System;
using System.Collections.Generic;
using System.Text;

namespace first
{
    class ListaExDois
    {
        static void x()
        {
            //01
            /*
            int a = int.Parse(Console.ReadLine());
            if (a >= 0)
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
            else
            {
                Console.WriteLine("NEGATIVO");
            }
            */

            //02
            /*
            int b = int.Parse(Console.ReadLine());
            if(b % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("IMPAR");
            }
            */

            //03
            /*
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            if(c % d == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else if (d % c == 0)
            {
                Console.WriteLine("São Multiplos");
            }
            else
            {
                Console.WriteLine("Não são Multiplos");
            }
            */

            //04
            int e = int.Parse(Console.ReadLine()); // hr inicio
            int f = int.Parse(Console.ReadLine()); // hr fim
            int total = 0;
            if(e > f) // se a hor inicial for > que a final 
            {
                total = 24 - (- f + e);
            }
            else
            {
                total = f - e;
            }
            Console.WriteLine($"O JOGO DUROU {total} HORAS");

        }
    }
}
