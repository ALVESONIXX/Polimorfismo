using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo.Exercicios._2._3
{
    class Veiculo
    {
        public string placa;
        public string cor;
        public string modelo;

        public virtual void CalcularValorCombustivel()
        {
            Console.WriteLine("Digite qual a opção de combustivel gostaria de abstacer: ");
            Console.WriteLine("1 - Alcool " +
                "2 - Gasolina" +
                " 3 - Diesel");
            int decisao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Agora digite a quantidade de litros que gostaria");
            int litros = Convert.ToInt32(Console.ReadLine());   

            if (decisao == 1 ) 
            {
                double result1 = litros * 3.99;
                Console.WriteLine("O valor total foi de: " + result1);
            }
            else if (decisao == 2 ) 
            {
                double result2 = litros * 5.99;
                Console.WriteLine("O valor total foi de: " + result2);
            }
            else if ( decisao == 3 ) 
            {
                double result3 = litros * 6.99;
                Console.WriteLine("O valor total foi de: " + result3);
            }
            else
            {
                Console.WriteLine("Nao aceitamos essa opção");
            }
        }
        public virtual void CalcularTotal()
        {
            Console.WriteLine("Digite a quantidade de pessoas que irão para a viagem");
            int pessoas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de KM a ser percorrida");
            double km = Convert.ToDouble(Console.ReadLine());

            if (pessoas == 2 & km > 50 ) 
            {
                double result1 = km * 25.00;
                Console.WriteLine("valor final de: " + result1);
            }
            else if ( pessoas == 2 & km < 50 ) 
            {
                double result2 = km * 18.00;
                Console.WriteLine("valor final de: " + result2);
            }
            else
            {
                double result3 = km * 15.00;
                Console.WriteLine("valor final de: " + result3);
            }
        }


    }
}
