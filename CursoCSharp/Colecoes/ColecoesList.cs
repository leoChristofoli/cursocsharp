using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
        public override string ToString() {
            return Nome + " R$" + Preco;
        }
    }

    class ColecoesList {
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 59.9);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                new Produto("Camisa", 59.9),
                new Produto("Calça", 61.9)
            };

            carrinho.AddRange(combo);

            var lastitem = carrinho[carrinho.Count - 1];
            carrinho.RemoveAt(carrinho.Count -1 );
            Console.WriteLine();

            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine(item);
            }
        }
    }
}
