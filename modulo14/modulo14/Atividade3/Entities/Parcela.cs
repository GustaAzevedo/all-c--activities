using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace modulo14.Atividade3.Entities
{
    class Parcela
    {
        public DateTime DataParcela { get; set; }
        public double PrecoParcela { get; set; }

        public Parcela(DateTime dataParcela, double precoParcela)
        {
            DataParcela = dataParcela;
            PrecoParcela = precoParcela;
        }

        public override string ToString()
        {
            return DataParcela.ToString("dd/MM/yyyy")
                + " - "
                + PrecoParcela.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
