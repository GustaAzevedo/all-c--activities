using System;
using System.Collections.Generic;
using System.Text;
using modulo17.Aula09b.Entities;
using System.Linq;

namespace modulo17.Aula09b
{
    class Program
    {
        static void Print<T>(string msg, IEnumerable<T> collection)
        {
            Console.WriteLine(msg);
            foreach(T obj in collection)
            {
                Console.WriteLine(obj);
            }
        }
        static void x()
        {
            Category c1 = new Category() { Id = 1, Name = "Tools" , Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers" , Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics" , Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product() { Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product() { Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product() { Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product() { Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product() { Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product() { Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product() { Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product() { Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product() { Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product() { Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            Console.WriteLine();
            var r10 = products.Max(p => p.Price);
            Console.WriteLine("O maior produto com base no preço: " + r10);


            //-----------------
            Console.WriteLine();
            var r11 = products.Min(p => p.Price);
            Console.WriteLine("O Menor produto com base no preço: " + r11);

            //  Soma
            Console.WriteLine();
            var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
            Console.WriteLine("Soma de preços da categoria 1: " + r12);

            //  MEDIA
            Console.WriteLine();
            var r13 = products.Where(p => p.Category.Id == 1).Average(p => p.Price);
            Console.WriteLine("Media de preços da categoria 1: " + r13);

            Console.WriteLine();
            var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Mei=dia de preços da categoria 5: " + r14);

            //  Agregate
            Console.WriteLine();
            var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0, (x, y) => x + y);
            Console.WriteLine("Soma agregada Categoria 1: " + r15);

            //  Agrupamento
            Console.WriteLine();
            var r16 = products.GroupBy(p => p.Category);

            var rr16 =
                from p in products
                group p by p.Category;
                
            // ou 
            //  foreach(var g in r16)
            foreach (IGrouping<Category, Product> group in r16)
            {
                Console.WriteLine("Category " + group.Key.Name + " :");
                foreach(Product prod in group)
                {
                    Console.WriteLine(prod);
                }
                Console.WriteLine();
            }

            foreach (IGrouping<Category, Product> group in rr16)
            {
                Console.WriteLine("Category " + group.Key.Name + " :");
                foreach (Product prod in group)
                {
                    Console.WriteLine(prod);
                }
                Console.WriteLine();
            }
        }
    }
}
