using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using modulo14.Atividade3.Entities;
using System.IO;

namespace modulo14.Atividade3.Services
{
    class RegistroParcelas
    {
        public Contrato Contrato { get; set; }

        public PagamentoOnline _pagamentoOnline { get; set; }

        public RegistroParcelas(Contrato contrato, PagamentoOnline pagamentoOnline)
        {
            Contrato = contrato;
            _pagamentoOnline = pagamentoOnline;
        }

        public void SeparaMeses( int mes)
        {
            double valorParcela = Contrato.ValorTotalContrato / mes;

            for(int i = 1; i <= mes; i++)
            {
                double taxa = _pagamentoOnline.PagamentoTaxa(valorParcela);
                double juros = _pagamentoOnline.juro(valorParcela, i);
                double tota = taxa + juros + valorParcela;
                DateTime dataMensal = Contrato.DataContrato.AddMonths(i).Date;
                Parcela parcela = new Parcela(dataMensal, tota);
                AdicionaParcelas(parcela);
            }
            
        }

        public void AdicionaParcelas(Parcela parcela)
        {
            Contrato.Parcelas.Add(parcela);
        }

    }
}
