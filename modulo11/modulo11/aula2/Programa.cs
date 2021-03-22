using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace modulo11.aula2
{
    class Programa
    {
        public static void x()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(@"C:\Users\Pichau\Documents\SENAC\POO\ola.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (fs != null)
                {
                    fs.Close();
                }
            }
        }
    }
}
