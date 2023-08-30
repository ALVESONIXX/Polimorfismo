using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo.Exercicios._2._3
{
    class Taxi : Veiculo
    {
        private int qntdRodas;
        private int qntdPassageiros;

        public int quantidadeRodas
        {
            get { return qntdRodas; }
            set { qntdRodas = value; }
        }
        public int quantidadePassageiros
        {
            get { return qntdPassageiros; }
            set { qntdPassageiros = value; }
        }
        public override void CalcularValorCombustivel()
        {
            Console.WriteLine("Digite qual a opção de combustivel gostaria de abstacer: ");
            Console.WriteLine("1 - Alcool " +
                "2 - Gasolina" +
                " 3 - Hibrido" +
                " 4 - Gas GNV" +
                " 5 - Diesel");
            int decisao = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Agora digite a quantidade de litros que gostaria");
            int litros = Convert.ToInt32(Console.ReadLine());

            switch (decisao)
            {
                case 1:

                    double result1 = (litros * 3.99) + 20.00;
                    Console.WriteLine("O valor total foi de: " + result1);
                    Console.ReadKey();
                    break;

                case 2:

                    double result2 = (litros * 5.99) + 40.00;
                    Console.WriteLine("O valor total foi de: " + result2);
                    Console.ReadKey();
                    break;

                case 3:

                    Console.WriteLine("Quantas horas voce deseja deixar o veiculo carregando?");
                    double horas = Convert.ToDouble(Console.ReadLine());
                    double result3 = (horas * 1000.0) + 200.0;
                    Console.WriteLine(" a opção escolhida foi " + decisao + " e o valor total foi" + result3 + " sendo carregado por " + horas);
                    break;

                case 4:

                    Console.WriteLine("Sera cobrado uma taxa fixa de 3 300R$");
                    break;

                case 5:

                    double result5 = (litros * 7.99) + 25.00;
                    Console.WriteLine("A decisão foi de usar Diesel e o total foi de: " + result5);
                    break;
             }
        }
        public override void CalcularTotal()
        {
            Console.WriteLine("Digite a quantidade de pessoas que irão para a viagem");
            int pessoas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de KM a ser percorrida");
            double km = Convert.ToDouble(Console.ReadLine());

            if (pessoas == 2 & km > 30)
            {
                double result1 = km * 20.00;
                double ValorDividido = result1 / 2;
                Console.WriteLine("valor final para cada um foi de: " + ValorDividido);
            }
            else if (pessoas == 3 & km > 30)
            {
                double result2 = km * 35.00;
                double ValorDividido1 = result2 / 3;
                Console.WriteLine("valor final para cada um foi de: " + ValorDividido1);
            }
            else if ( pessoas == 4 & km > 30)
            {
                double result3 = km * 50.00;
                double ValorDividido2 = result3 / 4;
                Console.WriteLine("valor final para cada um foi de: " + ValorDividido2);
            }
            else if (pessoas == 2 || pessoas == 3 || pessoas == 4 & km <= 30)
            {
                double result4 = km * 10.00;
                double ValorDividido3 = result4 / pessoas;
                Console.WriteLine("valor final para cada um foi de: " + ValorDividido3);
            }
            else
            {
                double result5 = km * 18.00;
                Console.WriteLine("o valor final foi de: " + result5);
            }
        }
    }
}
