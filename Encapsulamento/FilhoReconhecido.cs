using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    class FilhoReconhecido : SubCelebridade {

        public new void MeusAcessos() {
            Console.WriteLine("Filho Reconhecido");
            Console.WriteLine(infoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDefamilia);
            // Console.WriteLine(UsaPhotoshop);
        }
    }
}
