﻿using System;
using System.Collections.Generic;
using System.Text;

namespace modulo14.Aula6A.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }
        public abstract void ProcessDoc(string document);
    }
}
