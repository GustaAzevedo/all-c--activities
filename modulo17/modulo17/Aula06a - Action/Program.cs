using System;
using System.Collections.Generic;
using System.Text;
using modulo17.Aula06a.Entities;

namespace modulo17.Aula06a
{
    class Program
    {
        static void x()


        {
            List<Product> prod = new List<Product>();

            prod.Add(new Product("Tv", 2500.00));
            prod.Add(new Product("Mouse", 90.00));
            prod.Add(new Product("Tablet", 1030.00));
            prod.Add(new Product("SSD 500GB", 600.00));

            // Action<Product> act = UpdatePrice; // ou
            Action<Product> act = p => { p.Price += p.Price * 0.1; };

            prod.ForEach(act); // ou
            // prod.ForEach(UpdatePrice); // ou

            foreach(Product i in prod)
            {
                Console.WriteLine(i);
            }
        }

        //public static void UpdatePrice(Product p)
        //{
        //     p.Price += p.Price * 0.1;
        //}

    }
}
