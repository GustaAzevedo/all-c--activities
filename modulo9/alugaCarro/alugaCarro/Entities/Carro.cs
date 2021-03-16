using System;
using System.Collections.Generic;
using alugaCarro.Entities.Enums;

namespace alugaCarro.Entities
{
    class Carro
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public CarroCategoria Categoria { get; set; }

        public Carro()
        {

        }

        public Carro(string nome, double preco, CarroCategoria categoria)
        {
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
        }


    }
}
