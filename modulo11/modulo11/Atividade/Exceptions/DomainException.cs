using System;
using System.Collections.Generic;
using System.Text;

namespace modulo11.Atividade.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string message) : base(message)
        {

        }

    }
}
