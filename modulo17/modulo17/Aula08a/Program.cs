using System;
using System.Linq;
using System.Collections.Generic;

namespace modulo17.Aula08a
{
    class Program
    {
        static void x()
        {

            //  Especificar a fonte de dados
            int[] numbrs = new int[] { 2, 3, 4, 5 };

            //   Definir a expressão Query
            IEnumerable<int> result = numbrs
                .Where(x => x % 2 == 0)
                .Select(x => x * 10);

            //  Executar the Query
            foreach(int x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}
