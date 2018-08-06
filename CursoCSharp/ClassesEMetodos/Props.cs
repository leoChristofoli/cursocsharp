using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public class CarroOpcional {
        private readonly double desconto = 0.1;

        private string nome;
        public string Nome {
            get {
                return "Opcional: " + nome;
            }
            set {
                if (value == "1") {
                    Console.WriteLine("One");
                }
                nome = value;
            }
        }

        // Propriedade autoaplicada
        public double Preco { get; set; }

        //Somente leitura - Python: @property
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco);
        }
    }

    class Props {
        public static void Executar() {
            var a = new CarroOpcional() {
                Nome = "1",
                Preco = 34500
            };
            Console.WriteLine(a.PrecoComDesconto);
        }


    }
}

