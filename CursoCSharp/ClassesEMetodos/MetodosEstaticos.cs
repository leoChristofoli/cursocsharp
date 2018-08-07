using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Calculadora {
        /*
         * Metódos estáticos devem ser acessedos
         * sem a instãncia.
         * 
         * Pertencem à classe, não ao objeto.
         * 
         * Então, todas as instâncias compartilham seu valor.
         * 
         */
        public static int Somar(int a, int b) {
            return a + b;
        }
    }

    class MetodosEstaticos
    {
        public static void Executar() {
            var resultado = Calculadora.Somar(2, 2);
        }
    }
}
