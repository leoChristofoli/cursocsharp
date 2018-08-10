using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual; //Private

        public Carro(int VelocidadeMaxima) {
            this.VelocidadeMaxima = VelocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual int Acelerar() {
            return AlterarVelocidade(5);
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }

    }

    public class Uno : Carro {
        // Explicitamente constroe a class pai
        public Uno(int velocidadeMaxima) : base(velocidadeMaxima) {

        }
    }

    public class Ferrari: Carro {
        public Ferrari(): base(350) {

        }

        public override int Acelerar() {
            return AlterarVelocidade(15);
        }

        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }

    class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno");

            Uno carro1 = new Uno(160);
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari");
            Ferrari ferrari = new Ferrari();
            Console.WriteLine(ferrari.Acelerar());
            Console.WriteLine(ferrari.Frear());

            Console.WriteLine("Ferrari do tipo Carro");
            Carro carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            /*
             * Como agora a ferrari é do tipo Carro(Pai),
             * o metodo que não foi sobrescrito é substituido.
             */

        }
    }
}
