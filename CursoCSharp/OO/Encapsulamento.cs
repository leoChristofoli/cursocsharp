using System;
using System.Collections.Generic;
using System.Text;
using Encapsulamento;

namespace CursoCSharp.OO {
    class Encapsulamento {

        public class FilhoNaoReconhecido : SubCelebridade {
            public new void MeusAcessos() {
                Console.WriteLine("Filho não reconhecido");

                Console.WriteLine(infoPublica);
                Console.WriteLine(CorDosOlhos);
                //Console.WriteLine(NumeroCelular); // mesmo projeto
                Console.WriteLine(JeitoDeFalar);
                //Console.WriteLine(SegredoDefamilia);
                //Console.WriteLine(UsaPhotoshop);
            }
        }

        public class AmigoDistante {
            public readonly SubCelebridade amiga = new SubCelebridade();

            public void MeusAcessos() {
                Console.WriteLine("Amigo Distante");
                Console.WriteLine(amiga.infoPublica);
                //Console.WriteLine(amiga.CorDosOlhos); // herança - protected
                //Console.WriteLine(amiga.NumeroCelular);
                //Console.WriteLine(amiga.JeitoDeFalar);
                //Console.WriteLine(amiga.SegredoDefamilia); // private protected
                // Console.WriteLine(UsaPhotoshop); // private
            }
        }

        public static void Executar() {
            
        }
    }
}
