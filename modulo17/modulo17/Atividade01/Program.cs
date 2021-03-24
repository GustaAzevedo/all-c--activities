using System;
using System.IO;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using modulo17.Atividade01.Entities;
using System.Linq;

namespace modulo17.Atividade01
{
    class Program
    {
        static void x()
        {
            try
            {
                List<Product> produtos = new List<Product>();
                string caminho = @"C:\proj\txt\m17-atividade1.txt";

                using(StreamReader sr = File.OpenText(caminho))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] vet = sr.ReadLine().Split(",");
                        string nm = vet[0];
                        double price = double.Parse(vet[1], CultureInfo.InvariantCulture);
                        produtos.Add(new Product(nm, price));
                    }
                }

                var media = produtos.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
                Console.WriteLine("Enter full file path: " + caminho);
                Console.WriteLine("Average Price: " + media.ToString("F2", CultureInfo.InvariantCulture));

                var nomesDesc =
                     from p in produtos
                     where p.Price < media
                     orderby p.Name descending
                     select p.Name;

                foreach (var i in nomesDesc)
                {
                    Console.WriteLine(i);

                }

            }
            catch (IOException e)
            {
                Console.WriteLine("Error: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
