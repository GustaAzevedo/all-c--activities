using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace third
{
    class ContaCliente
    {

        private double _valorSaque;
        private double _valorDeposito;
        public string Nome { get; private set; }
        public int Conta { get; private set; }
        public char Deposito { get; private set; }
        public double ValorInicial { get; private set; }

        public ContaCliente(string nome, int conta, char deposito)
        {
            Nome = nome;
            Conta = conta;
            Deposito = deposito;
            if (deposito == 'S' || deposito == 's')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                ValorInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }


        }

        public ContaCliente(double valorDeposito)
        {
            ValorInicial = valorDeposito;

        }

        public double ValorDeposito
        {
            get { return _valorDeposito; }
            set
            {
                if ( value > 0)
                {
                    _valorDeposito = value;
                    ColocaValorInicial(_valorDeposito);
                }
            }
        }

        public double ValorSaque
        {
            get { return _valorSaque; }
            set
            {
                if (value > 0)
                {
                    _valorSaque = value;
                    ColocaValorInicialSaque(_valorSaque);
                }
            }
        }

        public void ColocaValorInicial(double x)
        {
            ValorInicial = ValorInicial + x;
        }
        public void ColocaValorInicialSaque(double x)
        {
            ValorInicial = ValorInicial - x;
        }

        public override string ToString()
        {
            return "Conta "
                + Conta
                + " titular: " 
                + Nome
                + ", Saldo: $ "
                + ValorInicial.ToString("F2", CultureInfo.InvariantCulture)
                ;
        }

    }
}
