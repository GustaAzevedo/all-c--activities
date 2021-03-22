using System;
using System.Collections.Generic;
using System.Text;
using modulo14.Aula6A.Devices;

namespace modulo14.Aula6A
{
    class Programa
    {
        static void x()
        {
            Printer p = new Printer()
            {
                SerialNumber = 540
            };
            p.ProcessDoc("My letter");
            p.Print("My letter");

            Scanner s = new Scanner()
            {
                SerialNumber = 0800
            };
            s.ProcessDoc("My Email");
            Console.WriteLine(s.Scan());
        }
    }
}
