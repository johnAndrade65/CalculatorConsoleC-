using System;
using ConsoleCalculateCSharp.Metodos;

namespace ConsoleCalculateCSharp {
    internal class Program {
        static void Main(string[] args) {
            //Variaveis numericas:
            float num1 = 0;
            float num2 = 0;

            //Criação de objeto para acessar os metodos aritmeticos:
            Calculos Operacao = new Calculos();

            //Escolha uma operação:
            Console.WriteLine("Qual operação deseja usar? (Digite apenas o icone!)");
            Console.WriteLine(" + Somar  \r\n - Subtração  \r\n * Multiplicação \r\n / Divisão \r\n");

            string operacao = Console.ReadLine();
            Console.WriteLine("Operação selecionada {0} \r\n", operacao);

            //Condicionais para saber se a operação é valida:
            if (operacao == "+" || operacao == "-"|| operacao == "*" || operacao == "/") {
                //Se for valida vai capturar os dois números
                Console.WriteLine("Primeiro número:",operacao);
                num1 = float.Parse(Console.ReadLine());

                Console.WriteLine("({0}) Segundo número:", operacao);
                num2 = float.Parse(Console.ReadLine());
            } else {
                //Caso seja invalida vai exibir uma mensagem para escolher uma operação valida
                Console.WriteLine("Escolha uma operação válida, tente novamente!");
            }


            //Condicionais para chamar o metodo/operação de acordo com a escolha do usuario:
            if (operacao == "+") {
                //Se operação for igual a "+" Soma os valores numericos
                float resultado = Operacao.Add(num1, num2);
            }else if (operacao == "-") {
                //Se operação for igual a "-" Subtrai os valores numericos
                float resultado = Operacao.Subtracao(num1, num2);
            }else if (operacao == "*") {
                //Se operação for igual a "*" Multiplica os valores numericos
                float resultado = Operacao.Multiplicar(num1, num2);
            }else if (operacao == "/") {
                //Se operação for igual a "/" Dividi o primeiro valor pelo segundo
                float resultado = Operacao.Dividir(num1, num2);
            }
        }
    }
}
