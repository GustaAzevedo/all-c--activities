using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace modulo17.Atividade02.Entities
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string email, double salario)
        {
            Nome = nome;
            Email = email;
            Salario = salario;
        }

        public override string ToString()
        {
            return 
                Nome
                + ", "
                + Email
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
