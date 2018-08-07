using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    interface Ponto {
        void MoverNaDiagonal(int delta);
    }

    struct Coordenada: Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }

        public void MoverNaDiagonal(int delta) {
            X += delta;
            Y += delta;
        }
        
    }

    class ExemploStruct {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("X:" + coordenadaInicial.X + " Y:" + coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 10, y: 5);
            coordenadaFinal.MoverNaDiagonal(15);

            Console.WriteLine("X: " + coordenadaFinal.X + " Y: " + coordenadaFinal.Y);

        }
    }
}
