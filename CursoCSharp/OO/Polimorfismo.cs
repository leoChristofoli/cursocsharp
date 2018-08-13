using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Comida {
        public double Peso;

        public Comida(double peso) {
            Peso = peso;
        }

        public Comida() { }
    }

    public class Feijao : Comida {
        public Feijao(double peso) : base(peso) { }
    }

    public class Arroz : Comida {
        public Arroz(double peso) : base(peso) { }

    }

    public class Carne : Comida {
        public Carne(double peso) : base(peso) { }

    }

    public class Pessoa {
        public double Peso;

        //public void Comer(Feijao feijao) {
        //    Peso += feijao.Peso;
        //}

        //public void Comer(Arroz arroz) {
        //    Peso += arroz.Peso;
        //}

        //public void Comer(Carne carne) {
        //    Peso += carne.Peso;
        //}

        public void Comer(Comida comida) {
            Peso += comida.Peso;
        }
    }

    class Polimorfismo {
        public static void Executar() {
            Feijao f = new Feijao(peso: 0.3);

            Arroz a = new Arroz(peso: 0.25);

            Carne c = new Carne(peso: 0.3);

            Pessoa cliente = new Pessoa {
                Peso = 80.2
            };

            Console.WriteLine(cliente.Peso + " Kg");
            cliente.Comer(f);
            cliente.Comer(a);
            cliente.Comer(c);
            Console.WriteLine(cliente.Peso + " Kg");

        }
    }
}
