using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo.Exercicios._1
{
    class Colaborador
    {
        public double salario;
        public virtual void CalcularSalario(double salario)
        {
            double desconto = salario * 0.14;
            double resultado = salario - desconto;
            Console.WriteLine("O desconto total é de :" + desconto + " com o desconto o salario será de: " + resultado);
        }
        public void CalcularIRRF(double salario)
        {
            double desconto = salario * 0.02;
            double resultado = salario - desconto;
        }        
    }
}
