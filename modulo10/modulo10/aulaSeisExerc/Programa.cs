using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using modulo10.aulaSeisExerc.Entities;
using modulo10.aulaSeisExerc.Entities.Enums;

namespace modulo10.aulaSeisExerc
{
    class Programa
    {
        static void x()
        {
            List<Shape> list = new List<Shape>();
            Console.WriteLine("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or circle (r/c): ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Coloor (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine()); 
                if(ch == 'r' || ch == 'R')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Rectangle(width, height, color));
                }
                else
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circle(raio, color));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Shape Areas:");
            foreach(Shape i in list)
            {
                Console.WriteLine(i.Area().ToString("F2", CultureInfo.InvariantCulture));
            }


        }
    }
}
