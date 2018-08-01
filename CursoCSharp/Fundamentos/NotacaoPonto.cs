using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos
{
    class NotacaoPonto
    {
        public static void Executar() {
            var saudacao = "Olá".Insert(3, " World!");
            Console.WriteLine(saudacao);

            string valor = null;
            Console.WriteLine(valor?.Length); // Só irá acessar valor se estiver instanciado. Navegação segura.
        }
    }
}
