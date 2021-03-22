using System;
using System.Collections.Generic;
using System.Text;
using modulo14.Aula5.Enums;

namespace modulo14.Aula5.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }
        public abstract double Area();
    }
}
