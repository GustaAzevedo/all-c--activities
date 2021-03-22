using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace modulo13.aula1
{
    class Programa
    {
        static void x()
        {
            string sourcePath = @"C:\proj\txt\umAulaUm.txt";
            string targetPath = @"C:\proj\txt\umAulaDois.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] array = File.ReadAllLines(sourcePath);
                foreach(string a in array)
                {
                    Console.WriteLine(a);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
