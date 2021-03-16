using System;
using System.Collections.Generic;
using System.Text;

namespace modulo7
{
    class switchCaseA
    {
        static void x()
        {
            Console.WriteLine("Digite um número entre 1 e 7");
            var x = double.Parse(Console.ReadLine());
            string day = "";
            switch (x)
            {
                case 1:
                    day = "Domingo";
                    break;
                case 2:
                    day = "Segunda";
                    break;
                case 3:
                    day = "Terça";
                    break;
                case 4:
                    day = "quarta";
                    break;
                case 5:
                    day = "Quinta";
                    break;
                case 6:
                    day = "Sexta";
                    break;
                case 7:
                    day = "Sábado";
                    break;
                default:
                    day = "NÃO É UM DIA DA SEMANA";
                    break;
            }
            Console.WriteLine("O dia da semana é: " + day );
        }
    }
}
