using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AppMenu();
        }
        static void AppMenu()
        {   
            Console.Clear();
            Console.WriteLine("Olá, Seja Bem-vindo!");
            Console.WriteLine("======== Tipos de Operações ========");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("=====================================");
            Console.WriteLine("Qual operação deseja realizar?");
            PulaLinha();
            Operation();

        }

        static void Operation(){

            var operation = Console.ReadLine();

            
            switch(operation){
                case "1":
                    Console.WriteLine("Operação Escolhida: Soma");
                    PulaLinha();
                    Soma();
                    break;
                case "2":
                    Console.WriteLine("Operação Escolhida: Subtração");
                    PulaLinha();
                    Subtracao();
                    break;
                case "3":
                    Console.WriteLine("Operação Escolhida: Multiplicação");
                    PulaLinha();
                    Multiplicacao();
                    break;
                case "4":
                    Console.WriteLine("Operação Escolhida: Divisão");
                    PulaLinha();
                    Divisao();
                    break;
                case "0":
                    PulaLinha();
                    Console.Write("Saindo...");
                    Environment.Exit(0);
                    break;
                default:
                    PulaLinha();
                    Console.Write("Sinto muito, mas essa operação é inválida! =(\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    AppMenu();
                    break;
            }
        }

        static void Soma()
        {
            Console.WriteLine("Digite o Primeiro Valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());
            
            PulaLinha();

            double ResultadoSoma = valor1 + valor2;

            Console.WriteLine($"Resultado da soma: {ResultadoSoma}");

            DesejaContinuar();
        } 

        static void Subtracao(){
            Console.WriteLine("Digite o Primeiro Valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            PulaLinha();

            double ResultadoSubtracao = valor1 - valor2;

            Console.WriteLine($"Resultado da subtração: {ResultadoSubtracao}");

            DesejaContinuar();
        }

        static void Multiplicacao(){

            Console.WriteLine("Digite o Primeiro Valor:");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Valor:");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            PulaLinha();

            double ResultadoMultiplicacao = valor1 * valor2;

            Console.WriteLine($"Resultado da multiplicação: {ResultadoMultiplicacao}");

            DesejaContinuar();
        }

        static void Divisao(){
            Console.WriteLine("Digite o Primeiro Valor:");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o Segundo Valor:");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            PulaLinha();

            double ResultadoDivisao = valor1 / valor2;

            Console.WriteLine($"Resultado da divisão: {ResultadoDivisao}");
            
            DesejaContinuar();
        }

        static void DesejaContinuar(){
            PulaLinha();
            Console.WriteLine("Deseja fazer mais cálculos? (S/N)");

            var resposta = Console.ReadLine();

            // Corrigindo o alerta de possível variável conter estado nulo
            if (resposta is not null){
                resposta = resposta.ToUpper();
            }
            
            if (resposta == "S"){
                Console.Clear();
                AppMenu();
            } else if (resposta == "N"){
                PulaLinha();
                Console.WriteLine("Saindo...");
                Environment.Exit(0);
            } else{
                Console.WriteLine("Por favor, digite uma opção válida.");
                DesejaContinuar();
            }

        }

        static void PulaLinha()
        {
            Console.WriteLine("");
        }
    }
}
