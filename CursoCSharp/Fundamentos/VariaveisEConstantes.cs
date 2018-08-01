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
            uint positiveNumber = uint.MinValue;
            Console.WriteLine("uint: " + positiveNumber);

            long bigNumber = long.MaxValue;
            Console.WriteLine("long: " + bigNumber);

            ulong bigPositiveNumber = ulong.MaxValue;
            Console.WriteLine("long positive: " + bigPositiveNumber);

            float preco = 1299.99f; //4 bytes
            Console.WriteLine("float: " + preco);

            Console.WriteLine("double: " + area); //double tem 8 bytes

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("decimal: " + distanciaEntreEstrelas);

            char letra = 'a'; // uma letra
            Console.WriteLine("char :" + letra);

            string texto = "muitas letras"; // sempre " "
            Console.WriteLine("string: " + texto);

        }
    }
}
