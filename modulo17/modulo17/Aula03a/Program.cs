using System;
using modulo17.Aula03a.Services;

namespace modulo17.Aula03a
{
    class Program
    {
        static void x()
        {
            double a = 10;
            double b = 12;
            double result = CalculationService.Max(a, b);
            double result1 = CalculationService.Square(b);
            double result2 = CalculationService.Sum(a, b);
            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
