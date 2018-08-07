using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ExemploEnum {

        public enum Genero { Acao, Terror, Comedia}

        public class Filme {
            public string Titulo;
            public Genero GeneroDoFilme;
        }

        public static void Executar() {
            int id = (int)Genero.Terror;
            var filme = new Filme() {
                Titulo = "Conjuring",
                GeneroDoFilme = Genero.Terror
            };
            Console.WriteLine(filme.Titulo + " " + filme.GeneroDoFilme + " " + id);

        }
    }
}
