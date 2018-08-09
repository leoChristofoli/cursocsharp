using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class CStack {
        public static void Executar() {
            var pilha = new Stack();

            pilha.Push(3);
            pilha.Push("string");

            foreach (var item in pilha) {
                Console.WriteLine(item);
            }

            Console.WriteLine(pilha.Pop());
            
        }
    }
}
