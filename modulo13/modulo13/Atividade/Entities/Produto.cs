﻿using System;
using System.Collections.Generic;
using System.Text;

namespace modulo13.Atividade.Entities
{
    class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        public double PrecoTotal()
        {
            return Preco * Quantidade;
        }
    }
}
