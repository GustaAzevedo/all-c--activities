using System;
using System.Globalization;
namespace seccond
{
    class Produto
    {
        public string Name;
        public double Price;
        public int Qtd;

        public double ValorTotal()
        {
            return Price * Qtd;
        }

        public void AdicionaProdutos(int qtdd)
        {
            Qtd += qtdd;
        }

        public void RemoveProdutos(int qtdd)
        {
            Qtd -= qtdd;
        }

        public override string ToString()
        {

            return Name
                + " $ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Qtd
                + " Unidades, Total: $"
                + ValorTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
