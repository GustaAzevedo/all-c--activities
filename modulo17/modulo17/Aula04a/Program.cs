using System;
using modulo17.Aula04a.Services;

namespace modulo17.Aula04a
{
    delegate void BinaryNumericOperation(double n1, double n2);
    class Program
    {
        
        static void x()
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowMax;
            op += CalculationService.ShowSum;

            op.Invoke(a, b);
        }
    }
}
