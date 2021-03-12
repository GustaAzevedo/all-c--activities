using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace first
{
    class ListaExUm
    {
        static void x(string[] args)
        {
            //01
            /*
            int a = int.Parse(Console.ReadLine());
            int a2 = int.Parse(Console.ReadLine());
            int a3 = a + a2;
            Console.WriteLine(a3);
            */

            //02
            /*
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double tt = 3.14159;
            double area = tt * Math.Pow(b, 2.0);
            Console.WriteLine(area.ToString("F4", CultureInfo.InvariantCulture));
            */

            //03
            /*
            int c0 = 5;
            int c1 = 6;
            int c2 = -7;
            int c3 = 8;
            int soma = c0 * c1 - c2 * c3;
            Console.WriteLine(soma) ;
            */

            //04
            /*
            int d1 = int.Parse(Console.ReadLine());
            double d2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double d3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double soma = d2 * d3;
            Console.WriteLine($"NUMBER = {d1}");
            Console.WriteLine("Salary = U$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
            */

            //05
            int e1 = int.Parse(Console.ReadLine());
            int e2 = int.Parse(Console.ReadLine());
            double e3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int e4 = int.Parse(Console.ReadLine());
            int e5 = int.Parse(Console.ReadLine());
            double e6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double multiplica1 = e2 * e3;
            double multiplica2 = e5 * e6;

            double soma = multiplica1 + multiplica2;

            Console.WriteLine("VALOR A PAGAR: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
            

        }
    }
}
