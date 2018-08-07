using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "XPS 15";
            string marca = "Dell";
            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco); // contatenação

            Console.WriteLine(
                "O {0} da marca {1} custa {2}",
                nome,
                marca,
                preco
                );
            Console.WriteLine($"Preço: {preco}");
            Console.WriteLine($"Soma: {10 + 10}");

        }
    }
}
