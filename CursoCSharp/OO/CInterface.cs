using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    interface IOperacaoBinaria {
        int Operacao(int a, int b); // public por padrão
    }

    class Soma : IOperacaoBinaria {
        public int Operacao(int a, int b) {
            return a + b;
        }
    }

    class Subtracao : IOperacaoBinaria {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }

    class Calculadora {
        List<IOperacaoBinaria> operacoes = new List<IOperacaoBinaria> {
            new Soma(),
            new Subtracao()
        };

        public string ExecutarOperacoes(int a, int b) {
            string resultado = "";

            foreach (var op in operacoes) {
                resultado += $" a {op.GetType().Name} = {op.Operacao(a, b)} \n";
            }

            return resultado;
        }
    }

    class CInterface {
        public static void Executar() {
            var calc = new Calculadora();
            var result = calc.ExecutarOperacoes(4, 4);
            Console.WriteLine(result);

        }
    }
}
