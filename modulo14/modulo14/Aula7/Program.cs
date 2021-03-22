using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using modulo14.Aula7.Entities;

namespace modulo14.Aula7
{
    class Program
    {
        static void Main()
        {
            string caminho = @"C:\proj\txt\aula7.txt";

            try
            {
                using(StreamReader sr = File.OpenText(caminho))
                {
                    List<Employee> list = new List<Employee>();
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));

                    }
                    list.Sort();
                    foreach(Employee l in list)
                    {
                        Console.WriteLine(l);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An Error Ocurred: ");
                Console.WriteLine(e.Message);
            }

        }
    }
}
