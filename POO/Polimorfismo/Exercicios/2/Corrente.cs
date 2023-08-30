using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo.Exercicios._2
{
    class Corrente : Conta
    {
        public override void CalcularImposto(double valor)
        {
            this.valor = valor;
            double desconto = valor * 0.15;
            double result = valor - desconto;

            Console.WriteLine("O desconto total na conta corrente é de: " + desconto + " E o valor com desconto é de: " + result);
        }
    }
}
