using System;
using System.Collections.Generic;
using System.IO;


namespace modulo13.aula2
{
    class Programa2
    {
        /// <summary>
        /// 
        ///         Como Acessar o conteúdo dentro de ARQUIVOS e fecha-los       
        /// 
        /// </summary>
        static void x()
        {
            string path = @"C:\proj\txt\umAulaUm.txt";

            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error ocurred ");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close();
            }
        }
    }
}