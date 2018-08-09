using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class Cliente {
        public string Nome;

        private readonly DateTime Nascimento; // Pode ser atribuido apenas atraves de um construtor

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }
		public override string ToString()
		{
			return Nome + Nascimento.ToString();
		}
	}

    class Readonly {
		public static void Executar(){
			var cliente1 = new Cliente(
				nome: "João",
				nascimento:new DateTime(year: 1989, month: 10, day:13)
			);
			Console.WriteLine(cliente1);
		}
    }
}
