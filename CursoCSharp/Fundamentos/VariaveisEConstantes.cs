using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {
        public static void Executar() {
            // Area da circunferencia
            double raio = 4.5;
            const double pi = 3.14;
            
            double area = pi * raio * raio;

            Console.WriteLine("Area: " + area);

            // Tipos internos
            bool isNew = false;
            Console.WriteLine("bool: " + isNew);

            /*
             * byte = 1 byte
             * short = 2 bytes
             * int = 4 bytes
             * long = 8 bytes
             */
            byte idade = byte.MaxValue;
            Console.WriteLine("byte: " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("sbyte: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("short: " + salario);

            int number = int.MaxValue;
            Console.WriteLine("int: " + number);
            // uint = Positivo

            long bigNumber = long.MaxValue;
            Console.WriteLine("long: " + bigNumber);

        }
    }
}
