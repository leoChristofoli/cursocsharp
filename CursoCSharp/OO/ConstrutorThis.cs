using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Animal {
        public string Nome { get; set; }

        public Animal(string nome) {
            Nome = nome;
        }
    }

    public class Cachorro: Animal {

        /*
         * O construtor pode chamar um construtor da propria
         * classe, desde que um deles chame o construtor Pai.
         */

        public double Altura { get; set; } // Propriedade read/write

        public Cachorro(string nome): base(nome) {
            Console.WriteLine($"Cachorro {nome}");
        }

        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
        }

        public override string ToString() {
            return Nome + ": " + Altura + "cm";
        }
    }

    class ConstrutorThis {
        public static void Executar() {
            Cachorro c1 = new Cachorro("Max");
            var c2 = new Cachorro("Rufus", 55.6);

            Console.WriteLine(c1);
            Console.WriteLine(c2);

        }
    }
}
