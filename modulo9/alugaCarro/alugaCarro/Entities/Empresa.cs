using System;
using System.Collections.Generic;
using System.Text;

namespace alugaCarro.Entities
{
    class Empresa
    {
        public string Nome { get; set; }
        public Empresa()
        {

        }

        public Empresa(string nome)
        {
            Nome = nome;
        }
    }
}
