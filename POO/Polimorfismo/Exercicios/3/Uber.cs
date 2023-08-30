using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Polimorfismo.Exercicios._2._3
{
    class Uber : Veiculo
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

        public string tipoUber;
        public override void CalcularTotal()
        {
            Console.WriteLine("Digite a quantidade de KM a ser percorrida");
            double km = Convert.ToDouble(Console.ReadLine());
            double ValorKM = km * 11.99;
            Console.WriteLine("o total foi de: " +  ValorKM);
        }
        public void EscolherVeiculo(string tipoUber)
        {
            tipoUber = Console.ReadLine().ToLower();

            if (tipoUber == "ubergreen")
            {
                Console.WriteLine("Parabens voce esta usando um veiculo ecologico");
            }
            else if (tipoUber == "uberreserve") 
            {
                Console.WriteLine("Digite a data que gostaria de reservar o veiculo");
                string data = Console.ReadLine();
                Console.WriteLine("Agora digite o horario");
                double horario = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Agora digite a quantidade de pessoas");
                int pessoas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("E por ultimo digite o destino");
                string destino = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("“Nenhum veículo escolhido, você irá fazer a viagem com um veículo padrão da\r\nempresa. Boa viagem!!!");
            }

        }
    }
}
