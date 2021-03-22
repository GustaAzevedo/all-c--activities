using System;
using System.Collections.Generic;
using System.Text;
using modulo14.Aula4.Entities;
using modulo14.Aula4.Enums;

namespace modulo14.Aula4
{
    class Programa
    {
        static void x()
        {
            Shape s1 = new Circle()
            {
                Color = Color.Black,
                Radius = 2.0
            };
            Shape s2 = new Rectangle()
            {
                Altura = 4.2,
                Largura = 3.5,
                Color = Color.White
            };

            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
        
    }
}
