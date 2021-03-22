using System;
using System.Collections.Generic;
using System.Text;

namespace modulo15.Aula3.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2");
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Product))
            {
                throw new ArgumentException("Comparing erro: isn't a product");         
            }
            Product p1 = obj as Product;
            return Price.CompareTo(p1.Price);
        }
    }
}
