using System;
using System.Collections.Generic;
using System.Text;

namespace modulo14.Atividade3.Entities
{
    class Contrato
    {
        public int NumContrato { get; set; }
        public DateTime DataContrato { get; set; }
        public double ValorTotalContrato { get; set; }
        public List<Parcela> Parcelas { get; set; } = new List<Parcela>();

        public Contrato(int numContrato, DateTime dataContrato, double valorTotalContrato)
        {
            NumContrato = numContrato;
            DataContrato = dataContrato;
            ValorTotalContrato = valorTotalContrato;

        }

    }
}
