using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;
using System.IO;
using modulo13.Atividade.Entities;

namespace modulo13.Atividade
{
    class Programa
    {
        static void Main()
        {
 
            try
            {


                string caminhoPrincipal = @"C:\proj\txt";
                string arquivoPrincipal = caminhoPrincipal + @"\arqcsv.csv";

                string pastaOut = caminhoPrincipal + @"\out";
                string arquivoCriado = pastaOut + @"\copiaArq.csv";
           

                string[] listaPricipal = File.ReadAllLines(arquivoPrincipal);

                using (StreamWriter sWriter = File.AppendText(arquivoCriado))
                {
                    foreach(string a in listaPricipal)
                    {
                        string[] lSecundaria = a.Split(";");
                        string nome = lSecundaria[0];
                        double preco = double.Parse(lSecundaria[1], CultureInfo.InvariantCulture);
                        int qtdd = int.Parse(lSecundaria[2]);

                        Produto prod = new Produto(nome, preco, qtdd);
                        sWriter.WriteLine(prod.Nome + ";" + prod.PrecoTotal(), CultureInfo.InvariantCulture);
                    }
                }
                
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
