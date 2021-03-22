using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace modulo13.aula5
{
    class Programa
    {
        static void x()
        {
            string path = @"C:\Users\Pichau\Documents\animes";

            try
            {
                // ou var f = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                IEnumerable<string> f = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Folders: ");
                foreach(string i in f)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
                //  ou var a  = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                IEnumerable<string> a = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Files: ");
                foreach (string i in a)
                {
                    Console.WriteLine(i);
                }

                Directory.CreateDirectory(path + @"\newFolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
