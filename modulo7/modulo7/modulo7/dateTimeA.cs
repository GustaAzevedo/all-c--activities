using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace modulo7
{
    class dateTimeA
    {
        static void x()
        {
            DateTime d1 = DateTime.Now;

            //Demo - construtores
            DateTime d2 = new DateTime(2000, 8, 15);
            DateTime d3 = new DateTime(2000, 8, 15, 13, 5, 58);
            DateTime d4 = new DateTime(2000, 8, 15, 13, 5, 58, 275);

            //Demo - Now, UtcNow, Today
            DateTime d5 = DateTime.Now;
            DateTime d6 = DateTime.UtcNow;
            DateTime d7 = DateTime.Today;

            //Demo - Parse
            DateTime d8 = DateTime.Parse("2000-08-15");
            DateTime d9 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime d10 = DateTime.Parse("15/08/2000");
            DateTime d11 = DateTime.Parse("15/08/2000 13:05:58");

            //Demo - ParseExact (você formata seu horario)
            DateTime d12 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d13 = DateTime.ParseExact("15/08/2000 13:05:58", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);


            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);
            Console.WriteLine();

            //Demo - construtores
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine();

            //Demo - Now, UtcNow, Today
            Console.WriteLine(d5);
            Console.WriteLine(d6);
            Console.WriteLine(d7);
            Console.WriteLine();

            //Demo - Parse
            Console.WriteLine(d8);
            Console.WriteLine(d9);
            Console.WriteLine(d10);
            Console.WriteLine(d11);
            Console.WriteLine();

            //Demo - ParseExact
            Console.WriteLine(d12);
            Console.WriteLine(d13);

        }
    }
}
