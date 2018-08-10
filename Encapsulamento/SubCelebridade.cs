using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class SubCelebridade {
        // todos
        public string infoPublica = "Tenho Instagram";

        // herença
        protected string CorDosOlhos = "Verde";

        // mesmo projeto (assembly)
        internal ulong NumeroCelular = 55199999999;

        // herança ou mesmo projeto
        protected internal string JeitoDeFalar = "normal";

        // mesma class ou herança no mesmo projeto (C# >=7.2)
        private protected string SegredoDefamilia = "secret";

        // private é o padrão
        bool UsaPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine(infoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoDefamilia);
            Console.WriteLine(UsaPhotoshop);
        }

    }
}
