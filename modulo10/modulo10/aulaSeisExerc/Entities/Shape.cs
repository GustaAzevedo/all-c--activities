using System;
using System.Collections.Generic;
using System.Text;
using modulo10.aulaSeisExerc.Entities.Enums;

namespace modulo10.aulaSeisExerc.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area();
    }
}
