using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle
{
    class EstruturaWhile
    {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            int secreto = random.Next(1, 16);
            bool encontrado = false;
            int tentativasRestantes = 5;

            int tentativas = 0;

            while (tentativasRestantes > 0 && !encontrado) {
                Console.Write("Palpite: ");
                palpite = int.TryParse(Console.ReadLine(), out palpite) ? palpite : 0;

                tentativas++;
                tentativasRestantes--;

                if (secreto == palpite) {
                    encontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > secreto) {
                    Console.WriteLine("O numero secreto é menor");
                    Console.WriteLine("Tentativas restantes: {0}", tentativas);
                }
                else {
                    Console.WriteLine("O numero secreto é maior");
                    Console.WriteLine("Tentativas restantes: {0}", tentativas);
                }

            }

        }
    }
}
