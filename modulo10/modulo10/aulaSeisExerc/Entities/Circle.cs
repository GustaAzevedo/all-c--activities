using System;
using System.Collections.Generic;
using System.Text;
using modulo10.aulaSeisExerc.Entities.Enums;

namespace modulo10.aulaSeisExerc.Entities
{
    class Circle : Shape
    {
        public double Radious { get; set; }

        public Circle(double radious, Color color) : base(color)
        {
            Radious = radious;
        }

        public override double Area()
        {
            return Math.PI * Radious * Radious;
        }
    }
}
