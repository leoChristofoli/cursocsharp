using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class OperadoresUnarios
    {
        public static void Executar() {
            var numero = 1;
            var numero2 = 2;

            Console.WriteLine(numero++ == --numero2);
            /* 
             * O pós fixado só será incrementado após a comparação,
             * enquanto o pré fixado será decrementado antes da comparação
             */
        }
    }
}
