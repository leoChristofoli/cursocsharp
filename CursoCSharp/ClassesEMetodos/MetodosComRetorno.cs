using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class CalculadoraComum {
        /*
         * Podemos criar metodos com o mesmo nome
         * desde que recebam parâmetros diferêntes.
         * 
         */

        public int Somar(int a, int b) {
            return a + b;
        }

        public int Somar(int a, int b, int c) {
            return a + b + c;
        }
    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public int Resultado() {
            return memoria;
        }
    }

    class MetodosComRetorno
    {
        public static void Executar() {
            var calc = new CalculadoraComum();
            Console.WriteLine(calc.Somar(1,2,3));

            var calcCadeia = new CalculadoraCadeia();

            calcCadeia.Somar(3);
            Console.WriteLine(calcCadeia.Resultado());
            calcCadeia.Multiplicar(4);
            Console.WriteLine(calcCadeia.Resultado());
        }
    }
}
