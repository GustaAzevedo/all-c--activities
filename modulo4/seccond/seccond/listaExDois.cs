using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace seccond
{
    class listaExDois
    {
        static void x()
        {
            //001
            /*
            Retangulo r = new Retangulo();

            Console.Write("Digite a altura do retângulo: ");
            r.H = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture );
            Console.Write("Digite a Base do retângulo: ");
            r.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Area: " + r.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area: " + r.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Area: " + r.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        */

            //002
            /*
            Funcio f = new Funcio();

            Console.Write("Nome: ");
            f.Name = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f);
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentaSalario(porcentagem);
            Console.WriteLine();

            Console.WriteLine("Dados atualizados: " + f );
            */

            //003
            Aluno a1 = new Aluno();

            Console.WriteLine("Qual o nome do primeiro aluno?");
            a1.Nome = Console.ReadLine();

            Console.WriteLine("Quais as notas do peimeiro aluno");
            a1.N1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.N2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a1.N3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            a1.SomaNota();
            Console.WriteLine("Nota Final = " + a1.NotaFinal.ToString("F2", CultureInfo.InvariantCulture));
            a1.AprovadoReprovado();
            Console.WriteLine(a1.status);



        }
    }
}

