using System;
using System.Collections.Generic;
using System.Text;
using modulo14.Aula4.Enums;

namespace modulo14.Aula4.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
