using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api {
    class ExemploDatetime {
        public static void Executar() {
            var datetime = new DateTime(2018, 08, 31);

            Console.WriteLine(datetime.Day);

            var hoje = DateTime.Now;
            var amanha = hoje.AddDays(1);
            Console.WriteLine(amanha);
            Console.WriteLine(amanha.ToString("D"));
            Console.WriteLine(amanha.ToString("G"));
            Console.WriteLine(amanha.ToString("g"));
        }
    }
}
