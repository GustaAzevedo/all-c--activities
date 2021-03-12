using System;
using System.Collections.Generic;
using System.Text;

namespace seccond
{
    class ConversorMoeda
    {
        public static double cotacao = 0.06;
        public static double real;

        public static double ConverteDollar(double x,double y)
        {
            double z = x * y;
            real = z + (z *  cotacao);
            return real;
        }
    }
}
