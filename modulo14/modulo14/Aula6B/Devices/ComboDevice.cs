using System;
using System.Collections.Generic;
using System.Text;

namespace modulo14.Aula6B.Devices
{
    class ComboDevice : Device, IScanne, IPrinter
    {
        public void Print(string document)
        {
            Console.WriteLine("ComboDevice Print" + document);
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine("ComboDevice Processing" + document);
        }

        public string Scan()
        {
            return "ComboDevice scanr result";
        }
    }
}
