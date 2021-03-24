using System;
using System.Collections.Generic;
using System.Text;
using modulo17.Aula05a.Entities;

namespace modulo17.Aula05a
{
    class Program
    {
        static void X()

            //  Predicate é um Delegate que  recebe um objeto do tipo T
            //  e retorna um valor Booleano
        {
            List<Product> prod = new List<Product>();

            prod.Add(new Product("Tv", 2500.00));
            prod.Add(new Product("Mouse", 90.00));
            prod.Add(new Product("Tablet", 1030.00));
            prod.Add(new Product("SSD 500GB", 600.00));

            // prod.RemoveAll(p => p.Price <= 100);
            prod.RemoveAll(PTest);

            foreach(Product i in prod)
            {
                Console.WriteLine(i);
            }
        }

        public static bool PTest(Product p)
        {
            return p.Price <= 100;
        }

    }
}
