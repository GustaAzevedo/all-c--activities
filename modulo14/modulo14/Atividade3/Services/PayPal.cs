using System;
using System.Collections.Generic;
using System.Text;

namespace modulo14.Atividade3.Services
{
    class PayPal : PagamentoOnline
    {

        public double PagamentoTaxa(double x)
        {
            return x * 0.02;
        }

        public double juro(double x, int mes)
        {
            return (x * 0.01) * mes;
        }
    }
}
