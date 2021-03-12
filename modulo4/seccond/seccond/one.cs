using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace seccond
{
    class one
    {
        static void x()
        {
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Digite os 3 lados do Triangulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite os 3 lados do Triangulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areax = x.Area();

            double areay = y.Area();

            Console.WriteLine();
            Console.WriteLine(areax.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(areay.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("--------------------------");
            if (areax > areay)
            {
                Console.WriteLine("A área de X é maior, sendo ela:" + areax.ToString("F4", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("A área de Y é maior, sendo ela:" + areay.ToString("F4", CultureInfo.InvariantCulture));
            }
        }
        
    }
}
