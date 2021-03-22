using System;
using System.Collections.Generic;
using System.Text;

namespace modulo14.Atividade3.Services
{
    class Nubank : PagamentoOnline
    {

        public double PagamentoTaxa(double x)
        {
            return x * 0.04;
        }

        public double juro(double x, int mes)
        {
            return (x * 0.02) * mes;
        }
    }
}
