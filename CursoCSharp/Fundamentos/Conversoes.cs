using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class Conversoes
    {
        public static void Executar() {
            double nota = 9.7;
            int notaTruncada = (int) nota; // Cast

            int.TryParse(Console.ReadLine(), out int numero);
            Console.WriteLine("Numero: {0}", numero);
        }
    }
}
