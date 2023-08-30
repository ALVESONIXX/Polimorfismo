using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo
{
    internal class Imposto
    {
        public virtual void ValeAlimentacao(double salario)
        {
            double result = salario * 0.1;
            Console.WriteLine("O desconto padrão do vale " + " alimentação é de: " + result);
        }

        public void ValeTransporte(double salario)
        {
            double result = salario * 0.06;
            Console.WriteLine("O desconto padrão do vale " + " transporte é de: " + result);
        }
     
    }
}
