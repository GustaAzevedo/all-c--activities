using System;

namespace first
{
    class Program
    {
        static void x(string[] args) //trocar para Main quando for usar
        {
            SByte x = 100; //DOT.NET
            sbyte xx = 100; //C#
            Console.WriteLine(x);
            Console.WriteLine(xx);

            byte n1 = 255;
            //Só pode colocar números entre 0 e 255
            Console.WriteLine(n1);

            int n2 = 545644549;
            Console.WriteLine(n2);

            long n3 = 54564454554549L;
            Console.WriteLine(n3);

            bool finish = false;
            Console.WriteLine(finish);

            char letra = '\u00B6';
            char genero = 'F';
            Console.WriteLine(genero);
            Console.WriteLine(letra);

            float n4 = 5.5f;
            Console.WriteLine(n4);

            double n5 = 5.5;
            Console.WriteLine(n5);

            string name = "Gustavo";
            Console.WriteLine(name);

            object pessoa1 = "Ferraz";
            object idadePessoa1 = 19;
            Console.WriteLine(pessoa1);
            Console.WriteLine(idadePessoa1);


        }
    }
}
