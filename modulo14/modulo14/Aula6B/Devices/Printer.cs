using System;
using System.Collections.Generic;
using System.Text;

namespace modulo14.Aula6B.Devices
{
    class Printer : Device, IPrinter
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Printer processing: " + document);
        }

        public void Print(string document)
        {
            Console.WriteLine("Printer print " + document );
        }
    }
}
