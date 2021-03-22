using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace modulo13.aula3
{
    class Programa1
    {
        static void x()
        {
            string path = @"C:\proj\txt\umAulaUm.txt";
            try
            {
                using(FileStream fs = new FileStream(path, FileMode.Open))
                {
                    using(StreamReader sr = new StreamReader(fs))
                    {
                        while (!sr.EndOfStream)
                        {
                            string l = sr.ReadLine();
                            Console.WriteLine(l);
                        }
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Um erro ocorreu");
                Console.WriteLine(e.Message);
            }
        }
    }
}
