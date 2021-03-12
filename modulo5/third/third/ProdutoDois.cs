using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace third
{
    class ProdutoDois
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public ProdutoDois()
        {
        }

        public ProdutoDois(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public ProdutoDois(string nome, double preco)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = 5;
        }

        public void SetNome(string n)
        {
            if (n != "" && n.Length > 1 && n.Length < 8)
            {
                _nome = n;
            }
        }

        public string GetNome()
        {
            return _nome;
        }

        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
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
