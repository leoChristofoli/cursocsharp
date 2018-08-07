using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Membros
    {
        public static void Executar() {
            Pessoa p = new Pessoa {
                Nome = "leonardo",
                Idade = 28,
                Pernas = 1
            };

            Console.WriteLine(p.ToString());
            Console.WriteLine(p.Pernas);
        }
    }
}
