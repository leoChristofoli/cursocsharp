﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegatesComParametros {

        public delegate int Operacao(int x, int y);

        public static int Soma(int x, int y) {
            return x + y;
        }

        public static string Calculadora(Operacao op, int x, int y) {
            var res = op(x, y);
            return "" + res;
        }

        public static void Executar() {
            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(subtracao, 3, 2));
            Console.WriteLine(Calculadora(Soma, 3, 2));
        }
    }
}
