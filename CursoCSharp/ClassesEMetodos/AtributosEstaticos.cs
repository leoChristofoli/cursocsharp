using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Produto {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public Produto() {

        }

        public double CalcularDesconto() {
            return Preco - Preco * Desconto;
        }
    }

    class AtributosEstaticos
    {
        public static void Executar() {
            var produto1 = new Produto() {
                Nome = "Caneta",
                Preco=10,
            };
        }
    }
}
