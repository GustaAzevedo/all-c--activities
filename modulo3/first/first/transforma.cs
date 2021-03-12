using System;
using System.Collections.Generic;
using System.Text;

namespace first
{
    class transforma
    {
        static void e(string[] args)
        {

            /*
            float b = 5.35f;
            double a = b;
            Console.WriteLine(a);

            int x = 2;
            int y = 289;
            int z = 288;

            long soma = y % x;
            Console.WriteLine(soma);
            */

            // froma de bascara
            double a = 1.0, b = -3.0, c = -4.0;

            double delta = Math.Pow(b, 2.0) -4.0 * a * c;

            double raizP = (-b + Math.Sqrt(delta)) / (2.0 * a);

            double raizN = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(raizP);
            Console.WriteLine(raizN);

        }
    }
}
