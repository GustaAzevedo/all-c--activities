using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using modulo10.Atividade.Entities;

namespace modulo10.Atividade
{
    class Programa
    {
        static void x()
        {
            List<Product> list = new List<Product>();

            Console.WriteLine("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} date: ");
                Console.Write("Common, used or imported (c/u/i)?: ");
                char categ = char.Parse(Console.ReadLine());
                string nome;
                double price;
                if (categ == 'c' || categ == 'C')
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Product(nome, price));
                    
                }
                else if (categ == 'u' || categ == 'U')
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    price = double.Parse(Console.ReadLine());
                    Console.Write("Data de fabricação: ");
                    DateTime data = DateTime.Parse(Console.ReadLine());
                    list.Add(new UsedProduct(nome, price, data));
                }
                else if(categ == 'i' || categ == 'I')
                {
                    Console.Write("Nome: ");
                    nome = Console.ReadLine();
                    Console.Write("Preço: ");
                    price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Taxa: ");
                    double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new ImportedProduct(nome, price, fee));
                }
                
            }

            foreach (Product li in list)
            {
                Console.WriteLine($"{li.Name} $ {li.Price} {li.priceTag()}");
            }
        }
    }
}
