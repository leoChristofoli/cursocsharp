using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAtribuicao
    {
        public static void Executar() {
            var num1 = 10;
            num1 += 3;
            num1 -= 3;
            num1 *= 5;
            num1 /= 5;

            num1++;

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c; // Por referência
        }
    }
}
