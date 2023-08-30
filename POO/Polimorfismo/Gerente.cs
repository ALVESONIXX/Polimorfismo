using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo
{
    internal class Gerente : Imposto
    {
        public override void ValeAlimentacao(double salario)
        {
            double result = salario * 0.2;
            Console.WriteLine("O desconto do vale " + " alimentação do gerente é de: " + result);
        }
    }
}
