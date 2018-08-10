using System;
using System.Collections.Generic;
using System.Text;

/*
 * Este exemplo mostra como criar uma classe leve imutável que serve apenas para 
 * encapsular um conjunto de propriedades autoimplementadas. 
 * Use esse tipo de constructo em vez de um struct quando for necessário usar a semântica do tipo de referência.
 * É possível fazer uma propriedade imutável de duas maneiras.
 * É possível declarar o acessador set como privado. A propriedade será configurável somente dentro do tipo,
 * mas será imutável para os consumidores. Em vez disso, é possível declarar somente o acessador get,
 * o que torna a propriedade imutável em todos os lugares, exceto no construtor do tipo.
 */

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
        public double Preco { get; set; } //Propriedades sem o set podem ser iniciadas apenas atraves do construtor
        //com set privado, apenas através do construtor ou metodos da classe.

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

