using System;
using System.Collections.Generic;
using System.IO;


namespace modulo13.aula2
{
    class Programa02
    {
        /// <summary>
        /// 
        ///         Como Acessar o conteúdo dentro de ARQUIVOS
        ///             e ler todas as linhas     
        /// 
        /// </summary>
        static void x()
        {
            string path = @"C:\proj\txt\umAulaUm.txt";

            StreamReader sr = null;
            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
                
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