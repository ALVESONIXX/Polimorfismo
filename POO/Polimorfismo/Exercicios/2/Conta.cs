using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo.Exercicios._2
{
    class Conta
    {
        public string agencia;
        public string conta;
        public string NomeTitular;
        public double valor;

        public virtual void CalcularImposto(double valor)
        {
            this.valor = valor;
            double desconto = valor * 0.04;
            double result = valor - desconto;

            Console.WriteLine("O desconto total é de: " + desconto + " E o valor com desconto é de: " + result);

        }
    }
}
