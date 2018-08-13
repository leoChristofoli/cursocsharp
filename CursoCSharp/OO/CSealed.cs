using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_407_033.85;
        }
    }

    class Avo {
        public virtual bool HonrarNome() {
            return true;
        }
    }

    class Pai : Avo {
        public sealed override bool HonrarNome() {
            return true;
        }
    }

    class Filho : Pai {
        //public override bool HonrarNome() {
        //    return false;
        //}
    }

    class CSealed {
        public static void Executar() {
            Filho filho = new Filho();
            Console.WriteLine(filho.HonrarNome());

        }
    }
}
