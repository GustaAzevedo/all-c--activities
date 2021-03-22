using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace modulo13.aula3
{
    class Programa2
    {
        static void x()
        {
            string path = @"C:\proj\txt\umAulaUm.txt";
            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string l = sr.ReadLine();
                        Console.WriteLine(l);
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}
