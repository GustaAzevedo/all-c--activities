using System;
using System.Collections.Generic;
using System.Text;
using modulo15.Aula4.Entities;

namespace modulo15.Aula4
{
    class Program
    {
        static void Main()
        {
            Client c1 = new Client()
            {
                Nome = "Zeca", Email = "zeca@gmail.com"
            };
            Client c2 = new Client()
            {
                Nome = "Maria", Email = "maria@gmail.com"
            };

            Console.WriteLine( c1.Equals(c2));
            Console.WriteLine(c1 == c2);
            Console.WriteLine(c1.GetHashCode());
            Console.WriteLine(c2.GetHashCode());
        }
    }
}
