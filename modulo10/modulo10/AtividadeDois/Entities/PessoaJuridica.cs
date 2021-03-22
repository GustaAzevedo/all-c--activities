using System;
using System.Collections.Generic;
using System.Text;

namespace modulo10.AtividadeDois.Entities
{
    class PessoaJuridica : Pessoa
    {
        public int NumeroFuncionario { get; set; }

        public PessoaJuridica(string nome, double rendaAnual , int numeroFuncionario) : base(nome, rendaAnual)
        {
            NumeroFuncionario = numeroFuncionario;
        }

        public override double ValorImposto()
        {
            double imposto = 0;
            if(NumeroFuncionario > 10)
            {
                imposto = 0.14;
            }
            else
            {
                imposto = 0.16;
            }

            return RendaAnual * imposto;
        }
    }
}
