using System;
using System.IO;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace modulo13.aula7
{
    class Programa
    {
        static void x()
        {
            string caminho = @"C:\Users\Pichau\Documents";

            byte[] array = File.ReadAllBytes(caminho + @"\Currículo.pdf");

            byte[] copia = new byte[50 * 1024];

            for(int i = 0; i < 50 * 1024; i++)
            {
                copia[i] = array[i];
                Console.WriteLine(copia[i]);
            }
            File.WriteAllBytes(@"C:\Users\Pichau\Documents\gx.pdf", copia);
            Console.WriteLine("Copia feita");
            
        }
    }
}
