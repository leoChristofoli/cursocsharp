using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class CQueue {

        private static void WriteQueueItems(Queue<string> queue) {
            foreach (var i in queue) {
                Console.WriteLine(i.ToString());
            }
        }
        public static void Executar() {
            var fila = new Queue<string>();
            fila.Enqueue("first");
            fila.Enqueue("second");
            fila.Enqueue("last");

            WriteQueueItems(fila);
            Console.WriteLine("---");
            Console.WriteLine(fila.Peek());
            Console.WriteLine("---");
            WriteQueueItems(fila);
            Console.WriteLine("---");
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine("---");
            WriteQueueItems(fila);

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("string");

            Console.WriteLine(salada.Contains("string"));
        }
    }
}
