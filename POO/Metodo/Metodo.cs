using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Metodo
{
    internal class Metodo
    {
        // Exercicio 1

        //Metodo para realizar divisão

        public static void Dividir()
        {
            Console.WriteLine("Digite um número");
            int n1 = Convert.ToInt32(Console.ReadLine());

            int result = n1 / 2;
            Console.WriteLine("O resultado da divisão é: " + result);
            Console.ReadKey();

        }

        //Metodo para realizar a Multiplicação

        public static void Multiplicar()
        {
            Console.WriteLine("Digite dois numeros");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            int result = n1 * n2;
            Console.WriteLine("O resultado da multiplicação é " + result);
            Console.ReadKey();
        }

        public static void Somar()
        {
            Console.WriteLine("Digite dois numeros");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            int result = n1 + n2;
            Console.WriteLine("O resultado da soma é " + result);
            Console.ReadKey();
        }

        public static void Subtrair()
        {
            Console.WriteLine("Digite dois numeros");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());

            int result = n1 - n2;
            Console.WriteLine("O resultado da subtração é " + result);
            Console.ReadKey();
        }


        //Exercicio 2

        public static void CadastroUsuario()
        {
            Console.WriteLine("Adicione suas informações de cadastro");
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu cpf");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu endereço");
            string endereco = Console.ReadLine();

            Console.WriteLine("Digite seu Estado");
            string estado = Console.ReadLine();

            Console.WriteLine("Digite seu pais");
            string pais = Console.ReadLine();

            Console.WriteLine("Aqui estão suas informações");
            Console.WriteLine("Seu nome é " + nome);
            Console.WriteLine("Seu CPF é " + cpf);
            Console.WriteLine("Sua idade é " + idade);
            Console.WriteLine("Seu endereço é " + endereco);
            Console.WriteLine("Seu estado é " + estado);
            Console.WriteLine("Seu País é " + pais);
        }

        // Exercicio 3

        public static void CategorizarJogador()
        {
            Console.WriteLine("Fala Jogador! Adicione suas informações");

            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite seu time");
            string time = Console.ReadLine();

            Console.WriteLine("Digite sua cidade");
            string cidade = Console.ReadLine();

            Console.WriteLine("Digite seu Estado");
            string estado = Console.ReadLine();

            Console.WriteLine("Digite seu esporte");
            string esporte = Console.ReadLine();

            Console.WriteLine("E agora digite sua idade para validarmos usa categoria");
            int idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 12)
            {
                Console.WriteLine("Sua categoria é Infantil");
            }
            else if (idade < 16)
            {
                Console.WriteLine("Sua categoria éjuvenil");
            }
            else if (idade < 20)
            {
                Console.WriteLine("Sua categoria é junior");
            }
            else if (idade > 20)
            {
                Console.WriteLine("Sua categoria é Adulto");
            }
        }

        //Exercicio 4

        public static void AtribuirProduto()
        {
            Console.WriteLine("Digite as informações do produto");
            Console.WriteLine("Nome do produto");
            string nome = Console.ReadLine();

            Console.WriteLine("Informe a Marca do Produto");
            string marca = Console.ReadLine();

            Console.WriteLine("Informe o Codigo do produto");
            int code = Convert.ToInt32(Console.ReadLine());

        }
        public static void PrecificarProdutos()
        {
            Console.WriteLine("Digite a quantidade desejada do produto");
            int qntd = Convert.ToInt32(Console.ReadLine());

            if (qntd < 10)
            {
                int result1 = qntd * 12;
                Console.WriteLine(result1);
            }
            else if (qntd < 20)
            {
                int result2 = qntd * 15;
                Console.WriteLine(result2);
            }
            else
            {
                int result3 = qntd * 5;
                Console.WriteLine(result3);
            }
        }

        //Exercicio 5

        public static void Estudar()
        {
            Console.WriteLine("Digite as suas informações de aluno");
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o nome da sua escola");
            string escola = Console.ReadLine().ToUpper();

            Console.WriteLine(escola);
            Console.ReadKey();


            if (escola == "SENAI")
            {
                Console.WriteLine("Parabéns você está cursando em uma excelente escola ");
            }
            else
            {
                Console.WriteLine("Aluno não pertence ao Senai");
            }
        }





        //Exercicio 6

        public static void CalcularQuadrado()
        {
            Console.WriteLine("Digite o valor do lado do quadrado");
            double l = Convert.ToDouble(Console.ReadLine());
            double A = l * l;

            Console.WriteLine(A);
        }
        public static void CalcularRetangulo()
        {
            Console.WriteLine("Digite o valor da base do retangulo");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura do retangulo");
            double h = Convert.ToDouble(Console.ReadLine());

            double A = b * h;
            Console.WriteLine(A);
        }

        public static void CalcularCirculo()
        {
            Console.WriteLine("digite o raio do circulo");
            double r = Convert.ToDouble(Console.ReadLine());
            double r2 = r * r;
            double A = 3.14 * r2;

            Console.WriteLine(A);

        }
        //Exercicio 7

        public static void CadastrarProfessor()
        {
            Console.WriteLine("Digite as suas informações");
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a materia que leciona");
            string materia = Console.ReadLine();

            Console.WriteLine("Digite sua cidade");
            string cidade = Console.ReadLine();

            Console.WriteLine("Nome da escola");
            string escola = Console.ReadLine();
        }

        public static void CalcularMedia()
        {
            Console.WriteLine("Digite o nome do aluno");
            string aluno = Console.ReadLine();

            Console.WriteLine("Digite as 4 notas do aluno");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            int n3 = Convert.ToInt32(Console.ReadLine());
            int n4 = Convert.ToInt32(Console.ReadLine());

            int total = n1 + n2 + n3 + n4;
            int media = total / 4;

            Console.WriteLine("O Aluno " + aluno + "teve a media " + media);
        }

        //Exercicio 8

        public static void CadastrarColaborador()
        {
            Console.WriteLine("Adicione suas informações de Colaborador");
            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade");
            int idade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a sua escolaridade");
            string escolaridade = Console.ReadLine();

            Console.WriteLine("Digite seu cpf");
            string cpf = Console.ReadLine();

            Console.WriteLine("Digite seu rg");
            string rg = Console.ReadLine();

            Console.WriteLine("Aqui estão suas informações");
            Console.WriteLine("Seu nome é " + nome);
            Console.WriteLine("Sua idade é " + idade);
            Console.WriteLine("Sua escolaridade é " + escolaridade);
            Console.WriteLine("Seu CPF é " + cpf);
            Console.WriteLine("Seu RG é " + rg);
        }

        public static void AumentarSalario()
        {
            Console.WriteLine("Digite o Salário do Colaborador");
            double salario = Convert.ToDouble(Console.ReadLine());


            if (salario <= 1000)
            {
                double n1 = salario * 0.25;
                double r1 = salario + n1;
                Console.WriteLine("Novo salário é de " + r1);
            }
            else if (salario <= 3000)
            {
                double n2 = salario * 0.10;
                double r2 = salario + n2;
                Console.WriteLine("Novo salário é de " + r2);
            }
            else
            {
                double n3 = salario * 0.05;
                double r3 = salario + n3;
                Console.WriteLine("Novo salário é de " + r3);
            }
        }

    }
}

