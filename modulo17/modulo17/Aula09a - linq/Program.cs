using System;
using System.Collections.Generic;
using System.Text;
using modulo17.Aula09a.Entities;
using System.Linq;

namespace modulo17.Aula09a
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
            var r1 = products.Where(x => x.Category.Tier == 1 && x.Price < 900.0);
            Print("Tier 1 and Price < 900", r1);

            Console.WriteLine();
            var rr1 =
                from p in products
                where p.Category.Tier == 1 && p.Price < 900
                select p;
            Print("Tier 1 and Price < 900", rr1);

            //------------------
            Console.WriteLine();
            var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
            Print("Nome dos Produtos da categoria Tools", r2);

            Console.WriteLine();
            var rr2 =
                from p in products
                where p.Category.Name == "Tools"
                select p.Name;
            Print("Nome dos Produtos da categoria Tools", rr2);


            //------------------
            Console.WriteLine();
            var r3 = products.Where(p => p.Name[0] == 'C').Select(p => new { p.Name , p.Price, categoryName = p.Category.Name});
            Print("Produtos que começam com a letra 'C' e objetos anônimos ", r3);

            Console.WriteLine();
            var rr3 =
                from p in products
                where p.Name[0] == 'C'
                select new { p.Name, p.Price, categoryName = p.Category.Name };

            Print("Produtos que começam com a letra 'C' e objetos anônimos ", rr3);


            //-----------------
            Console.WriteLine();
            var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
            Print("Categoria de produtos Tier 1 e ordenar por preço ", r4);

            Console.WriteLine();
            var rr4 =
                from p in products
                where p.Category.Tier == 1
                orderby p.Price, p.Name
                select p;
            Print("Categoria de produtos Tier 1 e ordenar por preço ", rr4);


            //-----------------
            Console.WriteLine();
            var r5 = r4.Skip(2).Take(4);
            Print("Pular 2 elementos e pegar 4 ", r5);

            Console.WriteLine();
            var rr5 = 
                (from p in r4
                select p).Skip(2).Take(4);

            Print("Pular 2 elementos e pegar 4 ", rr5);


            //------------------
            //Cuidando com excessão sem tratar com try catch

            Console.WriteLine();
            var r6 = products.FirstOrDefault();
            Console.WriteLine("Primeiro elemento: " + r6);

            Console.WriteLine();
            var rr6 =
                (from p in products
                 select p).FirstOrDefault();
            Console.WriteLine("Primeiro elemento: " + rr6);


            //-----------------
            Console.WriteLine();
            var r7 = products.Where(p => p.Price > 3000.00).FirstOrDefault();
            Console.WriteLine("Pegando elemento que não exise: " + r7);

            Console.WriteLine();
            var rr7 =
                (from p in products
                 where p.Price > 3000.00
                 select p).FirstOrDefault();
            Console.WriteLine("Pegando elemento que não exise: " + rr7);


            //-----------------
            // Usado somente para elementos únicos
            Console.WriteLine();
            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();
            Console.WriteLine("Pegando elemento Com ID igal a 3: " + r8);

            Console.WriteLine();
            var rr8 =
                (from p in products
                 where p.Id == 3
                 select p).SingleOrDefault();
            Console.WriteLine("Pegando elemento Com ID igal a 3: " + rr8);


            //-----------------
            Console.WriteLine();
            var r9 = products.Where(p => p.Id == 35).SingleOrDefault();
            Console.WriteLine("Pegando elemento Com ID igal a 35 que não existe: " + r9);

            Console.WriteLine();
            var rr9 =
                (from p in products
                 where p.Id == 35
                 select p).SingleOrDefault();
            Console.WriteLine("Pegando elemento Com ID igal a 35 que não existe: " + rr9);

        }
    }
}
