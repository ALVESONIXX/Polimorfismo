using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo.Exercicios._1
{
    class Diretor : Colaborador
    {
        public override void CalcularSalario(double salario)
        {
            double desconto = salario * 0.23;
            double resultado = salario - desconto;
            Console.WriteLine("O desconto total é de :" + desconto + " com o desconto o salario do Diretor será de: " + resultado);
        }
    }
}
