using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo
{
    internal class Atendente : Imposto
    {
        public override void ValeAlimentacao(double salario)
        {
            double result = salario * 0.15;
            Console.WriteLine("O desconto padrão do vale " + " alimentação do atendente é de: " + result);
        }
    }
}
