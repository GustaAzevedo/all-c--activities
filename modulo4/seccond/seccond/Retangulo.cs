using System;
using System.Globalization;

namespace seccond
{
    class Retangulo
    {
        public double B;
        public double H;
        public double area;
        public double P;
        public double d;


        public double Area()
        {
            area = B * H;
            return area;
        }

        public double Perimetro()
        {
            P = (B * 2) + (H * 2);
            return P;
        }

        public double Diagonal()
        {
            double b = Math.Pow(B, 2);
            double h = Math.Pow(H, 2);

            d = Math.Sqrt(b + h);
            return d;
        }


    }
}
