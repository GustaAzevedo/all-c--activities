using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace third
{
    class ProdutoTres
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public ProdutoTres()
        {
        }

        public ProdutoTres(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public ProdutoTres(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 5;
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

       public double Preco
        {
            get { return _preco; }
        }

        public int Quantidade
        {
            get { return _quantidade; }
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
