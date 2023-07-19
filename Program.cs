using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    class Program
    {
        private const string Value = "nota foi otima";

        static void Main(string[] args)
        {
            /*Console.WriteLine("hello world");
            //declarando variaveis
           
            var nome = "paulo";
            Console.WriteLine(nome);
            double sal = 4500.58;
            Console.WriteLine(sal);
            string olaMundo = "ola, mundo";"
            Console.WriteLine(olaMundo);
            int idade = 29;
            Console.WriteLine(idade);
            bool praia = false;
            Console.WriteLine(praia);
            */
            //byte num1 = byte.MaxValue;
            //byte num2 = byte.MinValue;

            //int
            //double
            //string
            //bool prova = true; // false



            /*Console.WriteLine("O valor maximo " + num1 + " valor minimo " + num2);
            Console.WriteLine("O valor maximo: {0}", num1);
            Console.WriteLine($"O valor maximo: {num1}");
           
            string nome = "Paulo";
            int idade = 29;
            double nota = 10;
            Console.WriteLine("O aluno {0} tem {1} anos de idade e tirou {2} na prova" ,nome ,idade ,nota);
            Console.WriteLine($"O aluno {nome} tem {idade} anos de idade e tirou {nota} na prova");
           

            string marca = "nissan".ToUpper();//ToUpper = deixa tudo maiusculo
            string carro = "gtr".ToLower();//ToLower = deixa tudo minusculo
            int potencia = 552;
            double ano = 2022;
            Console.WriteLine($"O {marca} {carro} {ano} tem {potencia} cavalos de potencia");
           
            string marca = "nissan".ToUpper();//ToUpper = deixa tudo maiusculo
            string carro = "gtr".Insert(3, " R35");
            int potencia = 552;
            double ano = 2022;
            Console.WriteLine($"O {marca} {carro} {ano} tem {potencia} cavalos de potencia");
           
            Console.WriteLine("Qual o seu nome ? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade ? ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine($"Ola, {nome} voce tem {idade} anos de idade");
           

            Console.WriteLine("Qual a marca do carro ? ");
            string marca = Console.ReadLine();
            Console.WriteLine("Qual o modelo do carro ?");
            string modelo = Console.ReadLine();
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine($"")
           
            Console.WriteLine("Qual seu nome ? ");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a sua idade ? ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu peso ? ");
            int peso = int.Parse(Console.ReadLine());
            */
            /*
            //1 a
            int a = 10;
            int b = 15;
            Console.WriteLine(a + b);
            //1 b
            string nome = "Paulo";
            Console.WriteLine(nome);
            //1 c
            bool carro = true;
            Console.WriteLine(carro);
            //1 d
            double valor = 3.1415;
            Console.WriteLine(valor);

            //2 a
            Console.WriteLine("Qual seu nome ? ");
            string nome1 = Console.ReadLine();
            //2 b
            Console.WriteLine("Qual a sua idade ? ");
            int idade = int.Parse(Console.ReadLine());
            //2 c
            Console.WriteLine("Qual bairro voçe mora ? ");
            string bairro = Console.ReadLine();
            //2 d
            Console.WriteLine("paulo".ToUpper());
            //2 e
            Console.WriteLine("Digite um numero");
            int num1 = int.Parse (Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A soma dos numeros é" );
            Console.WriteLine(num1 + num2);

           
            //3 a
            string ph = "Paulo".Insert(5," alcantara");
            Console.WriteLine(ph);
            */


            /*
            double sal = 50.58 * 8 * 24;
            Console.WriteLine("Seu salario é");
            Console.WriteLine(sal.ToString("C2"));//C2 transforma em formato de dinheiro R$ o numero 2 se refera as casas decimais.
           
            Console.WriteLine("qual seu salario ?");
            double sala = double.Parse(Console.ReadLine());
            Console.WriteLine(sala.ToString("C2"));
            */

            ///AULA DIA 13/05/2023 = AULA 4
            ///
            /*
            var nota1 = 7;
            var nota2 = 5;

            double media = nota1 + nota2 / 2;

            Console.WriteLine(media);
           
           
            double nota = 6;
            double faltas = 4;
            ///string comportamento = "sim";
            var res = nota >= 7 && faltas <= 2 ;
            Console.WriteLine($"O aluno está aprovado ?{res}");
           

           
            ///double idade = 18;
            ///var hab = idade >= 18;
            ///Console.WriteLine($"Voce esta apto a tirar havilitação ?{hab}");
            ///

           

            bool feriado = true;
            double sal = 4000;
            // Vou ir a praia caso seja feriado ou eu tenha um valor de 4k
            var vouAPraia = feriado == true || sal >= 4000;
            var vouAPraia2 = feriado == true && sal >= 4000;
            Console.WriteLine($"esse fds eu vou a praia?: {vouAPraia}");
            Console.WriteLine($"esse fds eu vou a praia?: {vouAPraia2}");/// Ctrl + D duplica a linha acima
            */

            ///crie um programa para calcular a media do aluno
            ///
            /*
            //1
            double nota1 = 7;
            double nota2 = 8;

            var media = (nota1 + nota2) / 2;
            Console.WriteLine($"a media do aluno é {media}");

            //2
            Console.WriteLine("Digite um numero");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro numero");
            int num2 = int.Parse(Console.ReadLine());
            var res = num1 + num2;
            Console.WriteLine($"a soma dos numeros é{res}");
           
            //3
           
            Console.WriteLine("Qual o seu nome ?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual o seu peso ?");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("qual a sua altura ?");
            double alt = double.Parse(Console.ReadLine());
            var imc = peso / (alt * alt);
            Console.WriteLine($"{nome} o seu imc é {imc.ToString("f1")}");
            */


            ////////////////////////////////////////////////////////////////////////////////////////////////////


            // nota >9 = quadro de honra
            //if else
            /*
            int nota = 9;
            if (nota >= 9)
            {
                Console.WriteLine("o aluno esta no quadro de honra");
               

            } else
            {
                Console.WriteLine("o aluno não esta no quadro de honra");

            }
           



           
            Console.WriteLine("fim do programa");

            */


            /////////////////////////////////////////////////////////////////////////////////////////////////

            /*
            double media = 5;
            //media >= 7
            //media >= 6 ap. conselho
            //faltas <= 2
            if (media >= 7)
            {
                Console.WriteLine($"o aluno esta aprovado com a nota {media}");
            } else if (media >= 6)
            {
                Console.WriteLine($"o aluno esta ap. no conselho com a nota {media}");
            }
            else
            {
                Console.WriteLine($"o aluno esta reprovado com a nota {media}");
            }
            */


            //////////////////////////////////////////////////////////////////////////////////////
            ///
            /*
            Console.Write("qual a sua idade :");
            int idade = int.Parse (Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine($"voce deve votar sua idade é {idade}");
            }
            else if (idade >= 16 && < 18)
            {

            }

            continuar acima

            */

            //////////////////////////////////////////////////////////////////////////////////////////
            ///

            ///SWITCH
            /*
            var nota = 1; // 1 - 5
            switch (nota)
            {
                case 1:
                    Console.WriteLine("nota foi pessima");
                    break;
                case 2:
                    Console.WriteLine("nota foi ruim");
                    break;
                case 3:
                    Console.WriteLine("nota foi regular");
                    break;
                case 4:
                    Console.WriteLine("nota foi boa");
                    break;
                case 5:
                    Console.WriteLine("nota foi otima");
                    break;
                default :
                    Console.WriteLine("voce não foi avaliado");
                    break;
            }
            */
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///


            //EXERCICIOS




            //1
            /*
            Console.Write("qual sua idade ? ");
            int idade = int.Parse(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade!");
            }
            else
            {
                Console.WriteLine("Você é menor de idade!");
            }


            //2

            Console.WriteLine("digite um numero inteiro");
            int num = int.Parse(Console.ReadLine());

            //3

            Console.Write("qual a sua idade :");
            int idade1 = int.Parse(Console.ReadLine());
            if (idade1 < 18)
            {
                Console.WriteLine("voçe é menor de idade");
            }
            else if (idade1 >= 18)
            {
                Console.WriteLine("voce é maior de idade");
            }
            else if (idade1 >= 60)
            {
                Console.WriteLine("voce é idoso");
            }


            //4

            */

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


            ///AULA DIA 20/05/2023

            /*
            Console.WriteLine("digite um numero ");
            double numero = double.Parse(Console.ReadLine());
            Console.WriteLine(numero);

            //TryParse abaixo

            Console.WriteLine("digite um numero ");
            double numero2;
            double.TryParse(Console.ReadLine(), out numero2);
            Console.WriteLine(numero2);
            */


            // programa para ler 2 notas de alunos.
            //calcular a media do aluno.
            //utilizar TryParse
            //if else para devolcer o resultado de aprovado ou reprovado


            /*
            Console.WriteLine("digite a primeira nota ");
            double.TryParse(Console.ReadLine(), out double nota1);
            Console.WriteLine("digite a segunda nota ");
            double.TryParse(Console.ReadLine(), out double nota2);
            var media = (nota1 + nota2) / 2;
            Console.WriteLine($"a sua media foi {media}");
            if (media >= 7)
            {
                Console.WriteLine($"o aluno esta aprovado com a nota {media}");
            }
            else if (media >= 6)
            {
                Console.WriteLine($"o aluno esta ap. no conselho com a nota {media}");
            }
            else
            {
                Console.WriteLine($"o aluno esta reprovado com a nota {media}");
            }
            */


            ////////////////////////////////////////////////////////////////////////////////////////////////////////


            //WHILE//

            // CONTADOR = 0
            // CONTADOR = 10
            /*
            int i = 0;
            while (i <= 10)
            {
                Console.WriteLine($"valor do contador : {i}");
                i+=2;  //+=2; atribui de 2 em 2 e assim sucesivamente
            }

            Console.WriteLine("fim");
            */
            // exercicio //
            /*
            Console.WriteLine("digite um numero : (0 a 10");
            int.TryParse(Console.ReadLine(), out int numUsuario);
            int numeroSorteado = 7;

            while (numUsuario == numeroSorteado)
            {

               

            }
           


            int inicio = 0;
            Console.Write("Quer contar ate quanto ?");
            int.TryParse(Console.ReadLine(), out int numero);
            Console.Write("qual vai ser o intervalo ?");
            int.TryParse(Console.ReadLine(), out int inter);
            while (inicio <= numero)
            {

                Console.WriteLine($"valor do contador : {inicio}");
                inicio += inter;
               
            }

            Console.WriteLine("fim");


            //Desenvolva um jogo onde o usuário deve digitar um número de 0 a 10.
            //Se o usuário acertar o número sorteado, exiba a mensagem "Parabéns, você acertou!".
            //Se o usuário errar, exiba a mensagem "Tente novamente" e solicite que o usuário digite
            //um novo número.O jogo deve continuar até que o usuário acerte o número sorteado.

           
            int sorteio = 7;
            Console.WriteLine("Digite um numero de 0 a 10");
            int.TryParse(Console.ReadLine(), out int usuario);
            while (usuario != sorteio)
            {

                Console.WriteLine("tente novamente :");
                int.TryParse(Console.ReadLine(), out usuario);
            }

            Console.WriteLine("parabens vc acertou");


            ////////////////////////////////////////////////////////

            var contador = 0;
            do
            {

                Console.WriteLine($"{contador}");
                contador++;

            } while (contador <= 10);
           


            for (int i = 0; i <= 100; i += 10)
            {


                Console.WriteLine($"valor do contador: {i}");
           
           
            }

            */
            /*
            int formula, contador;


            Console.Write("Digite o Numero para Obter a Taboada : ");
            int.TryParse(Console.ReadLine(), out int numero);

            //
            for (contador = 1; contador <= 10; ++contador)
            {
                formula = numero * contador;
                Console.WriteLine(numero + " X " + contador + " = " + formula);

            }
            */
            /*
            Console.WriteLine("digite um valor");
            int.TryParse(Console.ReadLine(), out int valorU);

            for (int contador = 0; contador <= 10; contador++) ;
            {

                Console.WriteLine($"{valorU} * {contador} = {contador * valorU}");

            }
            */

            ////////////////////////////////////////////////////////////////////////////////////
            //  aula dia 27/05/2023

            /*
            var salaDeAula = "paulo";
            Console.WriteLine(salaDeAula);
            salaDeAula = "adriano";
            Console.WriteLine(salaDeAula);
            */

            /*
            int[] numeros = new int[4] { 5, 6, 7, 9};
            Console.WriteLine($"acessando o indice {numeros[2]}");

            string[] nomes = new string[4] { "paulo", "henrique", "alcantara", "vasconcelos" };
            Console.WriteLine($"acessando o indice {nomes[1]}");

            int[] exe = new int[5] { 5, 6, 7, 9, 10};
            Console.WriteLine($"acessando o indice {exe[2]}");
            */

            /*
             var nome = "paulo";
             foreach(char letra in nome)
             {
                 Console.WriteLine($"{letra}");
             }
            */
            //var SalaDeAula = new string[] { "lucas", "joao", "maria", "keilla" };
            //foreach (var aluno in SalaDeAula)
            //{
            //    Console.WriteLine(aluno);
            // }



            //////////////////////////////////////////////////////////////////



            var cont = 0;
            do
            {

                Console.WriteLine($"{cont}");
                cont++;

            } while (cont <= 10);

            ////////////////////////////////////////////////////////////////

            for (int i = 0; i <= 20; i += 2)
            {


                Console.WriteLine($"numeros pares: {i}");


            }

            /////////////////////////////////////////////////////////////////

            int sorteio = 0;
            Console.WriteLine("Digite um numero de 0 a 10");
            int.TryParse(Console.ReadLine(), out int usuario);
            while (usuario != sorteio)
            {

                Console.WriteLine("tente novamente :");
                int.TryParse(Console.ReadLine(), out usuario);
            }

            Console.WriteLine("parabens vc acertou");

            ///////////////////////////////////////////////////////////////////

            var cidades = new string[] { "São Paulo", "Rio de Janeiro", "Porto Alegre", "Salvador", "joão Pessoa" };
            foreach (var cidade in cidades)
            {
                Console.WriteLine(cidade);
            }

            ///////////////////////////////////////////////////////////////////

            Console.WriteLine("Digite um numero");
            int.TryParse(Console.ReadLine(), out int numero);






        }
    }
}