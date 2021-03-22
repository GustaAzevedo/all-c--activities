using System;
using System.Collections.Generic;
using System.Text;

namespace modulo15.Aula2
{
    class Program
    {
        static void x()
        {
            PrintService<string> ps = new PrintService<string>();

            Console.Write("How many values? ");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                ps.AddValue(x);
            }

            ps.Print();
            Console.Write("First: " + ps.First());
            
        }
    }
}
