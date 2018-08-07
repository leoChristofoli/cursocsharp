using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class ParametrosVariaveis
    {
        public static void Recepcionar(params string[] pessoas) {
            foreach(var pessoa in pessoas) {
                Console.WriteLine(pessoa);
            }
        }

        public static void Executar() {
            Recepcionar("p1", "p2", "p3");
        }
    }
}
