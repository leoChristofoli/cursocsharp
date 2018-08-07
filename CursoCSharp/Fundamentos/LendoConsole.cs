using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;


namespace CursoCSharp.Fundamentos
{
    class LendoConsole
    {
        public static void Executar() {
            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            
            Console.WriteLine("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Salário: ");
            double salario = double.Parse(Console.ReadLine()
                ,CultureInfo.InvariantCulture
                );

            Console.WriteLine($"Nome: {nome} Idade: {idade} Salário: R${salario}");
        }
    }
}
