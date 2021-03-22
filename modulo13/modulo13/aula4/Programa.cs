using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace modulo13.aula4
{
    class Programa
    {
        static void x()
        {
            string sourcePath = @"C:\proj\txt\umAulaUm.txt";
            string targetPath = @"C:\proj\txt\umAulaTwo.txt";

            try
            {
                string[] array = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string x in array)
                    {
                        sw.WriteLine(x.ToUpper());
                    }
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("Erro: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
