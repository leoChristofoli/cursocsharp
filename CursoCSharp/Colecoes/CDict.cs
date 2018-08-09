using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class CDict {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(1999, "Matrix");
            filmes.Add(2004, "Os Incriveis");

            filmes[2005] = "Aminésia";

            Console.WriteLine(filmes.GetValueOrDefault(2020)); 

            if (filmes.ContainsKey(1999)){
                Console.WriteLine(filmes[1999]);
            }

            foreach (var i in filmes) {
                Console.WriteLine(" " + i.Key + ": " + i.Value);
                
            }

            Console.WriteLine(filmes.Remove(2010));
             
            filmes.TryGetValue(2004, out string filme2004);
            Console.WriteLine(filme2004);
        }
    }
}
