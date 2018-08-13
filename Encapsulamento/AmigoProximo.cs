using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class AmigoProximo {
        // Compisição
        public readonly SubCelebridade amiga = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Amigo Proximo");
            Console.WriteLine(amiga.infoPublica);
            //Console.WriteLine(amiga.CorDosOlhos); // herança - protected
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitoDeFalar);
            //Console.WriteLine(amiga.SegredoDefamilia); // private protected
            // Console.WriteLine(UsaPhotoshop); // private
        }
    }
}
