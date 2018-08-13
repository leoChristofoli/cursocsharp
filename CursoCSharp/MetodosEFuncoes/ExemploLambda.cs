using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class ExemploLambda {
        public static void Executar() {
            Action algoNoConsole = () => {
                Console.WriteLine("Lambda");
            };

            algoNoConsole();

            /*
             * Actions sempre o retorno é Void
             */

            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHex = numero => numero.ToString("X");
            string conversor(int numero) => numero.ToString("X");

            Console.WriteLine(conversorHex(1234));
            Console.WriteLine(conversor(1234));
        }
    }
}
