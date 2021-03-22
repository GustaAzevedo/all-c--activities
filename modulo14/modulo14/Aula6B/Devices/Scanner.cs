using System;
using System.Collections.Generic;
using System.Text;

namespace modulo14.Aula6B.Devices
{
    class Scanner : Device, IScanne
    {
        public override void ProcessDoc(string document)
        {
            Console.WriteLine("Scan Processing " + document); ;
        }

        public string Scan()
        {
            return "Scanner scan Result";
        }
    }
}
