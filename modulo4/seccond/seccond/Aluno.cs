using System;
using System.Globalization;

namespace seccond
{
    class Aluno
    {
        public string Nome;
        public double N1;
        public double N2;
        public double N3;
        public double NotaFinal;
        public bool Aprovado;
        public string status;
        public double QuantoFaltou;


        public void SomaNota()
        {
           NotaFinal = N1 + N2 + N3;
        }

        public bool AprovadoReprovado()
        {
            if(NotaFinal >= 18)
            {
                Aprovado = true;
                status = "Aprovado";
            }
            else
            {
                Aprovado = false;
                status = "Reprovado";
                Faltou();
            }
            return Aprovado;
        }

        public void Faltou()
        {
            QuantoFaltou = 18 - NotaFinal;
            Console.WriteLine("Faltaram " + QuantoFaltou.ToString("F2", CultureInfo.InvariantCulture) + " Pontos");
        }


    }
}
