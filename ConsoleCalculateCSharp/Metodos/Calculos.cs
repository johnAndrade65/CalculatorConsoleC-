using System;

namespace ConsoleCalculateCSharp.Metodos {
    internal class Calculos {
        
        //Metodo adição
        public float Add(float x, float y) {
            float resultado = x + y;
            Console.WriteLine("= {0}", resultado);
            return resultado;
        }
        //Metodo subtração
        public float Subtracao(float x, float y) {
            float resultado = x - y;
            Console.WriteLine("= {0}", resultado);
            return resultado;
        }
        //Metodo multiplicação
        public float Multiplicar(float x, float y) {
            float resultado = x * y;
            Console.WriteLine("= {0}", resultado);
            return resultado;
        }
        //Metodo divisão
        public float Dividir(float x, float y) {
            float resultado = x / y;
            Console.WriteLine("= {0}",resultado);
            return resultado;
        }
    }
}
