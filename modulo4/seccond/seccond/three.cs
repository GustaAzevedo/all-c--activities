using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace seccond
{
    class three
    {

        static void x()
        {
            Console.WriteLine("Qual o raio do seu círculo");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Calculadora.Circunferencia(r);
            Console.WriteLine("A circunferência é: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Calculadora.Volume(r);
            Console.WriteLine("O volume é: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O Valor de PI: " + Calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));

        }


        /*
        static double Pi = 3.14;
        static void Main()
        {
            Console.WriteLine("Qual o raio do seu círculo");
            double r = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circunferencia(r);
            Console.WriteLine("A circunferência é: " + circ.ToString("F2", CultureInfo.InvariantCulture));

            double volume = Volume(r);
            Console.WriteLine("O volume é: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O Valor de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));

        }

        static double Circunferencia(double x)
        {
            return 2.0 * Pi * x;
        }

        static double Volume(double x)
        {
            return 4.0 / 3.0 * Pi * x * x * x;
        }
        */
    }
}
