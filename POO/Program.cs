using POO.Polimorfismo;
using POO.Polimorfismo.Exercicios._1;
using POO.Polimorfismo.Exercicios._2;
using POO.Polimorfismo.Exercicios._2._3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Imposto imposto = new Imposto();
            imposto.ValeAlimentacao(2000);
            imposto.ValeTransporte(2500);

            Estagiario estagiario = new Estagiario();
            estagiario.ValeAlimentacao(1500);
            estagiario.ValeTransporte(1000);

            Gerente gerente = new Gerente();


            Atendente atendente = new Atendente();

            Console.ReadKey();

            Animal animal = new Animal();
            animal.nome = "Lipe";
            animal.Correr();
            animal.Comer();

            Cavalo cavalo = new Cavalo();
            cavalo.nome = "Cavalo";
            cavalo.Correr();
            cavalo.Comer();

            Gato gato = new Gato();
            gato.nome = "Gato";
            gato.Correr();
            gato.Comer();

            Tubarao tubarao = new Tubarao();
            tubarao.nome = "Tubarao";
            tubarao.Correr();
            tubarao.Comer();

            Console.ReadKey();

            //Exercicio 1

            Colaborador colaborador = new Colaborador();
            colaborador.CalcularSalario(2000);
            colaborador.CalcularIRRF(2000);

            Coordenador coordenador = new Coordenador();
            coordenador.CalcularSalario(2500);
            coordenador.CalcularIRRF(2500);

            Diretor diretor = new Diretor();
            diretor.CalcularSalario(4000);
            diretor.CalcularIRRF(4000);

            Professor professor = new Professor();
            professor.CalcularSalario(1500);
            professor.CalcularIRRF(1500);

            Console.ReadKey();

            //Exercicio 2

            Console.WriteLine("Digite o valor do saque");
            double valor = Convert.ToDouble(Console.ReadLine());

            Conta conta = new Conta();
            conta.CalcularImposto(valor);

            Poupança poupança = new Poupança();
            poupança.CalcularImposto(valor);

            Corrente corrente = new Corrente();
            corrente.CalcularImposto(valor);

            Console.ReadKey();

            //Exercicio 3

            Veiculo veiculo = new Veiculo();
            veiculo.placa = "2914 2143";
            veiculo.cor = "prata";
            veiculo.modelo = "Palio";
            veiculo.CalcularValorCombustivel();
            veiculo.CalcularTotal();
            Console.WriteLine("a placa do veiculo é " + veiculo.placa);
            Console.WriteLine("a cor do veiculo é " + veiculo.cor);
            Console.WriteLine("o modelo do veiculo é " + veiculo.modelo);
            Console.ReadKey();

            Moto Moto = new Moto();
            Moto.placa = "2333 3312";
            Moto.cor = "azul";
            Moto.modelo = "cb 300";
            Moto.quantidadePassageiros = 1;
            Moto.quantidadeRodas = 2;
            Moto.CalcularValorCombustivel();
            Moto.CalcularTotal();
            Console.WriteLine("a placa do veiculo é " + Moto.placa);
            Console.WriteLine("a cor do veiculo é " + Moto.cor);
            Console.WriteLine("o modelo do veiculo é " + Moto.modelo);
            Console.WriteLine("a quantidade de passageiros é " + Moto.quantidadePassageiros);
            Console.WriteLine("a quantidade de rodas é " + Moto.quantidadeRodas);
            Console.ReadKey();

            Taxi Taxi = new Taxi();
            Taxi.placa = "2320 2029";
            Taxi.cor = "preto";
            Taxi.modelo = "golf";
            Taxi.quantidadePassageiros = 1;
            Taxi.quantidadeRodas = 4;
            Taxi.CalcularTotal();
            Taxi.CalcularValorCombustivel();
            Console.WriteLine("a placa do veiculo é " + Taxi.placa);
            Console.WriteLine("a cor do veiculo é " + Taxi.cor);
            Console.WriteLine("o modelo do veiculo é " + Taxi.modelo);
            Console.WriteLine("a quantidade de passageiros é " + Taxi.quantidadePassageiros);
            Console.WriteLine("a quantidade de rodas é " + Taxi.quantidadeRodas);
            Console.ReadKey();

            Uber uber = new Uber();
            uber.placa = "2914 3412";
            uber.cor = "vermelho";
            uber.modelo = "monza";
            uber.quantidadePassageiros = 1;
            uber.quantidadeRodas = 4;
            uber.CalcularValorCombustivel();
            uber.CalcularTotal();
            uber.EscolherVeiculo("ubergreen");
            Console.WriteLine("a placa do veiculo é " + uber.placa);
            Console.WriteLine("a cor do veiculo é " + uber.cor);
            Console.WriteLine("o modelo do veiculo é " + uber.modelo);
            Console.WriteLine("a quantidade de passageiros é " + uber.quantidadePassageiros);
            Console.WriteLine("a quantidade de rodas é " + uber.quantidadeRodas);
            Console.ReadKey();


        }
    }
}
