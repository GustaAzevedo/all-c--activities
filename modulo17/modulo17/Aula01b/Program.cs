using System;
using System.Collections.Generic;
using System.Text;
using modulo17.Aula01b.Entities;

namespace modulo17.Aula01b
{
    class Program
    {
        static void x()
        {
            List<Product> prod = new List<Product>();

            prod.Add(new Product("Tv", 2500.00));
            prod.Add(new Product("Notebook", 4500.00));
            prod.Add(new Product("Celular", 1300.00));

            //  Comparison<Product> comp = CompProducts;  //    Delegate 2
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()); //   Delegate 3


            //  Qualquerm uma das formas está correto
            prod.Sort(comp); //  Delegate 2 e 3
            // prod.Sort(CompProducts); // Delegate 1

            foreach (Product i in prod)
            {
                Console.WriteLine(i);
            }
        }

        //  Delegate 1
        //static int CompProducts(Product p1, Product p2)
        //{
        //    return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
        //}
    }
}
