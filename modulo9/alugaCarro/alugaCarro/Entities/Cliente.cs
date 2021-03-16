using System;
using System.Collections.Generic;
using System.Text;

namespace alugaCarro.Entities
{
    class Cliente
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int SemanaAluga { get; set; }
        public Carro Carro { get; set; }

        public Empresa Empresa { get; set; }

        public Cliente()
        {
        }

        public Cliente(string nome, int semanaAluga,  int idade, Empresa empresa)
        {
            Nome = nome;
            Idade = idade;
            Empresa = empresa;
            SemanaAluga = semanaAluga;
        }

        public Cliente(string nome, int idade, int semanaAluga, Carro carro, Empresa empresa)
        {
            Nome = nome;
            Idade = idade;
            SemanaAluga = semanaAluga;
            Carro = carro;
            Empresa = empresa;
        }

        public bool checaIdade()
        {
            bool a;
            if(Idade > 18)
            {
                a = true;
            }
            else
            {
                a = false;
            }
            return a;
        }

        public double Valortotal()
        {
            return Carro.Preco * SemanaAluga;
        }

        public override string ToString()
        {
            return "O cliente: "
                + Nome
                + ", deseja alugar o carro "
                + Carro.Nome
                + ", por "
                + SemanaAluga
                + " semanas. O valor total será: "
                ;
        }
    }
}
