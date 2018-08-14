using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    // Classes estáticas não podem ser instanciadas
    public static class ExtensoesInteiro {
        public static int Soma(this int num, int outroNum) {
            return num + outroNum;
        }

        public static string ToReal(this int num) {
            return "R$" + num;
        }
    }

    class MetodosDeExtensao {
        public static void Executar() {
            int a = 10;
            Console.WriteLine(a.ToReal());
        }
    }
}
