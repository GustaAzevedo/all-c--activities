using System;
using System.Collections.Generic;
using System.Text;

namespace modulo14.Atividade2.Services
{
    class BrazilTaxService : ITaxService
    {
        public double Tax(double amout)
        {
            if(amout <= 100.00)
            {
                return amout * 0.2;
            }
            else
            {
                return amout * 0.15;
            }
        }
    }
}
