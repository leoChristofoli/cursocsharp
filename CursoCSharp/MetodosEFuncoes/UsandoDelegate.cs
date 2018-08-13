using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class UsandoDelegate {

        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double, double b);

        static double MinhaSoma(double a, double b) {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a + b);
        }

        public static void Executar() {
            Soma op1 = MinhaSoma;
        }
    }
}
