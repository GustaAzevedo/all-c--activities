using System;
using System.Collections.Generic;
using System.Text;

namespace modulo10.AtividadeDois.Entities
{
    class PessoaFisica : Pessoa
    {
        public double GastoSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastoSaude) : base(nome, rendaAnual)
        {
            GastoSaude = gastoSaude;
        }

        public override double ValorImposto()
        {
            double imposto = 0;
            if(RendaAnual < 20000.00)
            {
                imposto = 0.15;
            }
            else
            {
                imposto = 0.25;
            }

            return (RendaAnual * imposto) - (GastoSaude * 0.5);
        }
    }
}
