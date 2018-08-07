using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {
        public string Nome;
        public int Idade;
        public int Pernas = 2;

        public string Apresentar() {
            return string.Format($"Meu nome é {Nome} e tenho {Idade} anos");
        }

        public void ToConsole() {
            Console.WriteLine(Apresentar());
        }

        public override string ToString() {
            return Apresentar();
        }
    }
}
