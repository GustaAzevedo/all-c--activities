using System;
using System.Collections.Generic;
using System.Text;

namespace modulo14.Aula4.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public override string ToString()
        {
            return "Cor do circulo: "
                + Color
                + ", Raio: "
                + Radius
                + ", Area: "
                + Area().ToString("F2");
        }
    }
}
