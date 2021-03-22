using System;
using System.Collections.Generic;
using System.Text;

namespace modulo15.Aula1
{
    class Program
    {
        static void x()
        {
            PrintService ps = new PrintService();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                ps.AddValue(x);
            }

            ps.Print();
            Console.Write("First: " + ps.First());
            
        }
    }
}
