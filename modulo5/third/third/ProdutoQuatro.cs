using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace third
{
    class ProdutoQuatro
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public ProdutoQuatro()
        {
        }

        public ProdutoQuatro(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public ProdutoQuatro(string nome, double preco)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != "" && value.Length > 1 && value.Length < 8)
                {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
