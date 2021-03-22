using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using modulo15.Aula3.Services;
using modulo15.Aula3.Entities;

namespace modulo15.Aula3
{
    class Program
    {
        static void x()
        {
            List<Product> lista = new List<Product>();

            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split(",");
                string nm = array[0];
                double pr = double.Parse(array[1], CultureInfo.InvariantCulture);
                
                lista.Add(new Product(nm, pr));
            }


            CalcService calc = new CalcService();

            Product mx = calc.Max(lista);
            Console.WriteLine();
            Console.WriteLine("Max: ");
            Console.WriteLine(mx);
        }
    }
}
