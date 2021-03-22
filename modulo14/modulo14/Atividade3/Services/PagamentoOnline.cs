using System;
using System.Collections.Generic;
using System.Text;

namespace modulo14.Atividade3.Services
{
    interface PagamentoOnline
    {
        public double PagamentoTaxa(double x);

        public double juro(double x, int mes);
    }
}
