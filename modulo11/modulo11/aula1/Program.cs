using System;
using System.Collections.Generic;
using System.Text;

namespace modulo11.aula1
{
    class Program
    {
        static void x()
        {

            try
            {
                Console.WriteLine("Digite um número");
                int n1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite outro número");
                int n2 = int.Parse(Console.ReadLine());
                int result = n1 / n2;
                Console.WriteLine();
                Console.WriteLine(result);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is not allowed");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Format error! " + e.Message);
            }

        }
    }
}
