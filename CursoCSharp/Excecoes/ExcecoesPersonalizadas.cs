using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes {

    public class NegativoException : Exception {
        public NegativoException() { }

        public NegativoException(string message) : base(message) { }

        public NegativoException(string message, Exception inner) : base(message, inner) { }
    }

    public class ImparException : Exception {
        public ImparException(string message): base(message) { }
    }

    class ExcecoesPersonalizadas {

        public static int PositivoPar() {
            Random random = new Random();
            int valor = random.Next(-30, 30);

            if (valor < 0){
                throw new NegativoException("Numero Negativo: " + valor);
            }

            if (valor % 2 == 1) {
                throw new ImparException("Numero Impar: " + valor);
            }

            return valor;
        }

        public static void Executar() {

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine("try #" + i);
                System.Threading.Thread.Sleep(1000);
                try {
                    Console.WriteLine(PositivoPar());
                }
                catch (Exception err) {
                    Console.WriteLine(err.Message);
                }
            }
        }
    }
}
