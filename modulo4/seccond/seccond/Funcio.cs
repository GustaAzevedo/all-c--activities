using System;
using System.Collections.Generic;
using System.Text;

namespace seccond
{
    class Funcio
    {
        public string Name;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto; 
        }

        public void AumentaSalario(double x)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * x / 100);
        }

        public override string ToString()
        {
            return Name
                + ", $ "
                + SalarioLiquido().ToString("F2");
        }
    }
}
