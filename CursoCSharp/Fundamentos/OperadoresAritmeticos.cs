using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CursoCSharp.Fundamentos
{
    class OperadoresAritmeticos
    {
        public static void Executar() {
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;

            var totalComDesconto = total - total * desconto;
            Console.WriteLine("preço final: " + totalComDesconto);

            // IMC
            double peso = 60.5;
            double altura = 1.72;
            double imc = peso / (altura * altura);
            // ou
            //double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine("IMC: " + imc);

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(i);
            };

            foreach(int i in Enumerable.Range(1, 10)) {
                string result;
                result = i%2 == 0 ? " é par" : " é impar";
                Console.WriteLine(i + result);

            }
        }
    }
}
