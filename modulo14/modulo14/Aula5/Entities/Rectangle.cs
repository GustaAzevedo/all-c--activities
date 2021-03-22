using System;
using System.Collections.Generic;
using System.Text;

namespace modulo14.Aula5.Entities
{
    class Rectangle : AbstractShape
    {

        public double Altura { get; set; }
        public double Largura { get; set; }
        public override double Area()
        {
            return Altura * Largura;
        }

        public override string ToString()
        {
            return "Cor do Retângulo: "
                + Color
                + ", Area: "
                + Area().ToString("F2");
        }

    }
}
