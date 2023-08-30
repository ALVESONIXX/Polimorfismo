using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo.Exercicios._2
{
    class Poupança : Conta
    {
        public override void CalcularImposto(double valor)
        {
            this.valor = valor;
            double desconto = valor * 0.06;
            double result = valor - desconto;

            Console.WriteLine("O desconto total da conta Poupança é de: " + desconto + " E o valor com desconto é de: " + result);
        }
    }
}
