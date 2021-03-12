using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace first
{
    class funcao
    {
        static void x()
        {
            Console.WriteLine("Quem é o mais pesado?");
            double p1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double p2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double p3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double maisGordo = Peso(p1, p2, p3);
            Console.WriteLine($"{maisGordo} é o mais gordo");

        }

        static double Peso(double a, double b , double c)
        {
            double g = 0;

            if(a > b && a > c)
            {
                g = a;
            } else if( b > c)
            {
                g = b;
            }
            else
            {
                g = c;
            }

            return g;
        }
    }
}
