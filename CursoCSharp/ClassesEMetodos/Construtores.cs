using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string Fabricante) {
            this.Fabricante = Fabricante;
        }

        public Carro() {

        } // Podemos instanciar sem parâmetros tbm
    }

    class Construtores
    {
        public static void Executar() {
            var carro1 = new Carro("BMW") {
                Modelo = "330i",
                Ano = 2010
            };

            var carro2 = new Carro();

        }
    }
}
