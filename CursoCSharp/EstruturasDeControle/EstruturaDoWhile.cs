using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaDoWhile
    {
        public static void Executar() {
            string entrada;

            do {
                Console.Write("deseja conitnuar: ");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}
