using System;
using System.Collections.Generic;
using System.Text;

namespace seccond
{
    class listExOne
    {
        static void X()
        {
            //01
            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();

            p1.name = "Maria";
            p1.age = 17;

            p2.name = "Carlos Alberto";
            p2.age = 19;

            if (p1.age > p2.age)
            {
                Console.WriteLine($"A pessoa {p1.name} é mais velha do que {p2.name}");
            }
            else
            {
                Console.WriteLine($"A pessoa {p2.name} é mais velha do que {p1.name}");
            }

            //02
            Funcionario t1, t2;
            t1 = new Funcionario();
            t2 = new Funcionario();

            t1.name = "Felipe Asunsão";
            t1.salary = 12000.00;

            t2.name = "Rita Bernabett";
            t2.salary = 23500.80;

            double media = (t1.salary + t2.salary) / 2;

            Console.WriteLine();
            Console.WriteLine($"{t1.name} ganha {t1.salary:F2}");
            Console.WriteLine($"{t2.name} ganha {t2.salary:F2}");
            Console.WriteLine();
            Console.WriteLine($"A média salarial é: {media:F2}");

        }
    }
}
