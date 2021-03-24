using System;
using System.Collections.Generic;
using System.Text;
using modulo17.Aula01a.Entities;

namespace modulo17.Aula01a
{
    class Program
    {
        static void x()
        {
            List<Product> prod = new List<Product>();

            prod.Add(new Product("Tv", 2500.00));
            prod.Add(new Product("Notebook", 4500.00));
            prod.Add(new Product("Celular", 1300.00));

            prod.Sort();

            foreach(Product i in prod)
            {
                Console.WriteLine(i);
            }
        }
    }
}
