using System;
using System.Collections.Generic;
using System.Text;
using modulo17.Aula07a.Entities;
using System.Linq;

namespace modulo17.Aula07a
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

            List<string> result = prod.Select(UpperProduct).ToList();   // Forma 1

            Func<Product, string> func = UpperProduct;  // Forma 2
            List<string> result1 = prod.Select(func).ToList();  // Forma 2

            Func<Product, string> func2 = p => p.Name.ToUpper(); // Forma 3 - sem a funcção estática
            List<string> result2 = prod.Select(func).ToList();

            // Forma 1
            foreach (string i in result)
            {
                Console.WriteLine(i);
            }

            // Forma 2
            foreach (string i in result1)
            {
                Console.WriteLine(i);
            }

            // Forma 3
            foreach(string i in result2)
            {
                Console.WriteLine(i);
            }

        }

        // Forma 1 e 2
        static string UpperProduct(Product p)
        {
            return p.Name.ToUpper();
        }
    }
}
