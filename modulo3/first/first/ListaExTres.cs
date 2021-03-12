using System;
using System.Collections.Generic;
using System.Text;

namespace first
{
    class ListaExTres
    {
        static void Main()
        {
            //01
            /*
            Console.WriteLine("Digite sua senha");

            int senha = int.Parse(Console.ReadLine());

            while(senha != 2002)
            {
               Console.WriteLine("Senha Invalida");
               senha = int.Parse(Console.ReadLine());
                
            }
            */

            //02
            Console.WriteLine("Digite S coordenadas x e y");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            int v = 0;
            while ((x > 0 || x < 0) && (y > 0 || y < 0))
            {
                v++;
                Console.WriteLine(v + "º Cordenada");
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());
            }
        }
    }
}
