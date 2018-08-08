using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class CSet {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 59.9);

            var carrinho = new HashSet<Produto>();

            var combo = new List<Produto> {
                new Produto("Camisa", 59.9),
                new Produto("Calça", 61.9),
                new Produto("Calça", 61.9)
            };

            var newItems = new List<int> {
                1,2,3,1
            };
            
            var toHash = new HashSet<Produto>(combo);
            foreach (var item in toHash) {
                Console.WriteLine(item);
                Console.WriteLine("----");
            }

            carrinho.UnionWith(combo);

            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);

            foreach (var item in carrinho) {
                Console.WriteLine(item);
            }
        }
    }
}
