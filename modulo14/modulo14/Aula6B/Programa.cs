using System;
using System.Collections.Generic;
using System.Text;
using modulo14.Aula6B.Devices;

namespace modulo14.Aula6B
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

            ComboDevice c = new ComboDevice()
            {
                SerialNumber = 795
            };
            c.ProcessDoc("My dissertation");
            c.Print("My dissertation");
            Console.WriteLine(c.Scan());
        }
    }
}
