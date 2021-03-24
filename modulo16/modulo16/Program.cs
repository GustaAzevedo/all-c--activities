using System;

namespace modulo16
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2021, 03, 22, 8, 10, 45);
            Console.WriteLine(dt.ElapsedTime());

            string s = "Gustavo de Azevedo Pereira";            
            Console.WriteLine(s.Cut(10));

            double a = 10;
            double b = 20;
            double c = a.Porcentagem();
            Console.WriteLine(c * b);

        }

    }
}
