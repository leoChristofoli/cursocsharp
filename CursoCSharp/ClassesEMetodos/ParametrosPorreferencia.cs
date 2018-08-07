using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPorreferencia {

        public static void AlterarRef(ref int numero) {
            numero += 1000;
        }

        public static void AlterarOut(out int numero, out string resultado) {
            numero = 0;
            resultado = "success";
            numero += 250;
        }

        public static void AlterarString(string nome) {
            nome = "Alterado";
        }

        public static void Executar() {
            string a = "Original";
            AlterarString(a);
            Console.WriteLine(a);

            int b = 2; // Deve ser inicializada.
            AlterarRef(ref b);
            Console.WriteLine(b);

            int c;
            AlterarOut(out c, out string res);
            Console.WriteLine($"{c} {res}");
        }
    }
}
