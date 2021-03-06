using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace modulo10.Atividade.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string priceTag()
        {
            return " (Customs fee: $"
                + CustomsFee.ToString("F2", CultureInfo.InvariantCulture)
                + ")";
        }



    }
}
