using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {

    public struct SPonto {
        public int X;
        public int Y;
    }

    public class CPonto {
        public int X;
        public int Y;
    }

    class StructVsClasse {
        public static void Executar() {
            SPonto ponto1 = new SPonto() { X = 1, Y = 2 };
            SPonto conpiaPonto1 = ponto1;
            ponto1.X = 10;

            CPonto ponto2 = new CPonto() { X = 3, Y = 5 };
            CPonto copiaPonto2 = ponto2;
            ponto2.X = 10;

            Console.WriteLine("Struct - Atribuição por valor:");
            Console.WriteLine(ponto1.X + " copia " + conpiaPonto1.X);

            Console.WriteLine("Class - Atribuição por referência:");
            Console.WriteLine(ponto2.X + " copia " + copiaPonto2.X);
        }
    }
}
