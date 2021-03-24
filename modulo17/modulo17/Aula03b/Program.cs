using System;
using modulo17.Aula03b.Services;

namespace modulo17.Aula03b
{
    delegate double BinaryNumericOperation(double n1, double n2);
    class Program
    {
        static void x()
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.Sum;
            BinaryNumericOperation op1 = CalculationService.Max;
            // BinaryNumericOperation op2 = CalculationService.Square; 
            // O Square não é aceito pois ele é diferente do delegate, que possui 2 parametros;
            // Caso não possua 2 parametros e seja double não será aceito, pois é a assinatura do nosso;

            double result = op(a, b);
            double result1 = op1(a, b);

            Console.WriteLine(result);
            Console.WriteLine(result1);
        }
    }
}
